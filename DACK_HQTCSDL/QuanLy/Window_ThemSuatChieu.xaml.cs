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
    /// Interaction logic for Window_ThemSuatChieu.xaml
    /// </summary>
    public partial class Window_ThemSuatChieu : Window
    {
        public Window_ThemSuatChieu()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DatePicker_NgayChieu.SelectedDate = DateTime.Today;
            this.DatePicker_NgayChieu.DisplayDateStart = DateTime.Today;
            this.DatePicker_NgayChieu.DisplayDateEnd = DateTime.Today.AddDays(3);
        }

        private void button_ThemSuatChieu_Click(object sender, RoutedEventArgs e)
        {
            //DateTime? temp = this.TimePicker_GioBatDau.Value;
            //System.Diagnostics.Debug.WriteLine(temp);
            //this.DialogResult = true;
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
