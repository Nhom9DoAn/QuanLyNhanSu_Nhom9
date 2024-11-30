using KimPhuong.DAL;
using KimPhuong.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO nhanVienDAO;

        public NhanVienBUS()
        {
            nhanVienDAO = new NhanVienDAO();
        }

        public List<NhanVien> GetAll()
        {
            return nhanVienDAO.GetAll();
        }

        public bool Insert(string hoTen, string gioiTinh, DateTime ngaySinh,
            string cccd, string email, string dienThoai, string diaChi,
            DateTime ngayVaoLam, int luongCB, string trangThai, string soYeuLyLich,
            int nguoiQuanLy, byte[] hinh, string tinhTrangHonNhan, string danToc,
            int maPB, int maCV)
        {
            return nhanVienDAO.Insert(hoTen, gioiTinh, ngaySinh, cccd, email,
                dienThoai, diaChi, ngayVaoLam, luongCB, trangThai, soYeuLyLich,
                nguoiQuanLy, hinh, tinhTrangHonNhan, danToc, maPB, maCV);
        }

        public bool Update(int maNV, string hoTen, string gioiTinh, DateTime ngaySinh,
            string cccd, string email, string dienThoai, string diaChi,
            DateTime ngayVaoLam, int luongCB, string trangThai, string soYeuLyLich,
            int nguoiQuanLy, byte[] hinh, string tinhTrangHonNhan, string danToc,
            int maPB, int maCV)
        {
            return nhanVienDAO.Update(maNV, hoTen, gioiTinh, ngaySinh, cccd, email,
                dienThoai, diaChi, ngayVaoLam, luongCB, trangThai, soYeuLyLich,
                nguoiQuanLy, hinh, tinhTrangHonNhan, danToc, maPB, maCV);
        }

        public bool Delete(int maNV)
        {
            return nhanVienDAO.Delete(maNV);
        }

        public List<NhanVien> Search(string keyword, int maPB, int maCV,
            string trangThai, DateTime tuNgay, DateTime denNgay)
        {
            return nhanVienDAO.Search(keyword, maPB, maCV, trangThai, tuNgay, denNgay);
        }

        public NhanVien GetByID(int maNV)
        {
            return nhanVienDAO.GetByID(maNV);
        }

        public List<NhanVien> GetByPhongBan(int maPB)
        {
            return nhanVienDAO.GetByPhongBan(maPB);
        }

        public bool IsEmailExists(string email, int excludeMaNV)
        {
            return nhanVienDAO.IsEmailExists(email, excludeMaNV);
        }

        public bool IsCCCDExists(string cccd, int excludeMaNV)
        {
            return nhanVienDAO.IsCCCDExists(cccd, excludeMaNV);
        }
        public string GetChucVuName(int maNV)
        {
            return nhanVienDAO.GetChucVuName(maNV);
        }
        public string GetPhongBanName(int maNV)
        {
            return nhanVienDAO.GetPhongBanName(maNV);
        }
    }
}