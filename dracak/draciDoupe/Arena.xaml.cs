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
    /// Interaction logic for Arena.xaml
    /// </summary>
    public partial class Arena : Page
    {
        Random rnd = new Random();
        public int t = 0;
        public int i = 0;

        public Arena()
        {
            InitializeComponent();

            //Randomly picks creature
            Game.creature1.GetCreature();

            resultBattle.Text = "Prepare to fight!";
            //Player attributes
            playerName.Text = Game.player.Name;
            playerLevel.Text = "Level: " + Game.player.Level;
            playerHP.Text = "HP: " + Game.player.HP;
            playerXP.Text = "XP: " + Game.player.XP;
            playerDefence.Text = "Defence: " + Game.player.Defence;

            //Creature attributes
            creatureName.Text = Game.creature1.Name;
            creatureHP.Text = "HP: " + Game.creature1.HP;
            creatureDefence.Text = "Defence: " + Game.creature1.Defence;
            creatureImage.Source = new BitmapImage(new Uri($"{Game.creature1.GetImage(Game.creature1.Name)}", UriKind.Relative));

            if (Game.equipment.equipped.Contains("Bow"))
            {
                bowAttack.Visibility = Visibility.Visible;
            }
            else
            {
                bowAttack.Visibility = Visibility.Hidden;
            }
        }

        //Heavy attack
        private async void attackHeavy_Click(object sender, RoutedEventArgs e)
        {

            int c = Game.creature1.HP;

            //Defines that you have to wait 1 round to use it again
            t++;
            if (t % 2 == 0)
            {
                attackHeavy.IsEnabled = true;
            }
            else
            {
                attackHeavy.IsEnabled = false;
            }

            if (t % 4 == 0)
            {
                bowAttack.IsEnabled = true;
            }
            else
            {
                bowAttack.IsEnabled = false;
            }

            Game.player.HeavyAttack(Game.creature1);

            //Checks if creature is dead, if not it attacks player
            if (Game.creature1.CheckHP() == false)
            {
                Game.creature1.Attack(Game.player);
            }

            //Checks if you missed the heavy attack
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

            if (Game.creature1.CheckHP() == true)
            {
                attack.Content = "Continue";
            }
        }



        //Default attack
        private async void attack_Click(object sender, RoutedEventArgs e)
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

            if (t % 4 == 0)
            {
                bowAttack.IsEnabled = true;
            }
            else
            {
                bowAttack.IsEnabled = false;
            }



            attack.IsEnabled = false; //disabling button
                                      //Game.player.RegenerateHP(); //regenerates player HP

            //Checks if player is dead, if true window will shut down                  
            if (Game.player.CheckHP() == true)
            {
                resultBattle.Text = "You lost the battle, the game will end.";
                await Task.Delay(10000);
                //MainWindow win = new MainWindow();
                //win.Show();
                Application.Current.Shutdown();
            }

            //Checks if creature is dead, if true you won the battle and the game continues
            else if (Game.creature1.CheckHP() == true)
            {
                i++;
                attack.Content = "Continue";
                resultBattle.Text = "You won the battle.";
                Game.player.XP++; //adds xp point
                Game.player.LevelUp(); //checks player's xp points, when 3 player level up
                Game.player.RegenerateHP(); //player's HP restored to max
                await Task.Delay(800);

                //Getting items if you win the battle
                int fo = rnd.Next(100);
                if (fo >= 0)
                {
                    string bs = Game.item.LootItem();

                    //if you get something and you dont have it
                    if (!Game.inv.inventory.Contains(bs))
                    {
                        Game.inv.AddToInventory(bs);
                        resultBattle.Text = "You found a " + bs;
                        await Task.Delay(2000);
                    }

                    //you find something but you already have it
                    else
                    {
                        resultBattle.Text = "You found a " + bs + " but you already have it";
                        await Task.Delay(2000);
                    }
                }



                playerHP.Text = "HP: " + Game.player.HP;
                playerXP.Text = "XP: " + Game.player.XP;
                await Task.Delay(800);
                resultBattle.Text = "";
                creatureHP.Text = "HP: " + Game.creature1.HP;
                await Task.Delay(800);

                //level up, recieving an upgrade point and going back to the story 
                if (Game.player.LevelUp() == true)
                {
                    Game.player.Level++;
                    Game.player.MaxHP += 10;
                    Game.player.Damage += 10;
                    Game.player.Defence += 10;
                    Game.player.XP = 0;
                    playerHP.Text = "HP: " + Game.player.HP;
                    playerDefence.Text = "Defence: " + Game.player.Defence;
                    playerXP.Text = "XP: " + Game.player.XP;
                    resultBattle.Text = "You reached next level and your stats have been boosted.";
                    await Task.Delay(1000);
                }

                if (Game.player.Level == 11)
                {
                    resultBattle.Text = "You defeated every monster and won in the arena.";
                    await Task.Delay(2000);
                    Application.Current.Shutdown();
                }

                //creating new creature
                Game.creature1 = new Creature();
                Game.creature1.GetCreature();
                creatureName.Text = Game.creature1.Name;
                creatureHP.Text = "HP: " + Game.creature1.HP;
                creatureDefence.Text = "Defence: " + Game.creature1.Defence;
                creatureImage.Source = new BitmapImage(new Uri($"{Game.creature1.GetImage(Game.creature1.Name)}", UriKind.Relative));
                attack.IsEnabled = true;
                attack.Content = "Attack";
            }

            //battle continues
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
                attack.IsEnabled = true; //enables button

                if (Game.creature1.CheckHP() == true)
                {
                    attack.Content = "Continue";
                }
            }
        }

        private async void bow_Click(object sender, RoutedEventArgs e)
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

            if (t % 4 == 0)
            {
                bowAttack.IsEnabled = true;
            }
            else
            {
                bowAttack.IsEnabled = false;
            }

            bowAttack.IsEnabled = false;
            await Task.Delay(1000);
            Game.player.Attack(Game.creature1);
            await Task.Delay(1000);
            playerHP.Text = "HP: " + Game.player.HP;
            creatureHP.Text = "HP: " + Game.creature1.HP;
            bowAttack.IsEnabled = true; //enables button

            if (Game.creature1.CheckHP() == true)
            {
                attack.Content = "Continue";
            }
        }

        private void inventory_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new InventoryView();
        }
    }
}
