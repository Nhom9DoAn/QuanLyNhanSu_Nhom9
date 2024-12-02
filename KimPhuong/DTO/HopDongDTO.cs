using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class HopDongDTO
    {
        private int maNV;
        private string tinhTrang;
        private DateTime ngayBatDau, ngayKetThuc;
        private int maHD;
        private string loaiHD;
        private string bieuMau;
        private string hoTen;

        public HopDongDTO() { }

        public HopDongDTO(int maHD, int maNV, string hoTen, string loaiHD, DateTime ngayBatDau, DateTime ngayKetThuc, string bieuMau, string tinhTrang)
        {
            MaHD = maHD;
            MaNV = maNV;
            HoTen = hoTen;
            LoaiHD = loaiHD;
            BieuMau = bieuMau;
            TinhTrang = tinhTrang;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public string LoaiHD { get => loaiHD; set => loaiHD = value; }
        public string BieuMau { get => bieuMau; set => bieuMau = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }

}
