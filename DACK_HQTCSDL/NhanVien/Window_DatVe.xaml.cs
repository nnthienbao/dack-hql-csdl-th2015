using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        List<String> List_DS_Ve = new List<String>();
        int soLuongVe = 0;

        public Window_DatVe()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

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

            this.textbox_TenKhachHang.Visibility = Visibility.Visible;
            this.textbox_NgaySinh.Visibility = Visibility.Visible;
            this.textbox_CMND.Visibility = Visibility.Visible;
            this.radioButton_GioiTinhNam.Visibility = Visibility.Visible;
            this.radioButton_GioiTinhNu.Visibility = Visibility.Visible;

            this.Label_CMND.Visibility = Visibility.Visible;
            this.Label_GioiTinh.Visibility = Visibility.Visible;
            this.Label_HoVaTen.Visibility = Visibility.Visible;
            this.Label_NgaySinh.Visibility = Visibility.Visible;
        }

        private void CheckBox_MaKhachHang_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textbox_MaKhachHang.IsEnabled = false;
            this.textbox_TenKhachHang.Visibility = Visibility.Hidden;
            this.textbox_SoDienThoai.IsEnabled = true;
            this.textbox_NgaySinh.Visibility = Visibility.Hidden;
            this.textbox_CMND.Visibility = Visibility.Hidden;
            this.radioButton_GioiTinhNam.Visibility = Visibility.Hidden;
            this.radioButton_GioiTinhNu.Visibility = Visibility.Hidden;

            this.Label_CMND.Visibility = Visibility.Hidden;
            this.Label_GioiTinh.Visibility = Visibility.Hidden;
            this.Label_HoVaTen.Visibility = Visibility.Hidden;
            this.Label_NgaySinh.Visibility = Visibility.Hidden;
        }

        private void button_DatVe_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void button_HuyThaoTac_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void UC_Slot_Click(object sender, EventArgs e)
        {
            String slotId = (sender as UC_Slot).slotID;
            bool isSelected = (sender as UC_Slot).isSelectedBtn;
            bool isReserved = (sender as UC_Slot).isSlotReserved;        

            if (isSelected)
            {
                List_DS_Ve.Add(slotId);
                soLuongVe++;
            }
            else
            {
                int index = List_DS_Ve.IndexOf(slotId);
                List_DS_Ve.RemoveAt(index);
                soLuongVe--;
            }

            this.Label_SoLuongVe.Content = soLuongVe;
            //  Để debug
            //Debug.WriteLine(" ");

            //foreach (String item in List_DS_Ve)
            //{
            //    Debug.WriteLine(item);
            //}
        }
    }
}
