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
using System.Windows.Shapes;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Popup : Window
    {
        public Popup()
        {
            InitializeComponent();
            buttonClicked();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public void buttonClicked()
        {
            confirmationBtn.Click += myEventHandler;
            declineBtn.Click += myEventHandler;
        }
        public void myEventHandler(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Name;
            switch (buttonText)
            {
                case "confirmationBtn":

                    Game.gameReset();
                    break;
                case "declineBtn":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
