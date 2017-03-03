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
        public InventoryView()
        {
            InitializeComponent();
            string fml;
            List<Inventory> items = new List<Inventory>();

            foreach (string ffs in Game.inv.inventory)
            {
                fml = ffs;
                items.Add(new Inventory() { Title = Game.inv.item, Attack = Game.item.GetItemDamage(fml), Defence = Game.item.GetItemDefense(fml) });
            }
            lbInventory.ItemsSource = items;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Game();
        }

        
           
    }
}
