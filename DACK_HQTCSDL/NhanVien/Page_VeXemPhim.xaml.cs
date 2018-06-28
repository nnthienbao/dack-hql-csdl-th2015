using BUS;
using DACK_HQTCSDL.ModelForBinding;
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
    /// Interaction logic for Page_VeXemPhim.xaml
    /// </summary>
    /// 

    public partial class Page_VeXemPhim : Page
    {
        private PhimBUS phimBUS = new PhimBUS();
        private TrangThietBiBUS trangThietBiBUS = new TrangThietBiBUS();
        private SuatChieuBUS suatChieuBUS = new SuatChieuBUS();

        private List<ThietBiChecker> dsThietbiChecker = null;
        public Page_VeXemPhim()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            datePicker_NgayXem.SelectedDate = DateTime.Today;
            datePicker_NgayXem.DisplayDateStart = DateTime.Today;

            cbb_ChonPhim.ItemsSource = phimBUS.LayDSPhim();
            dsThietbiChecker = TaoListThietBiChon(trangThietBiBUS.LayDSTrangThietBi());
            listBox_DSThietBi.ItemsSource = dsThietbiChecker;
        }

        private List<ThietBiChecker> TaoListThietBiChon(List<TRANGTHIETBI> dsTrangThietBi)
        {
            var result = new List<ThietBiChecker>();
            foreach(var tb in dsTrangThietBi)
            {
                var tbChon = new ThietBiChecker(tb.id, tb.TenThietBi);
                result.Add(tbChon);
            }
            return result;
        }

        private void Button_DatVe_Click(object sender, RoutedEventArgs e)
        {
            Window_DatVe wd = new Window_DatVe();
            if (wd.ShowDialog() == true)
            {
                //pageDSLoaiSach.RefreshDanhSach();
            }
        }

        private void cbb_ChonPhim_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Button_DatVe.IsEnabled = false;
        }

        private void btn_Apply_TimSuatChieu_Click(object sender, RoutedEventArgs e)
        {
            PHIM phimChon = cbb_ChonPhim.SelectedItem as PHIM;
            DateTime chonNgay = (DateTime)datePicker_NgayXem.SelectedDate;

            var dsThietBi = LayTrangThietBiDangChon();
            var dsSuatChieuPhuHop = suatChieuBUS.TraCuuSuatChieu(phimChon.id, chonNgay, dsThietBi);
            cbb_ChonSuatChieu.ItemsSource = dsSuatChieuPhuHop;

            if(dsSuatChieuPhuHop.Count > 0)
            {
                Button_DatVe.IsEnabled = true;
                cbb_ChonSuatChieu.SelectedIndex = 0;
            }
        }

        private List<CT_THIETBI> LayTrangThietBiDangChon()
        {
            string strResult = "";
            var result = new List<CT_THIETBI>();   
            foreach(var tbChon in dsThietbiChecker)
            {
                if(tbChon.IsChecked)
                {
                    result.Add(new CT_THIETBI { MaThietBi = tbChon.MaThietBi });
                    strResult += tbChon.TenThietBi + ", ";
                }
            }
            //MessageBox.Show(strResult);
            return result;
        }

        private void datePicker_NgayXem_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void datePicker_NgayXem_SelectedDateChangd(object sender, SelectionChangedEventArgs e)
        {
            Button_DatVe.IsEnabled = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Button_DatVe.IsEnabled = false;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Button_DatVe.IsEnabled = false;
        }
    }
}
