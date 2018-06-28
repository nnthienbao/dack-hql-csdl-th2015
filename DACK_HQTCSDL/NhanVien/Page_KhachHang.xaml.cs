using BUS;
using DAO;
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

namespace DACK_HQTCSDL
{
    /// <summary>
    /// Interaction logic for Page_KhachHang.xaml
    /// </summary>
    /// 

    public partial class Page_KhachHang : Page
    {
        private KhachHangBUS khachHangBUS = new KhachHangBUS();

        public Page_KhachHang()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ReLoadDSKhachHang();
        }

        private void button_ThemKhachHang_Click(object sender, RoutedEventArgs e)
        {
            Window_ThemKhachHang wd = new Window_ThemKhachHang();
            if(wd.ShowDialog() == true)
            {
                ReLoadDSKhachHang();
            }
        }

        private void ReLoadDSKhachHang()
        {
            dataGrid_KhachHang.ItemsSource = khachHangBUS.LayDSKhachHang();
        }

        private void button_SuaKhachHang_Click(object sender, RoutedEventArgs e)
        {
            var khDangChon = dataGrid_KhachHang.SelectedItem as KHACHHANG;
            if (khDangChon == null) return;
            Window_SuaKhachHang wd = new Window_SuaKhachHang(khDangChon.MaKhachHang);
            if (wd.ShowDialog() == true)
            {
                ReLoadDSKhachHang();
            }
        }

        
    }
}
