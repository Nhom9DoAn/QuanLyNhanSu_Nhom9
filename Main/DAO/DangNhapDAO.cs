using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DAO
{
    public class DangNhapDAO
    {
        private dbDangNhapDataContext dbDangNhapDataContext;
        public DangNhapDAO()
        {
            dbDangNhapDataContext = new dbDangNhapDataContext();
        }
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            using (var db = new dbDangNhapDataContext())
            {
                var taiKhoan = db.TaiKhoans
                    .Where(tk => tk.TenDangNhap == tenDangNhap && tk.MatKhau == matKhau)
                    .FirstOrDefault();

                return taiKhoan != null;
            }
        }

        public string LayTenNhanVien(int maNV)
        {
            using (var db = new dbDangNhapDataContext())
            {
                var nhanVien = db.NhanViens
                    .Where(nv => nv.MaNV == maNV)
                    .FirstOrDefault();

                return nhanVien?.HoTen;
            }
        }

        public string LayChucVu(int maNV)
        {
            using (var db = new dbDangNhapDataContext())
            {
                var nhanVien = db.NhanViens
                    .Where(nv => nv.MaNV == maNV)
                    .FirstOrDefault();

                var chucVu = db.ChucVus
                    .Where(cv => cv.MaCV == nhanVien.MaCV)
                    .FirstOrDefault();

                return chucVu?.TenCV;
            }
        }
        public int LayMaNV(string tenDangNhap)
        {
            using (var db = new dbDangNhapDataContext())
            {
                var taiKhoan = db.TaiKhoans
                    .Where(tk => tk.TenDangNhap == tenDangNhap)
                    .FirstOrDefault();

                return taiKhoan?.MaNV ?? 0;
            }
        }

    }
}
