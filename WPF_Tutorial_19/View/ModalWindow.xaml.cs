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
using System.Windows.Shapes;

namespace WPF_Tutorial_19.View
{
    /// <summary>
    /// Interaction logic for ModalWindow.xaml
    /// </summary>
    public partial class ModalWindow : Window
    {
        public ModalWindow( Window parentWindow)
        {
            Owner = parentWindow;
            InitializeComponent();
        }
        public bool Success { get; set; }
        public string Input { get; set; }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = txtInput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                btnOk.IsEnabled = false;
            else btnOk.IsEnabled = true;
        }
    }
}
