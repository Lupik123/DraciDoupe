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
    /// Interaction logic for Note.xaml
    /// </summary>
    public partial class Note : Page
    {
        List<string> notes = new List<string>();

        public Note()
        {
            InitializeComponent();

            /*notes.Add("NO WAY OUT");
            notes.Add("DEATH TRAP");
            notes.Add("THEY ARE EVERYWHERE");*/
            if (Game.player.Level == 1)
            {
                textBlock.Text = "NO WAY OUT  '";
            }
            if (Game.player.Level == 2)
            {
                textBlock.Text = ",  HUNGER IS REAL,";
            }
            if (Game.player.Level == 3)
            {
                textBlock.Text = "THEY, ARE 'EVERYWHERE_";
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Game();
        }
    }
}
