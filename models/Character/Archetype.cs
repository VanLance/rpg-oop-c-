using CharacterGenerator;

namespace CharacterGenerator
{
    abstract public class Archetype
    {
        public string Name;
        public CharacterGenerator.Stats.StatType[] keyStats;
        public int HitDice = 10;
    }

    public class Wizard : Archetype
    {
        public Wizard()
        {
            Name = "Wizard";
            keyStats = new CharacterGenerator.Stats.StatType[] { CharacterGenerator.Stats.StatType.Intelligence, CharacterGenerator.Stats.StatType.Wisdom };
            HitDice = 8;
        }

    }
    public class Barbarian : Archetype
    {
        public Barbarian()
        {
            Name = "Barbarian";
            keyStats = new CharacterGenerator.Stats.StatType[] { CharacterGenerator.Stats.StatType.Strength, CharacterGenerator.Stats.StatType.Dexterity };
        }
    }
    public class Ranger : Archetype
    {
        public Ranger()
        {
            Name = "Ranger";
            keyStats = new CharacterGenerator.Stats.StatType[] { CharacterGenerator.Stats.StatType.Dexterity, CharacterGenerator.Stats.StatType.Constitution };
        }
    }
}
