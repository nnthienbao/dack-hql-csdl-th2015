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
    public class ThamSoDAOTests
    {
        ThamSoDAO thamSoDAO = new ThamSoDAO();

        [TestMethod()]
        public void CapNhatGiaVeCoBanTest()
        {
            bool result = thamSoDAO.CapNhatGiaVeCoBan(80000);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CapNhatPhuThuChoNgoiDepTest()
        {
            bool result = thamSoDAO.CapNhatPhuThuChoNgoiDep(40000);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void LayGiaVeCoBanTest()
        {
            int? giaVeCoBan = thamSoDAO.LayGiaVeCoBan();
            Debug.WriteLine(giaVeCoBan);
        }

        [TestMethod()]
        public void LayTienPhuThemChoNgoiDepTest()
        {
            int? tienPhuThemChoNgoiDep = thamSoDAO.LayTienPhuThemChoNgoiDep();
            Debug.WriteLine(tienPhuThemChoNgoiDep);
        }
    }
}