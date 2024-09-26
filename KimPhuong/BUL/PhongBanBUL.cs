using KimPhuong.DAL;
using KimPhuong.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.BUL
{
    public class PhongBanBUL
    {
        PhongBanDAO phongBanDAO;
        public PhongBanBUL()
        {
            phongBanDAO = new PhongBanDAO();
        }
        public List<PhongBanDTO> getAll()
        {
            return phongBanDAO.getAll();
        }
    }
}
