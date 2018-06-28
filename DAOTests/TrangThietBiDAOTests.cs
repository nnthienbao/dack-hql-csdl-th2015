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
    public class TrangThietBiDAOTests
    {
        TrangThietBiDAO trangTBDao = new TrangThietBiDAO();

        [TestMethod()]
        public void LayDSTrangThietBiTest()
        {
            var dsTrangTB = trangTBDao.LayDSTrangThietBi();
            Assert.IsNotNull(dsTrangTB);
            Debug.WriteLine(dsTrangTB.Count);
        }

        [TestMethod()]
        public void LayTrangThietBiTheoMaTest()
        {
            var thietBi = trangTBDao.LayTrangThietBiTheoMa("aaa");
            Assert.IsNull(thietBi);

            thietBi = trangTBDao.LayTrangThietBiTheoMa("THIETBI_001");
            Assert.IsNotNull(thietBi);
        }

        [TestMethod()]
        public void ThemTrangThietBiTest()
        {
            bool result = trangTBDao.ThemTrangThietBi("3D", 50000);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CapNhatTrangThietBiTest()
        {
            bool result = trangTBDao.CapNhatTrangThietBi("aaa", "Phim 3D", null);
            Assert.IsFalse(result);

            result = trangTBDao.CapNhatTrangThietBi("THIETBI_001", "Phim 3D", null);
            Assert.IsTrue(result);
        }
    }
}