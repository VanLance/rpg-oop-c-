using CharacterGenerator;
using System.Runtime.Serialization;

namespace CharacterService.DTO
{
    [DataContract]
    public class RpgCharacterDto
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string ArchetypeName { get; set; }

        [DataMember]
        public string RaceName { get; set; }

        [DataMember]
        public StatsDto Stats { get; set; }

        public RpgCharacterDto() { }

        public RpgCharacterDto(RpgCharacter originalCharacter)
        {
            Name = originalCharacter.Name;
            ArchetypeName = originalCharacter.Archetype.Name;
            RaceName = originalCharacter.Race.Name;
            Stats = GenerateStats(originalCharacter);
        }

        private StatsDto GenerateStats(RpgCharacter originalCharacter)
        {
            return new StatsDto
            {
                Strength = originalCharacter.stats.Strength,
                Dexterity = originalCharacter.stats.Dexterity,
                Constitution = originalCharacter.stats.Constitution,
                Wisdom = originalCharacter.stats.Wisdom,
                Intelligence = originalCharacter.stats.Intelligence,
                Charisma = originalCharacter.stats.Charisma,
            };
        }
    }


}

