using Main.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.BUS
{
    public class DangNhapBUS
    {
        DangNhapDAO dangNhapDAO;
        public DangNhapBUS()
        {
            dangNhapDAO = new DangNhapDAO();
        }
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            return dangNhapDAO.KiemTraDangNhap(tenDangNhap, matKhau);
        }
        public string LayTenNhanVien(int maNV)
        {
            return dangNhapDAO.LayTenNhanVien(maNV);
        }

        public string LayChucVu(int maNV)
        {
            return dangNhapDAO.LayChucVu(maNV);
        }
        public int LayMaNV(string tenDangNhap)
        {
            return dangNhapDAO.LayMaNV(tenDangNhap);
        }
    }
}
