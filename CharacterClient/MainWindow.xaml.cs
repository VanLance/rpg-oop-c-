using System;
using System.Windows;
using System.Windows.Controls;
using CharacterService;


namespace CharacterGenerator.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CharacterServiceClient client = new CharacterServiceClient();
      
    }


    private void foo() {

}
    private void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
        if (!FormValidation())
        {
            return;
        }

        string[] characterNameArray = nameTextBox.Text.Split(':');
        string characterName = characterNameArray[characterNameArray.Length - 1];

        ComboBoxItem selectedArchetypeItem = (ComboBoxItem)archetypeComboBox.SelectedItem;
        string archetype = selectedArchetypeItem?.Content.ToString();

        ComboBoxItem selectedRaceItem = (ComboBoxItem)raceComboBox.SelectedItem;
        string race = selectedRaceItem?.Content.ToString();

        MessageBox.Show($"Character Name: {characterName}\nArchetype: {archetype}\nRace: {race}");

        RpgCharacter character = CreateCharacterWithUserData(characterName, race, archetype);
        UpdateCharacterTextDisplay(character);

    }

    private void ClearNameText(object sender, RoutedEventArgs e)
    {
        TextBox nameTextBox = (TextBox)sender;
        string characterName = nameTextBox.Text;
        if (characterName == "Character Name: ")
        {
            {
                nameTextBox.Text = "";
            }

        }
    }

    private bool FormValidation()
    {
        if (string.IsNullOrEmpty(nameTextBox.Text) || archetypeComboBox.SelectedIndex == 0 || 0 == raceComboBox.SelectedIndex)
        {
            MessageBox.Show("Please fill out all fields: Name, Class, Race");
            return false;
        }
        return true;
    }
    private void UpdateCharacterTextDisplay(RpgCharacter character)
    {
        characterNameBlock.Text = $"{character.Name}: {character.Archetype.Name} {character.Race.Name}";
        hpTextBlock.Text = $"HP : {character.stats.Hp.Total}";
        acTextBlock.Text = $"AC : {character.stats.Ac}";
        strengthTextBlock.Text = $"Strength : {character.stats.Strength}";
        dexterityTextBlock.Text = $"Dexterity : {character.stats.Dexterity}";
        constitutionTextBlock.Text = $"Constituition : {character.stats.Constitution}";
        intelligenceTextBlock.Text = $"Intelligence : {character.stats.Intelligence}";
        wisdomTextBlock.Text = $"Wisdom : {character.stats.Wisdom}";
        charismaTextBlock.Text = $"Charisma : {character.stats.Charisma}";
    }

    private RpgCharacter CreateCharacterWithUserData(string characterName, string race, string archetype)
    {
        Archetype newCharacterArchetype = archetypeMap[archetype.ToLower()]();
        Race newCharacterRace = raceMap[race.ToLower()]();
        return new RpgCharacter(characterName, newCharacterArchetype, newCharacterRace);
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