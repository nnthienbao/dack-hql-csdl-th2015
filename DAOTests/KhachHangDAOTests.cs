using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DAO.Tests
{
    [TestClass()]
    public class KhachHangDAOTests
    {
        KhachHangDAO khDAO = new KhachHangDAO();

        [TestMethod()]
        public void LayDSKhachHangTest()
        {
            var dsKH = khDAO.LayDSKhachHang();
            Debug.WriteLine("DSKH");
            Assert.IsNotNull(dsKH);
            foreach (KHACHHANG kh in dsKH)
            {
                Debug.WriteLine(kh.MaKhachHang);
            }
        }

        [TestMethod()]
        public void ThemKhachHangTest()
        {
            bool result = khDAO.ThemKhachHang("Thien Bao", true, DateTime.Now, "123456789", "123456789");
            Assert.IsTrue(result);

            // false do trung CMND
            result = khDAO.ThemKhachHang("Thien Bao", true, DateTime.Now, "123456789", "123456789");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CapNhatKhachHangTest()
        {
            bool result = khDAO.CapNhatKhachHang("aaaa", "Thien Bao", true, DateTime.Now, "111111", "1234567");
            // False do khong ton tai khach hang co ma 'aaaa'
            Assert.IsFalse(result);

            result = khDAO.CapNhatKhachHang("KH_00043", "Thiên Bảo", true, DateTime.Now, "111111", "1234567");
            Assert.IsTrue(result);
        }
    }
}