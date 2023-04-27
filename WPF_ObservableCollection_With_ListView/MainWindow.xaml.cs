using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
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

namespace WPF_ObservableCollection_With_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Entries { get; set; }

        public MainWindow()
        {
            DataContext = this;
            Entries = new();
            Entries.Add("Hello");
            Entries.Add("cac ban");
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

            string item = (string)lsEntries.SelectedItem;
            Entries.Remove(item);
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(txtEntry.Text);
            txtEntry.Clear();
        }
    }
}
