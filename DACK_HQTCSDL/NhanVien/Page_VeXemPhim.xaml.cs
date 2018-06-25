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

        private void Button_ChonViTri_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
