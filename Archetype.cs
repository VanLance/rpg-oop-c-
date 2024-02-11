using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    public class Archetype
    {
        public string Name;
        public Stats.StatType[] keyStats;
        public int HitDice = 10;
    }

    public class Wizard : Archetype
    {
        public Wizard()
        {
            Name = "wizard";
            keyStats = new Stats.StatType[]{ Stats.StatType.Intelligence, Stats.StatType.Wisdom };
            HitDice = 8;
        }

    }
    public class Barbarian : Archetype
    {
        public Barbarian()
        {
            Name = "barbarian";
            keyStats = new Stats.StatType[]{ Stats.StatType.Strength, Stats.StatType.Dexterity};
        }
    }
    public class Ranger : Archetype
    {
        public Ranger()
        {
            Name = "ranger";
            keyStats = new Stats.StatType[]{ Stats.StatType.Dexterity, Stats.StatType.Constitution };
        }
    }
}
