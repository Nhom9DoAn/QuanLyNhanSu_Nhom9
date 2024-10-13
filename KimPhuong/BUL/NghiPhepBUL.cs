using KimPhuong.DAL;
using KimPhuong.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.BUL
{
    public class NghiPhepBUL
    {
        NghiPhepDAO nghiPhepDAO;
        public NghiPhepBUL()
        {
            nghiPhepDAO = new NghiPhepDAO();
        }
        public List<NghiPhepDTO> getAll()
        {
            return nghiPhepDAO.getAll();
        }
        public bool KiemTraTrungMa(string maNP)
        {
            return nghiPhepDAO.KiemTraTrungMa(maNP);
        }
        public string LayTenNhanVienTuMa(string maNV)
        {
            return nghiPhepDAO.LayTenNhanVienTheoMa(maNV);
        }
        public string LayNgaySinhNhanVienTuMa(string maNV)
        {
            return nghiPhepDAO.LayNgaySinhNhanVienTheoMa(maNV);
        }
        public string LaySDTNhanVienTuMa(string maNV)
        {
            return nghiPhepDAO.LaySDTNhanVienTheoMa(maNV);
        }
        public string LayTenCV(string maNV)
        {
            return nghiPhepDAO.LayTenChucVu(maNV);
        }
        public bool delete(NghiPhepDTO nghiPhep)
        {
            return nghiPhepDAO.delete(nghiPhep);
        }
        public bool insert(NghiPhepDTO nghiPhep)
        {
            return nghiPhepDAO.insert(nghiPhep);
        }
        public bool update(NghiPhepDTO nghiPhep)
        {
            return nghiPhepDAO.update(nghiPhep);
        }
        public List<NghiPhepDTO> searchLinq(string maNV)
        {
            return nghiPhepDAO.searchLinq(maNV);
        }
    }
}
