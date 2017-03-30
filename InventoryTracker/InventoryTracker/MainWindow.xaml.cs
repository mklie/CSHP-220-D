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
using InventoryTracker.Models;
using System.ComponentModel;

namespace InventoryTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();

        }


        private void uxFileAdd_Click(object sender, RoutedEventArgs e)
        {
            var window = new ItemsWindow();

            if (window.ShowDialog() == true)
            {
                var uiInventoryModel = window.Item;

                var repositoryInventoryModel = uiInventoryModel.ToRepositoryModel();

                App.InventoryRepository.Add(repositoryInventoryModel);

                LoadItems();
                
            }
        }

        private InventoryModel selectedItem;

        private void uxInventoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem = (InventoryModel)uxInventoryList.SelectedValue;
        }

        private void LoadItems()
        {
            var items = App.InventoryRepository.GetAll();

            if (String.IsNullOrEmpty(uxFilter.Text))
            {
                uxInventoryList.ItemsSource = items
                .Select(t => InventoryModel.ToModel(t))
                .ToList().Where(t => t.Description.Contains(uxFilter.Text));
                
            }
            
        }

        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        public void GridViewColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
        {

            GridViewColumnHeader headerClicked =
              e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;

            if (headerClicked != null)
            {
                if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
                {
                    if (headerClicked != _lastHeaderClicked)
                    {
                        direction = ListSortDirection.Ascending;
                    }
                    else
                    {
                        if (_lastDirection == ListSortDirection.Ascending)
                        {
                            direction = ListSortDirection.Descending;
                        }
                        else
                        {
                            direction = ListSortDirection.Ascending;
                        }
                    }

                    string header = headerClicked.Column.Header as string;
                    Sort(header, direction);

                    _lastHeaderClicked = headerClicked;
                    _lastDirection = direction;

                }
            }
        }

        private void Sort(string sortBy, ListSortDirection direction)
        {
            ICollectionView dataView =
              CollectionViewSource.GetDefaultView(uxInventoryList.ItemsSource);

            dataView.SortDescriptions.Clear();
            SortDescription sd = new SortDescription(sortBy, direction);
            dataView.SortDescriptions.Add(sd);
            dataView.Refresh();
        }

        private void uxFileModify_Click(object sender, RoutedEventArgs e)
        {
            var window = new ItemsWindow();
            if (selectedItem != null)
                window.Item = selectedItem.Clone();
            
            if (window.ShowDialog() == true)
            {
                App.InventoryRepository.Update(window.Item.ToRepositoryModel());
                LoadItems();
            }
        }

        private void uxFileModify_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileModify.IsEnabled = (selectedItem != null);
            uxContextModify.IsEnabled = uxFileModify.IsEnabled;
        }

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {
            App.InventoryRepository.Remove(selectedItem.ItemN);
            selectedItem = null;
            LoadItems();
        }

        private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileDelete.IsEnabled = (selectedItem != null);
            uxContextDelete.IsEnabled = uxFileDelete.IsEnabled;
        }

        private void uxFileShowAll_Click(object sender, RoutedEventArgs e)
        {
            

                uxFilter.Clear();
                
        }

        private void uxFileLock_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxFileExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void uxAdministrationUsers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uxHelpAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inventory Tracker, Ver. 1.0, 2017, Created by E.Bogutskyi");
        }

        private void uxInventoryList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (selectedItem != null) 
            uxFileModify_Click(sender, e);
        }
        

        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
            CollectionViewSource.GetDefaultView(uxInventoryList.ItemsSource).Refresh();
            if (!String.IsNullOrEmpty(uxFilter.Text))
                    uxContextShowAll.IsEnabled = uxFileShowAll.IsEnabled = true;
            else uxContextShowAll.IsEnabled = uxFileShowAll.IsEnabled = false;
        }
    }
}
