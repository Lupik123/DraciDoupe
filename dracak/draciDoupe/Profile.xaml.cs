﻿using System;
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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();

            name.Text = "Name: " + Game.player.Name;
            level.Text = "Level: " + Game.player.Level;
            maxHP.Text = "HP: " + Game.player.HP;
            xp.Text = "XP: " + Game.player.XP;
            damage.Text = "Damage: " + Game.player.Damage;
            defence.Text = "Defence: " + Game.player.Defence;
            upgradePoints.Text = "Upgrade Points: " + Game.player.UpgradePoints;
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Content = new Game();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Game.player.UpgradePoints != 0)
            {
                Game.player.MaxHP += 10;
                maxHP.Text = "HP: " + Game.player.MaxHP;
                Game.player.UpgradePoints -= 1;
                upgradePoints.Text = "Upgrade Points: " + Game.player.UpgradePoints;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (Game.player.UpgradePoints != 0)
            {
                Game.player.Damage += 10;
                damage.Text = "Damage: " + Game.player.Damage;
                Game.player.UpgradePoints -= 1;
                upgradePoints.Text = "Upgrade Points: " + Game.player.UpgradePoints;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (Game.player.UpgradePoints != 0)
            {
                Game.player.Defence += 10;
                defence.Text = "Defence: " + Game.player.Defence;
                Game.player.UpgradePoints -= 1;
                upgradePoints.Text = "Upgrade Points: " + Game.player.UpgradePoints;
            }
        }
    }
}
