using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO khachHangDAO = new KhachHangDAO();
        public IEnumerable LayDSKhachHang()
        {
            return khachHangDAO.LayDSKhachHang();
        }

        public KHACHHANG LayKhachHangTheoMa(string maKH)
        {
            return khachHangDAO.LayKhachHangTheoMaKH(maKH);
        }

        public bool ThemKhachHang(string hoTen, bool gioiTinh, DateTime ngaySinh, string cmnd, string sdt)
        {
            return khachHangDAO.ThemKhachHang(hoTen, gioiTinh, ngaySinh, cmnd, sdt);
        }

        public bool CapNhatKhachHang(string maKH, string hoTen, bool? gioiTinh, DateTime? ngaySinh, string CMND, string sdt)
        {
            return khachHangDAO.CapNhatKhachHang(maKH, hoTen, gioiTinh, ngaySinh, CMND, sdt);
        }

        public bool KiemTraHoTen(string hoTen)
        {
            return hoTen.Length > 0 && hoTen.Length <= 70;
        }

        public bool KiemTraNgaySinh(DateTime ngaySinh)
        {
            return ngaySinh < DateTime.Now;
        }

        public bool KiemTraCMND(string cmnd)
        {
            return cmnd.Length > 0 && cmnd.Length <= 10;
        }

        public bool KiemTraSDT(string sdt)
        {
            return sdt.Length > 0 && sdt.Length <= 11;
        }
    }
}
