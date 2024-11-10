using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class DTO_NhanVien
    {
        int manv;
        string mapb;
        string macv;
        string hoten;
        DateTime ngaysinh;
        string gioitinh;
        string cccd;
        string email;
        string dienthoai;
        string diachi;
        DateTime ngayvaolam;
        int luongcb;
        string trangthai;
        string soyeulylich;
        Image hinh;
        string tinhtranghonnhan;
        string manguoiquanly;

        public int Manv { get => manv; set => manv = value; }
        public string Mapb { get => mapb; set => mapb = value; }
        public string Macv { get => macv; set => macv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Email { get => email; set => email = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
        public int Luongcb { get => luongcb; set => luongcb = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Soyeulylich { get => soyeulylich; set => soyeulylich = value; }
        public Image Hinh { get => hinh; set => hinh = value; }
        public string Tinhtranghonnhan { get => tinhtranghonnhan; set => tinhtranghonnhan = value; }
        public string Manguoiquanly { get => manguoiquanly; set => manguoiquanly = value; }

        public DTO_NhanVien()
        {
            
        }
        public DTO_NhanVien(
            int manv,
            string mapb,
            string macv,
            string hoten,
            DateTime ngaysinh,
            string gioitinh,
            string cccd,
            string email,
            string dienthoai,
            string diachi,
            DateTime ngayvaolam,
            int luongcb,
            string trangthai,
            string soyeulylich,
            Image hinh,
            string tinhtranghonnhan,
            string manguoiquanly)
        {
            this.manv = manv;
            this.mapb = mapb;
            this.macv = macv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.cccd = cccd;
            this.email = email;
            this.dienthoai = dienthoai;
            this.diachi = diachi;
            this.ngayvaolam = ngayvaolam;
            this.luongcb = luongcb;
            this.trangthai = trangthai;
            this.soyeulylich = soyeulylich;
            this.hinh = hinh;
            this.tinhtranghonnhan = tinhtranghonnhan;
            this.manguoiquanly = manguoiquanly;
        }
    }
}
