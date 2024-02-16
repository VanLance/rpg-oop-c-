﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CharacterService.DTO
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RpgCharacterDto", Namespace="http://schemas.datacontract.org/2004/07/CharacterService.DTO")]
    public partial class RpgCharacterDto : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ArchetypeNameField;
        
        private string NameField;
        
        private string RaceNameField;
        
        private CharacterService.DTO.StatsDto StatsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArchetypeName
        {
            get
            {
                return this.ArchetypeNameField;
            }
            set
            {
                this.ArchetypeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RaceName
        {
            get
            {
                return this.RaceNameField;
            }
            set
            {
                this.RaceNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CharacterService.DTO.StatsDto Stats
        {
            get
            {
                return this.StatsField;
            }
            set
            {
                this.StatsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatsDto", Namespace="http://schemas.datacontract.org/2004/07/CharacterService.DTO")]
    public partial class StatsDto : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CharismaField;
        
        private int ConstitutionField;
        
        private int DexterityField;
        
        private int IntelligenceField;
        
        private int StrengthField;
        
        private int WisdomField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Charisma
        {
            get
            {
                return this.CharismaField;
            }
            set
            {
                this.CharismaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Constitution
        {
            get
            {
                return this.ConstitutionField;
            }
            set
            {
                this.ConstitutionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Dexterity
        {
            get
            {
                return this.DexterityField;
            }
            set
            {
                this.DexterityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Intelligence
        {
            get
            {
                return this.IntelligenceField;
            }
            set
            {
                this.IntelligenceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Strength
        {
            get
            {
                return this.StrengthField;
            }
            set
            {
                this.StrengthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Wisdom
        {
            get
            {
                return this.WisdomField;
            }
            set
            {
                this.WisdomField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICharacterService")]
public interface ICharacterService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterService/GetCharacter", ReplyAction="http://tempuri.org/ICharacterService/GetCharacterResponse")]
    CharacterService.DTO.RpgCharacterDto GetCharacter(string characterName, string archetype, string race);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterService/GetCharacter", ReplyAction="http://tempuri.org/ICharacterService/GetCharacterResponse")]
    System.Threading.Tasks.Task<CharacterService.DTO.RpgCharacterDto> GetCharacterAsync(string characterName, string archetype, string race);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICharacterServiceChannel : ICharacterService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CharacterServiceClient : System.ServiceModel.ClientBase<ICharacterService>, ICharacterService
{
    
    public CharacterServiceClient()
    {
    }
    
    public CharacterServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CharacterServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CharacterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CharacterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public CharacterService.DTO.RpgCharacterDto GetCharacter(string characterName, string archetype, string race)
    {
        return base.Channel.GetCharacter(characterName, archetype, race);
    }
    
    public System.Threading.Tasks.Task<CharacterService.DTO.RpgCharacterDto> GetCharacterAsync(string characterName, string archetype, string race)
    {
        return base.Channel.GetCharacterAsync(characterName, archetype, race);
    }
}