using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator.Stats
{
    public enum StatType
    {
        Strength,
        Dexterity,
        Constitution,
        Wisdom,
        Intelligence,
        Charisma
    }
    public class Stats
    {
        public HealthPointsManager Hp;
        public int Ac = 0;
        public int Strength = 0;
        public int Dexterity = 0;
        public int Constitution = 0;
        public int Wisdom = 0;
        public int Intelligence = 0;
        public int Charisma = 0;

        public int StatModifier(int statValue)
        {
           if(statValue >= 10) {
            return (statValue - 10) / 2;
           }
           return (statValue - 11) / 2;
        }
    }
}