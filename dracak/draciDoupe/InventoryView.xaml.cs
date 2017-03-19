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
    /// Interaction logic for InventoryView.xaml
    /// </summary>
    public partial class InventoryView : Page
    {
        public string title;
        public int damage;
        public int defense;

        public InventoryView()
        {
            InitializeComponent();
            string fml;
            List<Inventory> items = new List<Inventory>();

            foreach (string ffs in Game.inv.inventory)
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

        private void equip_Click(object sender, RoutedEventArgs e)
        {
            if (!Game.equipment.equipped.Contains(title))
            {
                bool tf = false;
                int num = Game.item.GetItemPlace(title);

                if (num == 1)
                {
                    if ((Game.equipment.hand.Count == 0 || Game.equipment.hand.Count == 1) && Game.equipment.hands.Count == 0)
                    {
                        tf = true;
                    }
                }

                else if (num == 2)
                {
                    if (Game.equipment.hand.Count == 0 && Game.equipment.hands.Count == 0)
                    {
                        tf = true;
                    }
                }

                else if (num == 3)
                {
                    tf = true;
                }
                if (tf == true)
                {
                    Game.equipment.AddToEquipment(title);
                    Game.player.Damage += damage;
                    Game.player.Defence += defense;
                    //equip.Content = title;
                    //equip.IsEnabled = false;
                    equip.Content = "Unequip";
                    equip.Click += unequip_Click;
                }
            }   
            
        }

        private void unequip_Click(object sender, RoutedEventArgs e)
        {
            if (Game.equipment.equipped.Contains(title))
            {
                Game.equipment.RemoveFromEquipment(title);
                Game.player.Damage -= damage;
                Game.player.Defence -= defense;
                //equip.Content = title;
                //equip.IsEnabled = false;
                equip.Content = "Equip";
                equip.Click += equip_Click;
            }
        }

        private void lbInventory_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lbInventory.SelectedItem != null)
                this.Title = (lbInventory.SelectedItem as Inventory).Title;
            foreach (object o in lbInventory.SelectedItems)
            {
                //MessageBox.Show((o as Inventory).Title);
                ItemPopup.IsOpen = true;
                type.Text = "Type: " + (o as Inventory).Title;
                attack.Text = "Attack: " + (o as Inventory).Attack;
                defence.Text = "Defence: " + (o as Inventory).Defence;
                itemImage.Source = new BitmapImage(new Uri($"{Game.item.GetItemImage((o as Inventory).Title)}", UriKind.Relative));

                title = (o as Inventory).Title;
                damage = (o as Inventory).Attack;
                defense = (o as Inventory).Defence;

                if (Game.equipment.equipped.Contains((o as Inventory).Title))
                {
                    equip.Content = "Unequip";
                    equip.Click += unequip_Click;
                }
                else
                {
                    equip.Content = "Equip";
                    equip.Click += equip_Click;
                }
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            ItemPopup.IsOpen = false;
        }
    }
}
