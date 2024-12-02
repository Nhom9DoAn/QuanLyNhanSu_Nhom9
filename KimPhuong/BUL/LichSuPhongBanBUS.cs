using KimPhuong.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.BUL
{
    public class LichSuPhongBanBUS
    {
        LichSuPhongBanDAO lichSuPhongBanDAO;
        public LichSuPhongBanBUS()
        {
            lichSuPhongBanDAO = new LichSuPhongBanDAO();
        }

        public List<dynamic> GetLichSuByNhanVien(int maNV)
        {
            return lichSuPhongBanDAO.GetLichSuByNhanVien(maNV);
        }
        public List<dynamic> GetAll()
        {
            return lichSuPhongBanDAO.GetAll();
        }
        public string GetTenPhongBan(int maPhongBan)
        {
            return lichSuPhongBanDAO.GetTenPhongBan(maPhongBan);
        }
        public List<dynamic> Search(string keyword)
        {
            return lichSuPhongBanDAO.Search(keyword);
        }
    }
}
