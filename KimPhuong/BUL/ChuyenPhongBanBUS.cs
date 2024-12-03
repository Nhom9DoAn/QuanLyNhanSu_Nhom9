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
        public List<dynamic> GetAll()
        {
            return chuyenPhongBanDAO.GetAll();
        }
        public bool Delete(int maChuyenPB)
        {
            return chuyenPhongBanDAO.Delete(maChuyenPB);
        }
        public bool Insert(int maNV, int maPBCu, int maPBMoi, DateTime ngayHieuLuc, int nguoiTao, string lyDoChuyen, string trangThai, DateTime ngaycapnhat, string nguoiduyet, string ghichu)
        {
            return chuyenPhongBanDAO.Insert(maNV, maPBCu, maPBMoi, ngayHieuLuc, nguoiTao, lyDoChuyen, trangThai, ngaycapnhat, nguoiduyet, ghichu);
        }
        public bool Update(int maChuyenPB, DateTime ngayHieuLuc, string trangThai, string nguoiDuyet, string ghiChuDuyet)
        {
            return chuyenPhongBanDAO.Update(maChuyenPB, ngayHieuLuc, trangThai, nguoiDuyet, ghiChuDuyet);
        }
        public List<dynamic> GetByNhanVien(int maNV)
        {
            return chuyenPhongBanDAO.GetByNhanVien(maNV);
        }
        public bool updatePhongBan(int maNV, int maPBMoi)
        {
            return chuyenPhongBanDAO.updatePhongBan(maNV, maPBMoi);
        }
        public List<dynamic> Search(string keyword)
        {
            return chuyenPhongBanDAO.Search(keyword);
        }
    }
}
