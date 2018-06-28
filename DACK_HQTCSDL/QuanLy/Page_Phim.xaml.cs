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
    /// Interaction logic for Page_Phim.xaml
    /// </summary>
    public partial class Page_Phim : Page
    {
        public Page_Phim()
        {
            InitializeComponent();
        }

        private void button_ThemPhim_Click(object sender, RoutedEventArgs e)
        {
            Window_ThemPhim wd = new Window_ThemPhim();
            if (wd.ShowDialog() == true)
            {
              
            }
        }

        private void button_SuaPhim_Click(object sender, RoutedEventArgs e)
        {
            Window_SuaPhim wd = new Window_SuaPhim();
            if (wd.ShowDialog() == true)
            {
                
            }
        }
    }
}
