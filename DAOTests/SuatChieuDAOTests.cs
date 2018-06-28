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
    public class SuatChieuDAOTests
    {
        SuatChieuDAO suatChieuDAO = new SuatChieuDAO();
        [TestMethod()]
        public void LayDSSuatChieuTest()
        {
            var dsSuatChieu = suatChieuDAO.LayDSSuatChieu();
            Assert.IsNotNull(dsSuatChieu);
            Debug.WriteLine(dsSuatChieu.Count);
        }

        [TestMethod()]
        public void LaySuatChieuTheoMaTest()
        {
            var suatChieu = suatChieuDAO.LaySuatChieuTheoMa("AAA");
            Assert.IsNull(suatChieu);

            suatChieu = suatChieuDAO.LaySuatChieuTheoMa("SUATCHIEU_0004");
            Assert.IsNotNull(suatChieu);
        }

        [TestMethod()]
        public void TaoSuatChieuTest()
        {
            var dsThietBi = new List<CT_THIETBI>();
            dsThietBi.Add(new CT_THIETBI { MaThietBi=1 });
            bool result = suatChieuDAO.TaoSuatChieu(DateTime.Now, 
                                                    new TimeSpan(6, 0, 0), 
                                                    new TimeSpan(8, 0, 0), 
                                                    3, 
                                                    2, 
                                                    dsThietBi);
            Assert.IsTrue(result);

            // Test voi thiet bi sai
            dsThietBi.Add(new CT_THIETBI { MaThietBi = 2 });
            result = suatChieuDAO.TaoSuatChieu(DateTime.Now,
                                                new TimeSpan(6, 0, 0),
                                                new TimeSpan(8, 0, 0),
                                                3,
                                                2,
                                                dsThietBi);
            Assert.IsFalse(result);

            // Test voi ma phong sai
            dsThietBi.Clear();
            dsThietBi.Add(new CT_THIETBI { MaThietBi = 1 });
            result = suatChieuDAO.TaoSuatChieu(DateTime.Now,
                                                new TimeSpan(6, 0, 0),
                                                new TimeSpan(8, 0, 0),
                                                3,
                                                100,
                                                dsThietBi);
            Assert.IsFalse(result);

            // Test voi ma phim sai
            dsThietBi.Clear();
            dsThietBi.Add(new CT_THIETBI { MaThietBi = 1 });
            result = suatChieuDAO.TaoSuatChieu(DateTime.Now,
                                                new TimeSpan(6, 0, 0),
                                                new TimeSpan(8, 0, 0),
                                                500,
                                                2,
                                                dsThietBi);

            // Test voi danh sach thiet bi null
            result = suatChieuDAO.TaoSuatChieu(DateTime.Now,
                                                new TimeSpan(6, 0, 0),
                                                new TimeSpan(8, 0, 0),
                                                3,
                                                2,
                                                null);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CapNhatSuatChieuTest()
        {
            var dsThietBi = new List<CT_THIETBI>();
            // Test voi ma suat chieu sai
            bool result = suatChieuDAO.CapNhatSuatChieu("aaa", null, null, null, null, null, dsThietBi);
            Assert.IsFalse(result);

            // Test voi danh sach thiet bi null
            result = suatChieuDAO.CapNhatSuatChieu("SUATCHIEU_0004", null, null, null, null, null, null);
            Assert.IsFalse(result);

            // Test voi du lieu dung
            result = suatChieuDAO.CapNhatSuatChieu("SUATCHIEU_0004", null, null, null, 5, null, dsThietBi);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void TraCuuSuatChieuTest()
        {
            var dsSuatChieu = suatChieuDAO.TraCuuSuatChieu(DateTime.Now, null, null, null, null, null);
            Assert.IsNotNull(dsSuatChieu);
            Debug.WriteLine(dsSuatChieu.Count);

            dsSuatChieu = suatChieuDAO.TraCuuSuatChieu(DateTime.Now, null, null, null, null, 100);
            Assert.IsNotNull(dsSuatChieu);
            Debug.WriteLine(dsSuatChieu.Count);
        }
    }
}