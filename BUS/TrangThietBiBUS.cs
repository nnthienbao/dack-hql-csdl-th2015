using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class TrangThietBiBUS
    {
        private TrangThietBiDAO trangThietBiDAO = new TrangThietBiDAO();
        public List<TRANGTHIETBI> LayDSTrangThietBi()
        {
            return trangThietBiDAO.LayDSTrangThietBi();
        }
    }
}
