using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO    
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Danh sach khach hang</returns>
        public List<KHACHHANG> LayDSKhachHang()
        {
            try
            {
                using (var db = new DB_LOTTECINEMAEntities())
                {
                    return db.LAYDSKHACHHANG().ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hoTen"></param>
        /// <param name="gioiTinh">true: Nam, false: Nu</param>
        /// <param name="ngaySinh"></param>
        /// <param name="CMND"></param>
        /// <param name="sdt"></param>
        /// <returns>
        ///     true: them khach hang thanh cong
        ///     false: them khach hang that bai        
        /// </returns>
        public bool ThemKhachHang(string hoTen, bool gioiTinh, DateTime ngaySinh, string CMND, string sdt)
        {
            using (var db = new DB_LOTTECINEMAEntities())
            {
                try
                {
                    db.THEMKHACHHANG(hoTen, gioiTinh, ngaySinh, CMND, sdt);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maKH"></param>
        /// <param name="hoTen"></param>
        /// <param name="gioiTinh">true: Nam, false: Nu</param>
        /// <param name="ngaySinh"></param>
        /// <param name="CMND"></param>
        /// <param name="sdt"></param>
        /// <returns>
        ///     true: thanh cong
        ///     false: that bai
        /// </returns>
        public bool CapNhatKhachHang(string maKH, string hoTen, bool? gioiTinh, DateTime? ngaySinh, string CMND, string sdt)
        {
            using (var db = new DB_LOTTECINEMAEntities())
            {
                try
                {
                    db.CAPNHATKHACHHANG(maKH, hoTen, gioiTinh, ngaySinh, CMND, sdt);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
