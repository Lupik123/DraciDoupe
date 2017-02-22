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

namespace draciDoupe
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

        private void buttonName_Click(object sender, RoutedEventArgs e)
        {
            string name = insertName.Text;
            Game.player = new Player(insertName.Text, 150, 1, 0, 30, 50, 1);
            App.Current.MainWindow.Content = new Game();
            
        }

    }
}
