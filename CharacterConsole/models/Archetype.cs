namespace CharacterGenerator
{
    abstract public class Archetype
    {
        public string Name;
        public Stats.StatType[] keyStats;
        public int HitDice = 10;
    }

    public class Wizard : Archetype
    {
        public Wizard()
        {
            Name = "Wizard";
            keyStats = new Stats.StatType[] { Stats.StatType.Intelligence, Stats.StatType.Wisdom };
            HitDice = 8;
        }

    }
    public class Barbarian : Archetype
    {
        public Barbarian()
        {
            Name = "Barbarian";
            keyStats = new Stats.StatType[] { Stats.StatType.Strength, Stats.StatType.Dexterity };
        }
    }
    public class Ranger : Archetype
    {
        public Ranger()
        {
            Name = "Ranger";
            keyStats = new Stats.StatType[] { Stats.StatType.Dexterity, Stats.StatType.Constitution };
        }
    }
}
