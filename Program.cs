using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RpgCharacter rpgCharacter = new RpgCharacter("gandalf",
                new Wizard(),
                new Elf()
                );
            rpgCharacter.BuildStats();
        }
    }
}
