using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class ThuongPhatDTO
    {
        private int maTP, maNV;
        private DateTime ngay;
        private string loai;
        private int soTien;
        private string lyDo, trangThai, hoTen;

        public int MaTP { get => maTP; set => maTP = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string Loai { get => loai; set => loai = value; }
        public int SoTien { get => soTien; set => soTien = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }

        public ThuongPhatDTO() { }
        public ThuongPhatDTO(int maTP, int maNV, string hoTen, DateTime ngay, string loai, int soTien, string lyDo, string trangThai)
        {
            MaTP = maTP;
            MaNV = maNV;
            HoTen = hoTen;
            Ngay = ngay;
            Loai = loai;
            SoTien = soTien;
            LyDo = lyDo;
            TrangThai = trangThai;
        }
    }
}
