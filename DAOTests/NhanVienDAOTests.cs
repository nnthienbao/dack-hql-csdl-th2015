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
    public class NhanVienDAOTests
    {
        [TestMethod()]
        public void LayNhanVienTheoMaTest()
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            NHANVIEN nhanVien = nvDAO.LayNhanVienTheoMa("AFFFDF");
            Assert.IsNull(nhanVien);

            nhanVien = nvDAO.LayNhanVienTheoMa("NV0001");
            Assert.IsNotNull(nhanVien);
        }
    }
}