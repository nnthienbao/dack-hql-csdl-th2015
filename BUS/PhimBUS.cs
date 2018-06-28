using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhimBUS
    {
        private PhimDAO phimDAO = new PhimDAO();
        public List<PHIM> LayDSPhim()
        {
            return phimDAO.LayDSPhim();
        }
    }
}
