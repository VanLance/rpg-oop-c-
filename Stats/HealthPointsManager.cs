using CharacterGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator.Stats
{
    public class HealthPointsManager
    {
        private int _current;
        readonly private RpgCharacter character;
        public int Current
        {
            get => _current;
            set
            {
                if (value > -1)
                {
                    _current = value;
                }
            }
        }

        public int Total;

        public HealthPointsManager(RpgCharacter character)
        {
            this.character = character;
            UpdateHP();
        }

        public void FillCurrentHealth()
        {
            Current = Total;
        }
        private void UpdateHP()
        {
            int constitutionModifier = character.stats.StatModifier(character.stats.Constitution);
            Total = character.archetype.HitDice + constitutionModifier;
        }
    }
}
