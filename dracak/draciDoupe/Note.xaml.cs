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
        int i;
        Random rnd = new Random();
        public Note()
        {
            InitializeComponent();

            notes.Add("YOU FOUND A WEAPON NEXT TO A DEAD BODY");
            notes.Add("YOU FOND A PIECE OF ARMOR ON SKELETON");
            notes.Add("YOU FOUND 50 TOLARS");
            if (Game.player.Level == 1)
            {
                textBlock.Text = "BE AWARE OF YOUR SOURROUNDINGS, YOU MAY FIND SOMETHING USEFUL";
            }
            else if (Game.player.Level == 2)
            {
                i = rnd.Next(notes.Count());
                textBlock.Text = notes[i];
                //if (i == 2) Game.player.Tolars += 50;
            }
            else if (Game.player.Level == 3)
            {
                i = rnd.Next(notes.Count());
                textBlock.Text = notes[i];
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Game();
        }
    }
}
