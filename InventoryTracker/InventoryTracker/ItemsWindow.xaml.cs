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
using System.Windows.Shapes;
using InventoryTracker.Models;

namespace InventoryTracker
{
    /// <summary>
    /// Interaction logic for ItemsWindow.xaml
    /// </summary>
    public partial class ItemsWindow : Window
    {
        public ItemsWindow()
        {
            InitializeComponent();

            // Don't show this window in the task bar
            ShowInTaskbar = false;
        }
        public InventoryModel Item { get; set; }
        
        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void uxAdd_Click(object sender, RoutedEventArgs e)
        {
            Item = new InventoryModel();
            Item.ID = Convert.ToInt32(uxID.Text);
            Item.ItemN = Convert.ToInt32(uxItemN.Text);
            Item.Description = uxDescription.Text;
            Item.Price = Convert.ToDouble(uxPrice.Text);
            Item.QntyOnHand = Convert.ToInt32(uxQntyOnHand.Text);
            Item.SelfCost = Convert.ToDouble(uxSelfCost.Text);
            Item.TotalValue = Convert.ToDouble(uxPrice.Text) * Convert.ToInt32(uxQntyOnHand.Text);

            DialogResult = true;
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Item != null)
            {
               uxAdd.Content = "Update";
            }
            else
            {
                Item = new InventoryModel();
            }

            uxGrid.DataContext = Item;
        }
    }
}