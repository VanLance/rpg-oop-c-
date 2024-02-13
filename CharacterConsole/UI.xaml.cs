using System.Windows;
using System.Windows.Controls;

namespace Character_Generator {
    public partial class UI : UserControl
    {
        public UI()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string characterName = nameTextBox.Text;

            ComboBoxItem selectedArchetypeItem = (ComboBoxItem)archetypeComboBox.SelectedItem;
            string archetype = selectedArchetypeItem?.Content.ToString();

            ComboBoxItem selectedRaceItem = (ComboBoxItem)raceComboBox.SelectedItem;
            string race = selectedRaceItem?.Content.ToString();

            MessageBox.Show($"{characterName} Race: {race} Class: {archetype}");

        }

        private void raceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
