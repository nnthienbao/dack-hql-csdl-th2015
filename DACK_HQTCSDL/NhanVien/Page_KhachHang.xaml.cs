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

    //  Class này sẽ xóa đi do sau này sử dụng class từ DTO, cái này chỉ dùng để demo thôi nhé
    public class KhachHang
    {
        public String maKhachHang { get; set; }
        public String tenKhachHang { get; set; }
        public String gioiTinh { get; set; }
        public String ngaySinh { get; set; }
        public String CMND { get; set; }
        public String soDienThoai { get; set; }
    }
    //  -- END demo

    public partial class Page_KhachHang : Page
    {
        
        public Page_KhachHang()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void button_ThemKhachHang_Click(object sender, RoutedEventArgs e)
        {
            Window_ThemKhachHang wd = new Window_ThemKhachHang();
            if (wd.ShowDialog() == true)
            {
                //pageDSLoaiSach.RefreshDanhSach();
            }
        }

        private void button_SuaKhachHang_Click(object sender, RoutedEventArgs e)
        {
            Window_SuaKhachHang wd = new Window_SuaKhachHang();
            if (wd.ShowDialog() == true)
            {
                //pageDSLoaiSach.RefreshDanhSach();
            }
        }

        
    }
}
