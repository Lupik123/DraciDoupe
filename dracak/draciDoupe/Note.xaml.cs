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

            notes.Add("YOU FOUND AN ITEM NEXT TO A DEAD BODY");
            notes.Add("YOU FOUND 30 TOLARS");
            notes.Add("YOU FOUND 10 TOLARS");
            notes.Add("YOU FOUND AN ITEM IN A DEAD MONSTER");
            notes.Add("YOU FOUND AN ITEM ON SKELETON");
            notes.Add("YOU FOUND 50 TOLARS");
            if (Game.player.Level == 1)
            {
                textBlock.Text = "LOOK CAREFULLY YOU CAN FIND ITEMS";
            }
            else if (Game.player.Level == 2)
            {
                i = rnd.Next(notes.Count() - 1);
                
                if (i == 0)
                {
                    string bs = Game.item.LootItem();

                    if (!Game.inv.inventory.Contains(bs))
                    {
                        Game.inv.AddToInventory(bs);
                        textBlock.Text = notes[i];
                    }
                    else
                    {
                        textBlock.Text = "YOU FOUND AN ITEM THAT YOU ALREADY HAVE";
                    }
                }

                else if (i == 1) Game.player.Tolars += 30;
                else if (i == 2) Game.player.Tolars += 10;
                else if (i == 3)
                {
                    string bs = Game.item.LootItem();

                    if (!Game.inv.inventory.Contains(bs))
                    {
                        Game.inv.AddToInventory(bs);
                        textBlock.Text = notes[i];
                    }
                    else
                    {
                        textBlock.Text = "YOU FOUND AN ITEM THAT YOU ALREADY HAVE";
                    }
                }

                else if (i == 4)
                {
                    string bs = Game.item.LootItem();

                    if (!Game.inv.inventory.Contains(bs))
                    {
                        Game.inv.AddToInventory(bs);
                        textBlock.Text = notes[i];
                    }
                    else
                    {
                        textBlock.Text = "YOU FOUND AN ITEM THAT YOU ALREADY HAVE";
                    }
                }

                else if (i == 5) Game.player.Tolars += 50;
            }

            else if (Game.player.Level == 3)
            {
                i = rnd.Next(notes.Count() - 1);
                if (i == 0)
                {
                    string bs = Game.item.LootItem();

                    if (!Game.inv.inventory.Contains(bs))
                    {
                        Game.inv.AddToInventory(bs);
                        textBlock.Text = notes[i];
                    }
                    else
                    {
                        textBlock.Text = "YOU FOUND AN ITEM THAT YOU ALREADY HAVE";
                    }
                }

                else if (i == 1) Game.player.Tolars += 30;
                else if (i == 2) Game.player.Tolars += 10;
                else if (i == 3)
                {
                    string bs = Game.item.LootItem();

                    if (!Game.inv.inventory.Contains(bs))
                    {
                        Game.inv.AddToInventory(bs);
                        textBlock.Text = notes[i];
                    }
                    else
                    {
                        textBlock.Text = "YOU FOUND AN ITEM THAT YOU ALREADY HAVE";
                    }
                }

                else if (i == 4)
                {
                    string bs = Game.item.LootItem();

                    if (!Game.inv.inventory.Contains(bs))
                    {
                        Game.inv.AddToInventory(bs);
                        textBlock.Text = notes[i];
                    }
                    else
                    {
                        textBlock.Text = "YOU FOUND AN ITEM THAT YOU ALREADY HAVE";
                    }
                }

                else if (i == 5) Game.player.Tolars += 50;
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Game();
        }
    }
}
