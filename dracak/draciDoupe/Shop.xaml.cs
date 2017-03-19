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
    /// Interaction logic for Shop.xaml
    /// </summary>
    public partial class Shop : Page
    {
        string title;
        int damage;
        int defense;
        int sum;

        public Shop()
        {
            InitializeComponent();

            string fml;
            List<Inventory> items = new List<Inventory>();

            foreach (string ffs in Game.item.itemType)
            {
                fml = ffs;
                items.Add(new Inventory() { Title = fml, Attack = Game.item.GetItemDamage(fml), Defence = Game.item.GetItemDefense(fml) });
            }
            lbInventory.ItemsSource = items;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Game();
        }



        private void lbInventory_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lbInventory.SelectedItem != null)
                this.Title = (lbInventory.SelectedItem as Inventory).Title;
            foreach (object o in lbInventory.SelectedItems)
            {
                ItemPopup.IsOpen = true;
                type.Text = "Type: " + (o as Inventory).Title;
                attack.Text = "Attack: " + (o as Inventory).Attack;
                defence.Text = "Defence: " + (o as Inventory).Defence;
                price.Text = "Price: " + Game.item.GetItemPrice((o as Inventory).Title);
                itemImage.Source = new BitmapImage(new Uri($"{Game.item.GetItemImage((o as Inventory).Title)}", UriKind.Relative));

                title = (o as Inventory).Title;
                damage = (o as Inventory).Attack;
                defense = (o as Inventory).Defence;
                sum = Game.item.GetItemPrice((o as Inventory).Title);

                if (Game.inv.inventory.Contains((o as Inventory).Title))
                {
                    buy.IsEnabled = false;
                }
                else if (Game.player.Tolars < Game.item.GetItemPrice((o as Inventory).Title))
                {
                    buy.IsEnabled = false;
                }

                else
                {
                    buy.Content = "Buy";
                    buy.IsEnabled = true;
                }
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            ItemPopup.IsOpen = false;
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            if (!Game.inv.inventory.Contains(title) && Game.player.Tolars >= sum)
            {
                Game.inv.AddToInventory(title);
                Game.player.Tolars -= sum;
                buy.IsEnabled = false;
            }

            else
            {
                buy.IsEnabled = false;
            }
        }
    }
}
