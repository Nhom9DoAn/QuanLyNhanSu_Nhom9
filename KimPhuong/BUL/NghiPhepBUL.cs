using KimPhuong.DAL;
using KimPhuong.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public bool Insert(int maNV, DateTime ngayBatDau, DateTime ngayKetThuc,
                           string lyDo, string trangThai)
        {
            return nghiPhepDAO.Insert(maNV, ngayBatDau, ngayKetThuc, lyDo, trangThai);
        }

        public bool Update(int maNghiPhep, DateTime ngayBatDau, DateTime ngayKetThuc,
                           string lyDo, string trangThai)
        {
            return nghiPhepDAO.Update(maNghiPhep, ngayBatDau, ngayKetThuc, lyDo, trangThai);
        }

        public bool Delete(int maNghiPhep)
        {
            return nghiPhepDAO.Delete(maNghiPhep);
        }

        public NghiPhep GetByID(int maNghiPhep)
        {
            return nghiPhepDAO.GetByID(maNghiPhep);
        }

        public List<NghiPhep> GetByNhanVien(int maNV)
        {
            return nghiPhepDAO.GetByNhanVien(maNV);
        }

        public List<NghiPhep> Search(int maNV, DateTime tuNgay, DateTime denNgay, string trangThai)
        {
            return nghiPhepDAO.Search(maNV, tuNgay, denNgay, trangThai);
        }

        public int GetTongNgayNghi(int maNV, DateTime tuNgay, DateTime denNgay)
        {
            return nghiPhepDAO.GetTongNgayNghi(maNV, tuNgay, denNgay);
        }
        
    }
}
