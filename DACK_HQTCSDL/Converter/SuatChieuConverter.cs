using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using DAO;
using BUS;

namespace DACK_HQTCSDL.Converter
{
    public class SuatChieuConverter : IValueConverter
    {
        private PhongBUS phongBUS = new PhongBUS();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var suatChieu = value as SUATCHIEU;
            if (suatChieu == null) return "NULL";
            var phong = phongBUS.LayPhongTheoId(suatChieu.MaPhong);
            StringBuilder builder = new StringBuilder();
                builder
                .Append("(")
                .Append(suatChieu.ThoiGianBatDau.ToString())
                .Append("-")
                .Append(suatChieu.ThoiGianKetThuc.ToString())
                .Append(")")
                .Append(" Phòng ")
                .Append(phong.TenPhong);

            return builder.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }
    }
}
