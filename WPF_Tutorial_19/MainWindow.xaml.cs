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
using WPF_Tutorial_19.View;

namespace WPF_Tutorial_19
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
        // with normal window you can still intteract with Mainwindow
        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow window = new NormalWindow();
            window.Show();
            txtInput.Text = window.txtInput.Text;
        }

        // with Modal window you can't intteract with Mainwindow
        private void btnModel_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow window = new( this);
            Opacity = 0.4;
            window.ShowDialog();
            Opacity =1;
            if (window.Success)
                txtInput.Text = window.txtInput.Text;
        }
    }
}
