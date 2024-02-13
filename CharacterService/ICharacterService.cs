using System.ServiceModel;

namespace CharacterService
{
    [ServiceContract]
    internal interface ICharacterService
    {
        [OperationContract]
        DTO.RpgCharacterDto GetCharacter(string characterName, string archetype, string race);
    }
}
