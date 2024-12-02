using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;
using KimPhuong.DAL;

namespace KimPhuong.BUL
{
    public class UngVienBLL
    {
        UngVienDAL uvdal = new UngVienDAL();
        public List<UngVienDTO> getAllUngVien()
        {
            return uvdal.getAllUngVien();
        }

        // thêm
        public bool AddUngVien(UngVienDTO uv)
        {
            return uvdal.AddUngVien(uv);
        }

        // sửa
        public bool UpdateUngVien(UngVienDTO uv)
        {
            return uvdal.UpdateUngVien(uv);
        }

        // xóa
        public bool DeleteUngVien(int maUngVien)
        {
            return uvdal.DeleteUngVien(maUngVien);
        }
    }
}
