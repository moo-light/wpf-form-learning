using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WinForms = System.Windows.Forms;

namespace WPF_FolderBrowserDialog
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
            // Folder BrowerDialogonly uses for selecting brower
            WinForms.FolderBrowserDialog dialog = new();
            dialog.InitialDirectory = "E:\\learning in FPT";
            var result = dialog.ShowDialog();
            if(result == WinForms.DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
                MessageBox.Show("your selected path: " + folder,"Selected Folder");
            }
            else
            {

            }
        }
    }
}
