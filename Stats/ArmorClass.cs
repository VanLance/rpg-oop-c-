using CharacterGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator.Stats
{
    internal class ArmorClass
    {
        private int Value {  get; set; }
        readonly private RpgCharacter character;
        public ArmorClass(RpgCharacter character)
        {
            this.character = character;

            InitialAC();
        }

        // Create Getters and Settters

        private void InitialAC()
        {
           Value = 10 + character.stats.StatModifier(character.stats.Dexterity);
            character.stats.Ac = Value;
        }
    }
}
