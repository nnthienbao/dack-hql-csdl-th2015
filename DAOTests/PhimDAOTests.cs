using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Tests
{
    [TestClass()]
    public class PhimDAOTests
    {
        PhimDAO phimDAO = new PhimDAO();

        [TestMethod()]
        public void LayDSPhimTest()
        {
            var dsPhim = phimDAO.LayDSPhim();
            Assert.IsNotNull(dsPhim);
        }

        [TestMethod()]
        public void LayPhimTheoMaPhimTest()
        {
            //var phim = phimDAO.LayPhimTheoMaPhim();
        }

        [TestMethod()]
        public void ThemPhimTest()
        {
            bool result = phimDAO.ThemPhim("Kẻ hủy diệt", TINHTRANGPHIM.DANG_CHIEU, 120, 100);
            Assert.IsFalse(result);

            result = phimDAO.ThemPhim("Kẻ hủy diệt", TINHTRANGPHIM.DANG_CHIEU, 120, 1);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CapNhatPhimTest()
        {
            bool result = phimDAO.CapNhatPhim("AAAA", "Kẻ hủy diệt", null, 120, 100);
            Assert.IsFalse(result);

            result = phimDAO.CapNhatPhim("PHIM_0003", "Kẻ hủy diệt", TINHTRANGPHIM.HUY, 120, 1);
            Assert.IsTrue(result);
        }
    }
}