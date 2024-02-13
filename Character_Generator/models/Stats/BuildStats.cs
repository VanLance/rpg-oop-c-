using System;
using System.Reflection;

namespace CharacterGenerator.Stats
{
    public class BuildStats
    {
        public RpgCharacter character;
        int[] availableStats = new RollStats().stats;

        public BuildStats(RpgCharacter character)
        {
            this.character = character;
            this.character.stats = new Stats();

            int currentStatIndex = availableStats.Length - 1;

            Array.Sort(availableStats);

            UpdateKeyStats(ref currentStatIndex);
            UpdateRemainingStats(ref currentStatIndex);
            character.stats.Hp = new HealthPointsManager(character);
            Console.WriteLine($"{character.stats.Hp.Total} Total HP");

            new ArmorClass(character);

            Console.WriteLine($"{character.stats.Ac} Total AC");
        }

        public void UpdateKeyStats(ref int currentStatIndex)
        {
            Console.WriteLine(character.Name);

            FieldInfo[] statFields = typeof(Stats).GetFields();
            foreach (StatType keyStat in character.Archetype.keyStats)
            {
                foreach (FieldInfo statField in statFields)
                {
                    if (statField.Name == keyStat.ToString())
                    {
                        statField.SetValue(character.stats, availableStats[currentStatIndex]);
                    }
                }
                currentStatIndex--;
            }
        }

        private void UpdateRemainingStats(ref int currentStatIndex)
        {
            FieldInfo[] fields = typeof(StatType).GetFields();
            foreach (FieldInfo statTypeField in fields)
            {
                Console.WriteLine(statTypeField.Name);
                FieldInfo fieldInfo = typeof(Stats).GetField(statTypeField.Name);
                if (fieldInfo != null && Convert.ToString(fieldInfo.GetValue(character.stats)) == "0")
                {
                    fieldInfo.SetValue(character.stats, availableStats[currentStatIndex]);
                    currentStatIndex--;
                }
                if (statTypeField.Name != "value__")
                {
                    Console.WriteLine(fieldInfo.GetValue(character.stats));
                }
            }
        }

    }
}
