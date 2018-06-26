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
    public class PhongDAOTests
    {
        PhongDAO phongDAO = new PhongDAO();

        [TestMethod()]
        public void LayDSPhongTest()
        {
            var dsPhong = phongDAO.LayDSPhong();
            Assert.IsNotNull(dsPhong);
            Debug.WriteLine(dsPhong.Count);
        }

        [TestMethod()]
        public void LayPhongTheoMaTest()
        {
            var phong = phongDAO.LayPhongTheoMa("aaa");
            Assert.IsNull(phong);

            phong = phongDAO.LayPhongTheoMa("PHONG_002");
            Assert.IsNotNull(phong);
        }

        [TestMethod()]
        public void ThemPhongTest()
        {
            bool result = phongDAO.ThemPhong(null);
            Assert.IsFalse(result);

            result = phongDAO.ThemPhong("P02");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CapNhatPhongTest()
        {
            bool result = phongDAO.CapNhatPhong(null, "P002");
            Assert.IsFalse(result);

            result = phongDAO.CapNhatPhong("AAA", "P002");
            Assert.IsFalse(result);

            result = phongDAO.CapNhatPhong("PHONG_002", "P002");
            Assert.IsTrue(result);
        }
    }
}