using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class CongTacDTO
    {
        private int maNV;
        private string hoTen;
        private DateTime ngayKetThuc;
        private string trangThai;
        private int maCT;
        private DateTime ngayBatDau;
        private string diaDiem;
        private string mucDich;
        private string bieuMau;

        public int MaCT { get => maCT; set => maCT = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public string MucDich { get => mucDich; set => mucDich = value; }
        public string BieuMau { get => bieuMau; set => bieuMau = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }

        public CongTacDTO() {}
        public CongTacDTO(int maCT, int maNV, string hoTen, DateTime ngayBatDau, DateTime ngayKetThuc, string diaDiem, string mucDich, string bieuMau, string trangThai)
        {
            MaCT = maCT;
            MaNV = maNV;
            HoTen = hoTen;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            DiaDiem = diaDiem;
            MucDich = mucDich;
            BieuMau = bieuMau;
            TrangThai = trangThai;
        }




    }
}
