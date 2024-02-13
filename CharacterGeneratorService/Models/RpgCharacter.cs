using System.Text;
using System.Xml.Linq;

namespace CharacterGenerator
{

    public class RpgCharacter
    {
        public string Name;
        public Race Race;
        public Archetype Archetype;
        public Stats.Stats stats;

        public RpgCharacter(string name, Archetype archetype, Race race)
        {
            Name = name;
            Race = race;
            Archetype = archetype;
            stats = new Stats.Stats();
            new Stats.BuildStats(this);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Race: {Race.Name}");
            stringBuilder.AppendLine($"Archetype: {Archetype.Name}");
            return stringBuilder.ToString();
        }

    }
}
