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
    /// Interaction logic for slot.xaml
    /// </summary>
    public partial class slot : UserControl
    {
        public String slotID { get; set; }
        public bool isSlotReserved { get; set; }
        public bool isSelectedBtn { get; set; }

        public slot()
        {
            InitializeComponent();
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            isSelectedBtn = false;
            if (isSlotReserved == true)
            {
                this.Image_Slot.Source = new BitmapImage(new Uri(@"..\Image\slotRed.png", UriKind.Relative));
                this.Btn_Slot.IsEnabled = false;
            }
            this.Label_Slot.Content = slotID;
        }

        private void Btn_Slot_Click(object sender, RoutedEventArgs e)
        {
            if (isSelectedBtn == false)
            {
                isSelectedBtn = true;
                this.Btn_Slot.Background = new SolidColorBrush(Color.FromArgb(68, 0, 170, 141));
                this.BorderThickness = new Thickness(1);
                this.BorderBrush = new SolidColorBrush((Color.FromArgb(158, 0, 170, 141)));
            } else
            {
                isSelectedBtn = false;
                this.Btn_Slot.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));
                this.BorderThickness = new Thickness(0);
                this.BorderBrush = new SolidColorBrush((Color.FromArgb(0, 255, 255, 255)));
            }
        }

       
    }
}
