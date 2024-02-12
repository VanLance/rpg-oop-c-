using System;
using System.Windows;

namespace CharacterGenerator
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            var app = new Application();
            var mainWindow = new MainWindow();

            app.Run(mainWindow);

            // GenerateAndDisplayCharactersInConsole();

        }
        static void GenerateAndDisplayCharactersInConsole()
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
