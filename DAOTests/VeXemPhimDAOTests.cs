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
    public class VeXemPhimDAOTests
    {
        VeXemPhimDAO veXemPhimDAO = new VeXemPhimDAO();

        [TestMethod()]
        public void LayDSVeTest()
        {
            var dsVe = veXemPhimDAO.LayDSVe();
            Assert.IsNotNull(dsVe);
            Debug.WriteLine(dsVe.Count);
        }

        [TestMethod()]
        public void LayVeTheoMaTest()
        {
            var ve = veXemPhimDAO.LayVeTheoMa("AAA");
            Assert.IsNull(ve);

            ve = veXemPhimDAO.LayVeTheoMa("VE_0001");
            Assert.IsNotNull(ve);
        }

        [TestMethod()]
        public void TraCuuVeTest()
        {
            var dsVe = veXemPhimDAO.TraCuuVe(34, null, null);
            Assert.IsNotNull(dsVe);
            Debug.WriteLine(dsVe.Count);
        }

        [TestMethod()]
        public void ThemVeTest()
        {
            // Test khong co thong tin khach hang
            bool result = veXemPhimDAO.ThemVe(null, TINHTRANGVE.DA_BAN, "B2", 4, true, null, "NV0001");
            Assert.IsFalse(result);

            // Test ve da ban
            result = veXemPhimDAO.ThemVe(33, TINHTRANGVE.DA_BAN, "B2", 4, true, null, "NV0001");
            Assert.IsFalse(result);

            // Test sai ma khach hang
            result = veXemPhimDAO.ThemVe(1000, TINHTRANGVE.DA_BAN, "B2", 4, true, null, "NV0001");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CapNhatVeTest()
        {
            // Test khong tim thay ma ve
            bool result = veXemPhimDAO.CapNhatVe("VE_00fff01", null, TINHTRANGVE.DA_DAT, null, null, null, null, "NV0001");
            Assert.IsFalse(result);

            // Test khong tim thay khach hang
            result = veXemPhimDAO.CapNhatVe("VE_0001", 3000, TINHTRANGVE.DA_DAT, null, null, null, null, "NV0001");
            Assert.IsFalse(result);

            // Test du lieu dung
            result = veXemPhimDAO.CapNhatVe("VE_0001", 34, TINHTRANGVE.DA_DAT, null, null, false, null, "NV0001");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void LayGiaVeTest()
        {
            int? giaVe = veXemPhimDAO.LayGiaVe(false, 4);
            Assert.IsNotNull(giaVe);

            Debug.WriteLine(giaVe);
        }
    }
}