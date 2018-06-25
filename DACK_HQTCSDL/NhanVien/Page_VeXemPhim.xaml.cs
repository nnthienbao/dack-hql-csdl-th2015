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

    //  Class này sẽ xóa đi do sau này sử dụng class từ DTO, cái này chỉ dùng để demo thôi nhé
    public class VeXemPhim
    {
        public String maVe { get; set; }
        public String maKhachHang { get; set; }
        public String giaVe { get; set; }
        public String tinhTrang { get; set; }
        public String tenChoNgoi { get; set; }
        public String maSuatChieu { get; set; }
        public String choNgoiDep { get; set; }
        public String soDienThoai { get; set; }
    }
    //  -- END demo class

    public partial class Page_VeXemPhim : Page
    {
        public Page_VeXemPhim()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DatePicker_NgayXem.SelectedDate = DateTime.Today;
            DatePicker_NgayXem.DisplayDateStart = DateTime.Today;
        }

        private void Button_DatVe_Click(object sender, RoutedEventArgs e)
        {
            Window_DatVe wd = new Window_DatVe();
            if (wd.ShowDialog() == true)
            {
                //pageDSLoaiSach.RefreshDanhSach();
            }
        }
    }
}
