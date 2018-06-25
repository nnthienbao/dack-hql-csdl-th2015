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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class NhanVien : Window
    {
        private Page_KhachHang page_KhachHang = new Page_KhachHang();
        private Page_VeXemPhim page_VeXemPhim = new Page_VeXemPhim();
        public NhanVien()
        {
            InitializeComponent();
            this.MainFrame.Content = page_KhachHang;
        }

        private void button_KhachHang_Click(object sender, RoutedEventArgs e)
        {
            if (this.MainFrame.Content != page_KhachHang)
            {
                this.MainFrame.Content = page_KhachHang;
                this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xBF, 0xD7, 0xFF));
            }
            else
            {
                //page_KhachHang.RefreshDanhSach();
            }
        }

        private void button_VeXemPhim_Click(object sender, RoutedEventArgs e)
        {
            if (this.MainFrame.Content != page_VeXemPhim)
            {
                this.MainFrame.Content = page_VeXemPhim;
                this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x96, 0xDC, 0xD0));
            }
            else
            {
                //page_KhachHang.RefreshDanhSach();
            }
        }
    }
}
