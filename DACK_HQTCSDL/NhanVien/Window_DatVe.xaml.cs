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
    /// Interaction logic for Window_DatVe.xaml
    /// </summary>
    public partial class Window_DatVe : Window
    {
        public Window_DatVe()
        {
            InitializeComponent();
        }

        private void CheckBox_MaKhachHang_Checked(object sender, RoutedEventArgs e)
        {
            this.textbox_MaKhachHang.IsEnabled = true;
            this.textbox_TenKhachHang.IsEnabled = false;
            this.textbox_SoDienThoai.IsEnabled = false;
            this.textbox_NgaySinh.IsEnabled = false;
            this.textbox_CMND.IsEnabled = false;
            this.radioButton_GioiTinhNam.IsEnabled = false;
            this.radioButton_GioiTinhNu.IsEnabled = false;
        }

        private void CheckBox_MaKhachHang_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textbox_MaKhachHang.IsEnabled = false;
            this.textbox_TenKhachHang.IsEnabled = true;
            this.textbox_SoDienThoai.IsEnabled = true;
            this.textbox_NgaySinh.IsEnabled = true;
            this.textbox_CMND.IsEnabled = true;
            this.radioButton_GioiTinhNam.IsEnabled = true;
            this.radioButton_GioiTinhNu.IsEnabled = true;
        }

        private void button_DatVe_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_HuyThaoTac_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void slot_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
