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
    /// Interaction logic for Page_ThietBi.xaml
    /// </summary>
    public partial class Page_ThietBi : Page
    {
        public Page_ThietBi()
        {
            InitializeComponent();
        }

        private void button_ThemThietBi_Click(object sender, RoutedEventArgs e)
        {
            Window_ThemThietBi wd = new Window_ThemThietBi();
            if (wd.ShowDialog() == true)
            {

            }
        }

        private void button_SuaThietBi_Click(object sender, RoutedEventArgs e)
        {
            Window_SuaThietBi wd = new Window_SuaThietBi();
            if (wd.ShowDialog() == true)
            {

            }
        }
    }
}
