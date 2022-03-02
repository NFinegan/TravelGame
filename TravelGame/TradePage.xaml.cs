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
    /// Interaction logic for TradePage.xaml
    /// </summary>
    public partial class TradePage : Page
    {
        public TradePage()
        {
            InitializeComponent();


            //images for NPC's
            ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
            Uri imageUri = new Uri("Media/NyxGarlemald2.png", UriKind.Relative);
            Avatar1Image.Source = (ImageSource)imageSourceConverter.ConvertFrom(imageUri);
            Avatar1Image.Tag = "Media/NyxGarlemald2.png";

            Uri imageUri2 = new Uri("Media/NyxKugane2.png", UriKind.Relative);
            Avatar2Image.Source = (ImageSource)imageSourceConverter.ConvertFrom(imageUri2);
            Avatar2Image.Tag = "Media/NyxKugane2.png";

            Uri imageUri3 = new Uri("Media/NyxThavnair3.png", UriKind.Relative);
            Avatar3Image.Source = (ImageSource)imageSourceConverter.ConvertFrom(imageUri3);
            Avatar3Image.Tag = "Media/NyxThavnair3.png";


        }


        //Return to Start page from Marketplace
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri PlacesPage = new Uri("Start.xaml", UriKind.Relative);
            NavigationService.Navigate(PlacesPage);
        }

        private void Avatar1Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //click on images using tags
            Image AvatarImage = (Image)sender;

            MainWindow.game.CurrentPlayer.Username = AvatarImage.Tag.ToString();
        }



        private void NPCButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int index = 0;
            switch (button.Name)
            {
                case "AdventurerNPCButton":
                    index = 1;
                    break;
                case "FloristNPCButton":
                    index = 0;
                    break;
                case "CitizenNPCButton":
                    index = 2;
                    break;
                default:
                    break;
            }

            NPC npc = MainWindow.game.NPCs[index];
            Item playerwanteditem = npc.Item;
            Item npcrequiredItem = npc.RequiredItem;
            bool status = MainWindow.game.CurrentPlayer.Trade(playerwanteditem, npcrequiredItem);
            if (status)
            {
                MessageBox.Show($"You traded {npcrequiredItem.ItemName} with {playerwanteditem.ItemName}.");
            }
            else
            {
                MessageBox.Show("I'm not interested in that. Sorry!");
            }
        }


    }
}
