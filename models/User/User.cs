namespace CharacterGenerator.User
{
    internal class User
    {
        public string userName;
        public CharacterCache<RpgCharacter> characters;

        public User(string username) {
            username = username.Trim();
            characters = new CharacterCache<RpgCharacter>(3);
        }

        public void AddCharacter(RpgCharacter character)
        {
            characters.AddNode(character);
        }
    }
}
