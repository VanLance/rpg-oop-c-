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

            new ArmorClass(character);

        }

        public void UpdateKeyStats(ref int currentStatIndex)
        {

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
                FieldInfo fieldInfo = typeof(Stats).GetField(statTypeField.Name);
                if (fieldInfo != null && Convert.ToString(fieldInfo.GetValue(character.stats)) == "0")
                {
                    fieldInfo.SetValue(character.stats, availableStats[currentStatIndex]);
                    currentStatIndex--;
                }
                if (statTypeField.Name != "value__")
                {
                }
            }
        }

    }
}
