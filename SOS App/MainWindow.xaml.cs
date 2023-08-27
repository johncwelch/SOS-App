using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace SOS_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //internal static MainWindow? Main;
        public MainWindow()
        {
            InitializeComponent();
            currentTurnPlayerLabel.Content = "Blue";
            boardSizePicker.SelectedIndex = 0;
            bluePlayerHuman.IsChecked = true;
            redPlayerHuman.IsChecked = true;
            gameTypeSimple.IsChecked = true;
        }

        GameCore _theGame = new GameCore();

        
        /*private void initialSetup()
        {
            _theGame.initialSetup();
        }*/
        /*private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Main = this;
            
            
            //AnyClassOrWindow.ShowValue();
        }*/
    }
}
