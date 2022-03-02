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

//Reference code from IslandGame.zip (uploaded on November12th)
//Reference code from IslandGameV2.zip (uploaded November19th)
//Images taken from Square Enix (Final Fantasy XIV) – Images cut and photoshopped by Nicole Finegan.
//NPC Trade code debugged by Emre Biberoglu


namespace TravelGame
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public Start()
        {
            InitializeComponent();

            //Use index numbers to replace buttons name with Places names
            Places0.Content = MainWindow.game.Places[0].Placename;
            Places1.Content = MainWindow.game.Places[1].Placename;
            Places2.Content = MainWindow.game.Places[2].Placename;
            Places3.Content = MainWindow.game.Places[3].Placename;
            Places4.Content = MainWindow.game.Places[4].Placename;
            Places5.Content = MainWindow.game.Places[5].Placename;
            Places6.Content = MainWindow.game.Places[6].Placename;

            //Remember player name on each page
            Username.Text = MainWindow.game.CurrentPlayer.Username;

            //display inventory items
            string inventoryContent = String.Empty;
            foreach (string inventory in MainWindow.game.CurrentPlayer.Inventory)
            {
                inventoryContent += $"{inventory} \n";
            }

            //Adding items to inventory
            UserInventory.Text = inventoryContent;

        }

        private void Places_Click(object sender, RoutedEventArgs e)
        {
            //Button reference
            Button button = (Button)sender;

            //Refer back to tags per button
            int placesIndex = Convert.ToInt32(button.Tag);

            MainWindow.game.CurrentPlaces = MainWindow.game.Places[placesIndex];

            //Assign username to player
            MainWindow.game.CurrentPlayer.Username = Username.Text;

            //Navigate to new page per place
            Uri PlacesPage = new Uri("PlacesPage.xaml", UriKind.Relative);
            NavigationService.Navigate(PlacesPage);
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        //Navigate to Traders Market
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri PlacesPage = new Uri("TradePage.xaml", UriKind.Relative);
            NavigationService.Navigate(PlacesPage);
        }
    }
}
