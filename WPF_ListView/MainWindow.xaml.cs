using System;
using System.Collections;
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

namespace WPF_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lsEntries.Items.Add("hello");
            lsEntries.Items.Add("cac ban");

        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            lsEntries.Items.Add(txtEntry.Text);
            txtEntry.Text = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            
            lsEntries.Items.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            //int index = lsEntries.SelectedIndex;
            //object item = lsEntries.SelectedItem; // lsEntries.Item[index];
            //var result = MessageBox.Show($"Are you sure you want to delete {item}", "Sure?", MessageBoxButton.YesNo);
            //if (result == MessageBoxResult.Yes)
            //{
            //    lsEntries.Items.RemoveAt(index);
            //}
            var items = lsEntries.SelectedItems;

            var result = MessageBox.Show($"Are you sure you want to delete {items.Count} items", "Sure?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var list = new ArrayList(items);
                foreach (var item in list)
                    lsEntries.Items.Remove(item);
            }
        }
    }
}
