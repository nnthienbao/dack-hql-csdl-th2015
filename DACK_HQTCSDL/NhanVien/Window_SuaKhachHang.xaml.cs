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
using System.Windows.Shapes;

namespace DACK_HQTCSDL
{
    /// <summary>
    /// Interaction logic for Window_SuaKhachHang.xaml
    /// </summary>
    public partial class Window_SuaKhachHang : Window
    {
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        private string maKH;
        public Window_SuaKhachHang(string maKH)
        {
            this.maKH = maKH;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FetchKhachHang();
        }

        private void FetchKhachHang()
        {
            KHACHHANG khachHang = khachHangBUS.LayKhachHangTheoMa(maKH);
            this.DataContext = khachHang;
        }

        private void button_SuaKhachHang_Click(object sender, RoutedEventArgs e)
        {
            CollapseLabelError();
            string hoTen = textbox_TenKhachHang.Text;
            bool gioiTinh = (bool)rd_Nam.IsChecked ? true : false;
            DateTime ngaySinh = (DateTime)timePicker_NgaySinh.SelectedDate;
            string cmnd = textbox_CMND.Text;
            string sdt = textbox_SoDienThoai.Text;

            bool error = false;
            if (!khachHangBUS.KiemTraHoTen(hoTen))
            {
                lb_Error_TenKhachHang.Visibility = Visibility.Visible;
                error = true;
            }
            if (!khachHangBUS.KiemTraNgaySinh(ngaySinh))
            {
                lb_Error_NgaySinh.Visibility = Visibility.Visible;
                error = true;
            }
            if (!khachHangBUS.KiemTraCMND(cmnd))
            {
                lb_Error_cmnd.Visibility = Visibility.Visible;
                error = true;
            }
            if (!khachHangBUS.KiemTraSDT(sdt))
            {
                lb_Error_SoDienThoai.Visibility = Visibility.Visible;
                error = true;
            }

            if (error) return;

            if (khachHangBUS.CapNhatKhachHang(maKH, hoTen, gioiTinh, ngaySinh, cmnd, sdt))
            {
            }

            this.DialogResult = true;
        }

        private void CollapseLabelError()
        {
            lb_Error_TenKhachHang.Visibility = Visibility.Collapsed;
            lb_Error_NgaySinh.Visibility = Visibility.Collapsed;
            lb_Error_cmnd.Visibility = Visibility.Collapsed;
            lb_Error_SoDienThoai.Visibility = Visibility.Collapsed;
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
