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

namespace DACK_HQTCSDL
{
    /// <summary>
    /// Interaction logic for Window_ThemThietBi.xaml
    /// </summary>
    public partial class Window_ThemThietBi : Window
    {
        public Window_ThemThietBi()
        {
            InitializeComponent();
        }

        private void button_ThemThietBi_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
