using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CharacterGenerator.Stats;


namespace CharacterGenerator
{

    public class RpgCharacter
    {
        public string name;
        public Race race;
        public Archetype archetype;
        public Stats.Stats stats;

        public RpgCharacter(string name, Archetype archetype, Race race)
        {
            this.name = name;
            this.race = race;
            this.archetype = archetype;
            stats = new Stats.Stats();
            new Stats.BuildStats(this);
        }

        public override string ToString()
        {
            // Update rest of toStrings
            return $"Name: {name}\n";
        }

    }
}
