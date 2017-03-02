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
    /// Interakční logika pro Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        public static Player player;
        public static Creature creature1 = new Creature();
        int i;

        List<string> story = new List<string>();

        public Game()
        {
            if (player.Level == 1)
            {
                story.Add("You wake up in a creepy looking dungeon and have no idea where exactly are you or how did you get here. You stand up and confusably look around. Your head hurts really bad so you assume you must have hit your head pretty hardy that you forgot how did you get here and why are you here. You see a note on the ground. Do you want to read it?");
                story.Add("You decided to find your way out. You are still trying to remember anything when you bump into someone or something more likely. It was a monster and it instantly attacks you.");
            }
            else if (player.Level == 2)
            {
                story.Add("You killed the monsters and continue on your way out but you are just going in circles. The dungeon is a one big maze and you want to give up when you start to remember that you went here on some kind of job for a rich Count but you can't remember his name.");
                story.Add("The revive of your memory gave you hope that you might remember a way out. You think that you are finally getting out but you find yourself at the dead end and there more monsters cornering you.");
            }
            else if (player.Level == 3)
            {
                story.Add("Somehow you have made it through and you can take your breath again. Your memory is slowly coming back and you now remember that went to retrieve a magical item for Count. There were one other man that eventually hit you in the head and left you to die. So Count sent you here and hoped that you would die. Your thoughts are on revenge. You find another note. You can take a look.");
                story.Add("You can almost see an exit from the dungeon but you have to face one last wave of enemies.");
            }
            else if (player.Level == 4)
            {
                story.Add("Finally! You have made it. Congratulations! Now you just need to take your revenge on Count.");
                story.Add("To be continued...");
            }
            InitializeComponent();

            if (player.XP == 3)
            {
                takeNote.Visibility = Visibility.Visible;
                player.XP = 0; //XP se vynuluje
            }
            
            
            textBlock.Text = story[0];
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Profile();
        }

        private void inventory_Click(object sender, RoutedEventArgs e)
        {

        }
        public void continue_Click(object sender, RoutedEventArgs e)
        {
            i++;
            textBlock.Text = story[i];
            takeNote.Visibility = Visibility.Hidden;
            if (i % 2 == 0)
            {
                App.Current.MainWindow.Content = new Battle();
            }

        }
        private void takeNote_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Note();
        }
    }
}
