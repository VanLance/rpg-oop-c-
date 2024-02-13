using CharacterGenerator;
using System.Collections.Generic;
using System;

namespace CharacterService
{
    internal class CharacterService : ICharacterService
    {
        public string GetCharacter(string name, string archetype, string race)
        {
            Archetype newCharacterArchetype = archetypeMap[archetype.ToLower()]();
            Race newCharacterRace = raceMap[race.ToLower()]();
            RpgCharacter character = new RpgCharacter(name, newCharacterArchetype, newCharacterRace);
            return character.ToString();
        }
        private Dictionary<string, Func<Race>> raceMap = new Dictionary<string, Func<Race>>
        {
            { "dwarf", () => new Dwarf() },
            { "elf", () => new Elf() },
            { "halfling", () => new Elf() },
        };

        private Dictionary<string, Func<Archetype>> archetypeMap = new Dictionary<string, Func<Archetype>>
        {
            { "wizard", () => new Wizard() },
            { "barbarian", () => new Barbarian() },
            { "ranger", () => new Ranger() },
        };
    }

}
