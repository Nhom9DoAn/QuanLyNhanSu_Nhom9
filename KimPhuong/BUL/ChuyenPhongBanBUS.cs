using KimPhuong.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.BUL
{
    public class ChuyenPhongBanBUS
    {
        ChuyenPhongBanDAO chuyenPhongBanDAO;
        public ChuyenPhongBanBUS()
        {
            chuyenPhongBanDAO = new ChuyenPhongBanDAO(); 
        }
        public List<ChuyenPhongBan> GetAll()
        {
            return chuyenPhongBanDAO.GetAll();
        }
    }
}
