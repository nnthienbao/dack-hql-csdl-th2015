using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class SuatChieuBUS
    {
        private SuatChieuDAO suatChieuDAO = new SuatChieuDAO();
        public List<SUATCHIEU> LayDSSuatChieuTheoPhim(int maPhim)
        {
            return suatChieuDAO.TraCuuSuatChieu(null, null, null, null, maPhim, null, null);
        }

        public List<SUATCHIEU> TraCuuSuatChieu(int maPhim, DateTime ngay, List<CT_THIETBI> dsThietBi)
        {
            return suatChieuDAO.TraCuuSuatChieu(ngay, ngay, null, null, maPhim, null, dsThietBi);
        }
    }
}
