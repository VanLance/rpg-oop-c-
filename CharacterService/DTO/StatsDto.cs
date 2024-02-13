using System.Runtime.Serialization;

namespace CharacterService.DTO
{
    [DataContract]
    public class StatsDto
    {
        [DataMember]
        public int Strength;

        [DataMember]
        public int Dexterity;

        [DataMember]
        public int Constitution;

        [DataMember]
        public int Wisdom;

        [DataMember]
        public int Intelligence;

        [DataMember]
        public int Charisma;
    }

}
