using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class UngVienDTO
    {
        private int maUT;
        private string trangThai;
        private DateTime ngayUngTuyen;
        private int maUngVien;
        private string tenViTri;
        private string hoTen;
        private string email;
        private string dienThoai;
        private string duongDanCV;

        public UngVienDTO() { }
        public UngVienDTO(int maUngVien, int maUT, string tenViTri, string hoTen, string email, string dienThoai, string duongDanCV,  DateTime ngayUngTuyen, string trangThai)
        {
            MaUngVien = maUngVien;
            MaUT = maUT;
            TenViTri = tenViTri;
            HoTen = hoTen;
            Email = email;
            DienThoai = dienThoai;
            DuongDanCV = duongDanCV;
            NgayUngTuyen = ngayUngTuyen;
            TrangThai = trangThai;
        }

        public int MaUngVien { get => maUngVien; set => maUngVien = value; }
        public int MaUT { get => maUT; set => maUT = value; }
        public string TenViTri { get => tenViTri; set => tenViTri = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Email { get => email; set => email = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DuongDanCV { get => duongDanCV; set => duongDanCV = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayUngTuyen { get => ngayUngTuyen; set => ngayUngTuyen = value; }
    }
}
