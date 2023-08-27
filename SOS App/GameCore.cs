using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media.Animation;
using System.Windows;

namespace SOS_App
{
    internal class GameCore 
    {
        

        
       internal void InitialSetup()
        {
            //initialization of basic controls
            //MessageBox.Show((string)Main.currentTurnPlayerLabel.Content);
            currentTurnPlayerLabel.Content = "Blue";
            boardSizePicker.SelectedIndex = 0;
            bluePlayerHuman.IsChecked = true;
            redPlayerHuman.IsChecked = true;
            gameTypeSimple.IsChecked = true;
        }
       
    }
}
