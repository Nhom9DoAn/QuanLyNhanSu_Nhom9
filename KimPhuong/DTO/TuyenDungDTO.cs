using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class TuyenDungDTO
    {
        private int nguoiPhuTrach;
        private string yeuCau;
        private DateTime ngayKetThuc;
        private int maUT;
        private int maPhong;
        private int soLuong;
        private string tenViTri;
        private string trangThai;
        private DateTime ngayBatDau;
        private string hoTen;
        private string tenPB;


        public int MaUT { get => maUT; set => maUT = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int NguoiPhuTrach { get => nguoiPhuTrach; set => nguoiPhuTrach = value; }
        public string TenViTri { get => tenViTri; set => tenViTri = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string YeuCau { get => yeuCau; set => yeuCau = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string TenPB { get => tenPB; set => tenPB = value; }

        public TuyenDungDTO() { }

        public TuyenDungDTO(int maUT, string tenViTri, int maPhong, string tenPB, int soLuong,  string trangThai,  DateTime ngayBatDau, DateTime ngayKetThuc, string yeuCau, int nguoiPhuTrach, string hoTen)
        {
            MaUT = maUT;
            TenViTri = tenViTri;
            MaPhong = maPhong;
            TenPB = tenPB;
            SoLuong = soLuong;
            TrangThai = trangThai;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            YeuCau = yeuCau;
            NguoiPhuTrach = nguoiPhuTrach;
            HoTen = hoTen;
        }
    }
}
