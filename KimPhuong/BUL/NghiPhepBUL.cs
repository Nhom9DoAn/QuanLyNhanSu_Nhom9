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
        public List<NghiPhep> GetAll()
        {
            return nghiPhepDAO.GetAll();
        }

        // Thêm mới nghỉ phép
        public bool Insert(int maNV, DateTime ngayBatDau, DateTime ngayKetThuc,
                           string lyDo, string trangThai)
        {
            return nghiPhepDAO.Insert(maNV, ngayBatDau, ngayKetThuc, lyDo, trangThai);
        }

        // Cập nhật thông tin nghỉ phép
        public bool Update(int maNghiPhep, DateTime ngayBatDau, DateTime ngayKetThuc,
                           string lyDo, string trangThai)
        {
            return nghiPhepDAO.Update(maNghiPhep, ngayBatDau, ngayKetThuc, lyDo, trangThai);
        }

        // Xóa thông tin nghỉ phép
        public bool Delete(int maNghiPhep)
        {
            return nghiPhepDAO.Delete(maNghiPhep);
        }

        // Lấy thông tin nghỉ phép theo mã nghỉ phép
        public NghiPhep GetByID(int maNghiPhep)
        {
            return nghiPhepDAO.GetByID(maNghiPhep);
        }

        // Lấy danh sách nghỉ phép của nhân viên theo mã nhân viên
        public List<NghiPhep> GetByNhanVien(int maNV)
        {
            return nghiPhepDAO.GetByNhanVien(maNV);
        }

        // Tìm kiếm nghỉ phép theo nhiều tiêu chí
        public List<NghiPhep> Search(int maNV, DateTime tuNgay, DateTime denNgay, string trangThai)
        {
            return nghiPhepDAO.Search(maNV, tuNgay, denNgay, trangThai);
        }

        // Tính tổng số ngày nghỉ phép của nhân viên trong khoảng thời gian cụ thể
        public int GetTongNgayNghi(int maNV, DateTime tuNgay, DateTime denNgay)
        {
            return nghiPhepDAO.GetTongNgayNghi(maNV, tuNgay, denNgay);
        }
    }
}
