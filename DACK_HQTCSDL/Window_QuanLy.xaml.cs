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

namespace DACK_HQTCSDL
{
    /// <summary>
    /// Interaction logic for Window_QuanLy.xaml
    /// </summary>
    public partial class Window_QuanLy : Window
    {
        public Window_QuanLy()
        {
            InitializeComponent();
        }

        private void button_Phim_Click(object sender, RoutedEventArgs e)
        {
            this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0xC6, 0x28, 0x28));
        }

        private void button_SuatChieu_Click(object sender, RoutedEventArgs e)
        {
            this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0x45, 0x27, 0xA0));
        }

        private void button_Phong_Click(object sender, RoutedEventArgs e)
        {
            this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0x02, 0x77, 0xBD));
            
        }

        private void button_ThietBi_Click(object sender, RoutedEventArgs e)
        {
            this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0x2E, 0x7D, 0x32));
            
        }

        private void button_DoHot_Click(object sender, RoutedEventArgs e)
        {
            this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0xFF, 0x8F, 0x00));
            
        }
    }
}
