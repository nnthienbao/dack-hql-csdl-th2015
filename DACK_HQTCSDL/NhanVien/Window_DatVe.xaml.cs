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
using BUS;
using DAO;

namespace DACK_HQTCSDL
{
    /// <summary>
    /// Interaction logic for Window_DatVe.xaml
    /// </summary>
    public partial class Window_DatVe : Window
    {
        private SuatChieuBUS suatChieuBUS = new SuatChieuBUS();
        private VeXemPhimBUS veXemPhimBUS = new VeXemPhimBUS();
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        List<String> List_DS_Ve = new List<String>();
        int soLuongVe = 0;

        private string maSuatChieu;
        public Window_DatVe(string maSuatChieu)
        {
            this.maSuatChieu = maSuatChieu;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SUATCHIEU suatChieu = suatChieuBUS.LaySuatChieuTheoMa(maSuatChieu);
            if (suatChieu == null) throw new Exception("Loi: Khong tim thay suat chieu");


        }

        private void CheckBox_MaKhachHang_Checked(object sender, RoutedEventArgs e)
        {
            //panel_ThongTinKhachHang.Visibility = Visibility.Visible;
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

            //this.Label_SoLuongVe.Content = soLuongVe;
            //  Để debug
            //Debug.WriteLine(" ");

            //foreach (String item in List_DS_Ve)
            //{
            //    Debug.WriteLine(item);
            //}
        }

        private void textbox_MaKhachHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(bool)cbb_MaKhachHang.IsChecked) return;

            if(e.Key == Key.Return)
            {
                panel_ThongTinKhachHang.Visibility = Visibility.Collapsed;
                lb_Error_MaKhachHang.Visibility = Visibility.Collapsed;
                // Lay thong tin ma khach hang, bao loi neu khong tim thay
                var khachHangTim = khachHangBUS.LayKhachHangTheoMa(textbox_MaKhachHang.Text);
                if(khachHangTim == null)
                {
                    lb_Error_MaKhachHang.Visibility = Visibility.Visible;
                    return;
                }

                FetchThongTinKhachHang(khachHangTim);
                panel_ThongTinKhachHang.Visibility = Visibility.Visible;
            }
        }

        private void FetchThongTinKhachHang(KHACHHANG khachHang)
        {
            textbox_TenKhachHang.Text = khachHang.HoTen;
            radioButton_GioiTinhNam.IsChecked = khachHang.GioiTinh;
            datePicker_NgaySinh.SelectedDate = khachHang.NgaySinh;
            textbox_CMND.Text = khachHang.CMND;
        }

        private void cbb_SoDienThoai_Checked(object sender, RoutedEventArgs e)
        {
            panel_ThongTinKhachHang.Visibility = Visibility.Collapsed;
        }

        private void textbox_MaKhachHang_TextChanged(object sender, TextChangedEventArgs e)
        {
            panel_ThongTinKhachHang.Visibility = Visibility.Collapsed;
        }
    }
}
