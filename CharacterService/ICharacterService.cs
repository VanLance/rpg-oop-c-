using System.ServiceModel;

namespace CharacterService
{
    [ServiceContract]
    internal interface ICharacterService
    {
        [OperationContract]
        string GetCharacter(string characterName, string archetype, string race);
    }
}
