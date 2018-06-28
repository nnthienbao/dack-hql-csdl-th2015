using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACK_HQTCSDL.ModelForBinding
{
    public class ThietBiChecker : INotifyPropertyChanged
    {
        private int maThietBi;
        private string tenThietBi;
        private bool isChecked = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public int MaThietBi
        {
            get
            {
                return maThietBi;
            }

            set
            {
                if (maThietBi != value)
                {
                    maThietBi = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("MaThietBi"));
                    }
                }
            }
        }

        public bool IsChecked
        {
            get
            {
                return isChecked;
            }

            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("IsChecked"));
                    }
                }
            }
        }

        public string TenThietBi
        {
            get
            {
                return tenThietBi;
            }

            set
            {
                if (tenThietBi != value)
                {
                    tenThietBi = value;
                    if(PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("TenThietBi"));
                    }
                }
            }
        }

        public ThietBiChecker(int maThietBi, string tenThietBi)
        {
            this.MaThietBi = maThietBi;
            this.TenThietBi = tenThietBi;
        }


    }
}
