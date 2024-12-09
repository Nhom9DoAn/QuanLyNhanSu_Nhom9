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
        public List<PhongBan> getAll()
        {
            return phongBanDAO.getAll();
        }
        public dynamic ThongKeGioiTinhTheoPhong(int maPhongBan)
        {
            return phongBanDAO.ThongKeGioiTinhTheoPhong(maPhongBan);
        }
        public bool insert(string tenPB, string diaChi, string sdtPB)
        {
            return phongBanDAO.insert(tenPB, diaChi, sdtPB);
        }
        public bool delete(int maPB)
        {
            return phongBanDAO.delete(maPB);
        }
        public bool update(int maPB, string tenPB, string diaChi, string sdtPB)
        {
            return phongBanDAO.update(maPB, tenPB, diaChi, sdtPB);
        }
        public List<PhongBan> searchPhongBan(string keyword)
        {
            return phongBanDAO.SearchPhongBan(keyword);
        }
    }
}
