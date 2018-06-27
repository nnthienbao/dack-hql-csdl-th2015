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
        private Page_Phim page_Phim = new Page_Phim();
        private Page_SuatChieu page_SuatChieu = new Page_SuatChieu();
        private Page_Phong page_Phong = new Page_Phong();
        private Page_ThietBi page_ThietBi = new Page_ThietBi();
        private Page_DoHot page_DoHot = new Page_DoHot();

        public Window_QuanLy()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Content = page_Phim;
        }
        // Button Phim click
        private void button_Phim_Click(object sender, RoutedEventArgs e)
        {
            if (this.MainFrame.Content != page_Phim)
            {
                this.MainFrame.Content = page_Phim;
                this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0xC6, 0x28, 0x28));
            }
        }
        //Button Suất chiếu click
        private void button_SuatChieu_Click(object sender, RoutedEventArgs e)
        {
            if (this.MainFrame.Content != page_SuatChieu)
            {
                this.MainFrame.Content = page_SuatChieu;
                this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0x45, 0x27, 0xA0));
            }
        }
        //Button Phòng click
        private void button_Phong_Click(object sender, RoutedEventArgs e)
        {
            if (this.MainFrame.Content != page_Phong)
            {
                this.MainFrame.Content = page_Phong;
                this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0x02, 0x77, 0xBD));
            }
            
        }
        //Button Thiết bị click
        private void button_ThietBi_Click(object sender, RoutedEventArgs e)
        {
            if (this.MainFrame.Content != page_ThietBi)
            {
                this.MainFrame.Content = page_ThietBi;
                this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0x2E, 0x7D, 0x32));
            }
            
        }
        //Button độ hot click
        private void button_DoHot_Click(object sender, RoutedEventArgs e)
        {
            if (this.MainFrame.Content != page_DoHot)
            {
                this.MainFrame.Content = page_DoHot;
                this.topStackPanel.Background = new SolidColorBrush(Color.FromArgb(0x33, 0xFF, 0x8F, 0x00));
            }
            
        }
    }
}
