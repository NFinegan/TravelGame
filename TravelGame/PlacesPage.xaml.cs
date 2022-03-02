using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TravelGame
{
    /// <summary>
    /// Interaction logic for PlacesPage.xaml
    /// </summary>
    public partial class PlacesPage : Page
    {
        public PlacesPage()
        {
            InitializeComponent();

            PlacesNamesLabel.Content = MainWindow.game.CurrentPlaces.Placename;

            //Update Description in rich text box depending on current place
            PlacesDescriptionText.Text = MainWindow.game.CurrentPlaces.Description;

            ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
            Uri imageUri = new Uri(MainWindow.game.CurrentPlaces.ImagePath, UriKind.Relative);
            PlacesImage.Source = (ImageSource)imageSourceConverter.ConvertFrom(imageUri);

            Greeting.Content = MainWindow.game.CurrentPlayer.Username;

            //display items
            ItemButton.Content = MainWindow.game.CurrentPlaces.Item.ItemName;

        }

        private void StartPageButton_Click(object sender, RoutedEventArgs e)
        {
            Uri StartPage = new Uri("Start.xaml", UriKind.Relative);
            NavigationService.Navigate(StartPage);
        }

        private void ItemButton_Click(object sender, RoutedEventArgs e)
        {
            string itemName = MainWindow.game.CurrentPlaces.Item.ItemName;

            if (MainWindow.game.CurrentPlayer.Inventory.Contains(itemName))
            {
                MessageBox.Show($"Don't be greedy! One per person!");
            }
            else
            {
                MainWindow.game.CurrentPlayer.Inventory.Add(itemName);
                MessageBox.Show($"You obtain a {itemName}.");
            }

        }
    }
}
