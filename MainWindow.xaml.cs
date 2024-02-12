using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CharacterGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected character name from the TextBox
            string characterName = nameTextBox.Text;

            // Get the selected archetype from the ComboBox
            ComboBoxItem selectedArchetypeItem = (ComboBoxItem)archetypeComboBox.SelectedItem;
            string archetype = selectedArchetypeItem?.Content.ToString();

            // Get the selected race from the ComboBox
            ComboBoxItem selectedRaceItem = (ComboBoxItem)raceComboBox.SelectedItem;
            string race = selectedRaceItem?.Content.ToString();

            // Display the selected data (for demonstration purposes)
            MessageBox.Show($"Character Name: {characterName}\nArchetype: {archetype}\nRace: {race}");
        }

    }
}
