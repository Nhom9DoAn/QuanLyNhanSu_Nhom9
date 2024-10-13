using KimPhuong.DAL;
using KimPhuong.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.BUL
{
    public class BUS_ChucVu
    {
        DAO_ChucVu chucvuDAO;
        public BUS_ChucVu()
        {
            chucvuDAO = new DAO_ChucVu();
        }
        public List<DTO_ChucVu> getAll()
        {
            return chucvuDAO.getAll();
        }
    }
}
