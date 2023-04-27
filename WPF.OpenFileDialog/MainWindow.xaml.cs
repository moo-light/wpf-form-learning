using Microsoft.Win32;
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

namespace WPF_OpenFileDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new();
            //fileDialog.InitialDirectory = "c:\\any";
            fileDialog.Filter = "C# Source Files | *.cs";
            fileDialog.Title = "Please select a CS file(s)...";
            fileDialog.Multiselect = true;
            bool success = fileDialog.ShowDialog()??false;
            if (success)
            {
                string[] path = fileDialog.FileNames;
                string[] fileName = fileDialog.SafeFileNames;

                tbInfo.Text = string.Join(' ', fileName);
            }
            else
            {
                tbInfo.Text = "nothing has chosen";
            }
        }
    }
}
