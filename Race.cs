namespace CharacterGenerator
{

    public struct StatBuff
    {
        public string Name;
        public int Mod;
    }
    public class Race
    {
        public string Name;
        public StatBuff[] StatBuffs;
    }

    public class Dwarf : Race
    {
        public Dwarf()
        {
            Name = "Dwarf";
            StatBuffs = new StatBuff[] {
                new StatBuff {Name=  "constitution", Mod = 2}
            };
        }
    }

    public class Elf : Race
    {
        public Elf()
        {
            Name = "Elf";
            StatBuffs = new StatBuff[] {
                new StatBuff {Name = "dexterity", Mod = 2}
            };
        }
    }

    public class Halfling : Race
    {
        public Halfling()
        {
            Name = "Halfling";
            StatBuffs = new StatBuff[] {
                new StatBuff {Name = "dexterity", Mod = 2}
            };
        }
    }

    public class HalfOrc : Race
    {
        public HalfOrc()
        {
            Name = "Half-Orc";
            StatBuffs = new StatBuff[] {
                new StatBuff {Name = "strength", Mod = 2},
                new StatBuff {Name= "constitution", Mod = 1}
            };
        }
    }
}
