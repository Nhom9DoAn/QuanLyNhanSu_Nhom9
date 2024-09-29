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
        //public List<NghiPhepDTO> filter(string maNV, bool chuaDuyet, bool daDuyet)
        //{
        //    List<NghiPhepDTO> allnghiPhep = nghiPhepDAO.getAll();
        //    List<NghiPhepDTO> filternghiPhep = allnghiPhep
        //        .Where(
        //        emp => (maNV == "" || emp.MaNV == maNV) && ((chuaDuyet && emp.TinhTrang == "Chưa duyệt") || (daDuyet && emp.TinhTrang == "Đã duyệt"))
        //        )
        //        .ToList();
        //    return filternghiPhep;
        //}
        public List<NghiPhepDTO> searchMaNP(string keyMa)
        {
            List<NghiPhepDTO> ketQua = new List<NghiPhepDTO>();
            foreach (NghiPhepDTO nghiPhep in getAll())
            {
                if (nghiPhep.MaNP.ToLower().Contains(keyMa.ToLower()))
                {
                    ketQua.Add(nghiPhep);
                }
            }
            return ketQua;
        }
        public List<NghiPhepDTO> TimNghiPhepTheoNgay(DateTime ngayBatDau)
        {
            return nghiPhepDAO.TimNghiPhepTheoNgay(ngayBatDau);
        }
    }
}
