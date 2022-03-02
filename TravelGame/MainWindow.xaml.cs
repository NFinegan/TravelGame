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

namespace TravelGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create instance of new game
        public static Game game = new Game();


        public MainWindow()
        {
            InitializeComponent();

            ContentFrame.Navigate(new Start());

            //ContentFrame.Navigate(new TradePage()); <-- Change to have game start on Trade page
            //ContentFrame.Navigate(new Start()); <-- Start on start page
        }
    }
}
