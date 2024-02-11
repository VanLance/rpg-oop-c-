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
            
            RpgCharacter rpgCharacterRanger = new RpgCharacter("aragorn",
                new Ranger(),
                new Elf()
                );
            Console.WriteLine(rpgCharacterRanger.ToString());
            RpgCharacter rpgCharacter = new RpgCharacter("gandalf",
                new Wizard(),
                new Elf()
                );
            Console.WriteLine(rpgCharacter.ToString());
        }
    }
}
