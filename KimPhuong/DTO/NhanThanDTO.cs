using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class NhanThanDTO
    {
        private int maNV;
        private string dienThoai;
        private DateTime ngaySinh;
        private int maNT;
        private string hoTenNV;
        private string hoTenNT;
        private string quanHe;
        private string diaChi;
        public NhanThanDTO() { }
        public NhanThanDTO(int maNT, int maNV, string hoTenNV, string hoTenNT, string quanHe, DateTime ngaySinh, string dienThoai, string diaChi )
        {
            MaNT = maNT;
            MaNV = maNV;
            HoTenNV = hoTenNV;
            HoTenNT = hoTenNT;
            QuanHe = quanHe;
            NgaySinh = ngaySinh;
            DienThoai = dienThoai;
            DiaChi = diaChi; 
        }

        public int MaNT { get => maNT; set => maNT = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string HoTenNT { get => hoTenNT; set => hoTenNT = value; }
        public string QuanHe { get => quanHe; set => quanHe = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
