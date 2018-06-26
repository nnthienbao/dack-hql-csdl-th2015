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
    public class DoHotPhimDAOTests
    {
        DoHotPhimDAO doHotPhimDAO = new DoHotPhimDAO();

        [TestMethod()]
        public void LayDSDoHotPhimTest()
        {
            var dsDoHot = doHotPhimDAO.LayDSDoHotPhim();
            Assert.IsNotNull(dsDoHot);
            foreach(DOHOTPHIM doHot in dsDoHot)
            {
                Debug.WriteLine("Ma: " + doHot.MaDoHot);
            }
        }

        [TestMethod()]
        public void LayDoHotPhimTheoMaTest()
        {
            DOHOTPHIM doHot = doHotPhimDAO.LayDoHotPhimTheoMa("aaaaa");
            Assert.IsNull(doHot);

            doHot = doHotPhimDAO.LayDoHotPhimTheoMa("DOHOT_01");
            Assert.IsNotNull(doHot);
        }

        [TestMethod()]
        public void TaoDoHotPhimTest()
        {
            bool result = doHotPhimDAO.TaoDoHotPhim("Cơn sốt mùa hè 2018", 100000);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CapNhatDoHotPhimTest()
        {
            bool result = doHotPhimDAO.CapNhatDoHotPhim("aaaa", "Cơn sốt mùa hè 2018", 100000);
            Assert.IsFalse(result);

            result = doHotPhimDAO.CapNhatDoHotPhim("DOHOT_01", "Cơn sốt mùa hè 2018", 50000);
            Assert.IsTrue(result);

            result = doHotPhimDAO.CapNhatDoHotPhim("DOHOT_01", "Cơn sốt mùa hè 2018 siêu nóng", null);
            Assert.IsTrue(result);
            DOHOTPHIM doHot = doHotPhimDAO.LayDoHotPhimTheoMa("DOHOT_01");
            Assert.IsNotNull(doHot);
            Assert.AreEqual("Cơn sốt mùa hè 2018 siêu nóng", doHot.TenDoHot);
            Assert.AreEqual(50000, doHot.TienPhuThem);
        }
    }
}