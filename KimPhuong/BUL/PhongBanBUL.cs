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
        public bool insert(PhongBanDTO pb)
        {
            return phongBanDAO.insert(pb);
        }
        public bool delete(PhongBanDTO pb)
        {
            return phongBanDAO.delete(pb);
        }
        public bool update(PhongBanDTO pb)
        {
            return phongBanDAO.update(pb);
        }
        public int tinhTongNhanVienTrongPhongBan(string maPB)
        {
            return phongBanDAO.tinhTongNhanVienTrongPhongBan(maPB);

        }
        public List<PhongBanDTO> searchLinq(string maPB, string tenPB)
        {
            return phongBanDAO.searchLinq(maPB, tenPB);
        }
    }
}
