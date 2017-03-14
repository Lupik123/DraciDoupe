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
    /// Interakční logika pro Battle.xaml
    /// </summary>
    public partial class Battle : Page
    {
        
        Random rnd = new Random();
        public int t = 0;

        public Battle()
        {
            InitializeComponent();

            Game.creature1.GetCreature();

            resultBattle.Text = "Prepare to fight!";
            //atributes
            playerName.Text = Game.player.Name;
            playerLevel.Text = "Level: " + Game.player.Level;
            playerHP.Text = "HP: " + Game.player.HP;
            playerXP.Text = "XP: " + Game.player.XP;
            playerDefence.Text = "Defence: " + Game.player.Defence;

            //atributes_creature
            creatureName.Text = Game.creature1.Name;
            creatureHP.Text = "HP: " + Game.creature1.HP;
            creatureDefence.Text = "Defence: " + Game.creature1.Defence;
            creatureImage.Source = new BitmapImage(new Uri($"{Game.creature1.GetImage(Game.creature1.Name)}", UriKind.Relative));


        }

        private async void attackHeavy_Click(object sender, RoutedEventArgs e)
        {
            int c = Game.creature1.HP;
            t++;
            if (t % 2 == 0)
            {
                attackHeavy.IsEnabled = true;
            }
            else
            {
                attackHeavy.IsEnabled = false;
            }
            Game.player.HeavyAttack(Game.creature1);
            
            
            if (Game.creature1.CheckHP() == false)
            {
                Game.creature1.Attack(Game.player);
            }
            if (Game.creature1.HP == c)
            {
                resultBattle.Text = "You missed!";
                Game.creature1.Attack(Game.player);
                await Task.Delay(2000);
                resultBattle.Text = "";
            }

            await Task.Delay(600);
            playerHP.Text = "HP: " + Game.player.HP;
            creatureHP.Text = "HP: " + Game.creature1.HP;
        }

        //attack
        private async void attack_Click(object sender, RoutedEventArgs e) //pri kliknuti na button se spusti funkce
        {
            t++;
            if (t % 2 == 0)
            {
                attackHeavy.IsEnabled = true;
            }
            else
            {
                attackHeavy.IsEnabled = false;
            }
            attack.IsEnabled = false; //nemuze se kliknout na button dokud se neukonci proces
            Game.player.RegenerateHP();
                              
            if (Game.player.CheckHP() == true) //jestli ma hrac mensi zivot nez 0
            {
                resultBattle.Text = "You lost the battle, the game will end.";
                await Task.Delay(10000);
                //MainWindow win = new MainWindow();
                //win.Show();
                Application.Current.Shutdown();
            }
            else if(Game.creature1.CheckHP() == true) // jestli zemre nepritel driv
            {
                resultBattle.Text = "You won the battle.";
                Game.player.XP++;
                Game.player.LevelUp();
                Game.player.RegenerateHP();
                await Task.Delay(800);
                int fo = rnd.Next(100);
                if (fo >= 1)
                {
                    string bs = Game.item.LootItem();

                    if (!Game.inv.inventory.Contains(bs))
                    {
                        Game.inv.AddToInventory(bs);
                        resultBattle.Text = "You found a " + bs;
                        await Task.Delay(1000);
                    }
                    else
                    {
                        resultBattle.Text = "You found a " + bs + " but you already have it";
                        await Task.Delay(1000);
                    }
                }
                playerHP.Text = "HP: " + Game.player.HP;
                playerXP.Text = "XP: " + Game.player.XP;
                await Task.Delay(800);
                resultBattle.Text = "";
                creatureHP.Text = "HP: " + Game.creature1.HP;
                await Task.Delay(800);

                if (Game.player.LevelUp() == true)
                {
                    Game.player.Level++; //pricte se lvl
                    Game.player.UpgradePoints++;
                    resultBattle.Text = "You reached next level and recieved one upgrade point.";
                    await Task.Delay(1000);
                    App.Current.MainWindow.Content = new Game();

                }
                else
                {
                    Game.creature1 = new Creature();
                    Game.creature1.GetCreature();
                    creatureName.Text = Game.creature1.Name;
                    creatureHP.Text = "HP: " + Game.creature1.HP;
                    creatureDefence.Text = "Defence: " + Game.creature1.Defence;
                    creatureImage.Source = new BitmapImage(new Uri($"{Game.creature1.GetImage(Game.creature1.Name)}", UriKind.Relative));
                    attack.IsEnabled = true;
                }
            }
                 
            //utoky
            else
            {
                Game.player.Attack(Game.creature1);
                await Task.Delay(1000);
                if (Game.creature1.CheckHP() == false)
                {
                    Game.creature1.Attack(Game.player);
                }
                await Task.Delay(1000);
                playerHP.Text = "HP: " + Game.player.HP;
                creatureHP.Text = "HP: " + Game.creature1.HP;
                attack.IsEnabled = true;
            }


            
            //kdyz hrac dosahne urciteho poctu XP
           
        }
    }
}
