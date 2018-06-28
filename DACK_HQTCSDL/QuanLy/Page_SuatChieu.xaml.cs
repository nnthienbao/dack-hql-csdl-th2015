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
    /// Interaction logic for Page_SuatChieu.xaml
    /// </summary>
    public partial class Page_SuatChieu : Page
    {
        public Page_SuatChieu()
        {
            InitializeComponent();
        }

        private void button_ThemSuatChieu_Click(object sender, RoutedEventArgs e)
        {
            Window_ThemSuatChieu wd = new Window_ThemSuatChieu();
            if (wd.ShowDialog() == true)
            {

            }
        }

        private void button_SuaSuatChieu_Click(object sender, RoutedEventArgs e)
        {
            Window_SuaSuatChieu wd = new Window_SuaSuatChieu();
            if (wd.ShowDialog() == true)
            {

            }
        }
    }
}
