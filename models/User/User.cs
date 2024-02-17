using CharacterGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Generator.models.User
{
    internal class User
    {
        public string userName;
        public RpgCharacter[] characters;

        public User(string username) {
            username = username.Trim();
            characters = new RpgCharacter[username.Length];
        }

        public void AddCharacter(RpgCharacter character)
        {
            characters.Append(character);
        }
    }
}
