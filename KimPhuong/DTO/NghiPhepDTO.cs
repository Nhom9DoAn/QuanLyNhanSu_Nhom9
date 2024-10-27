using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class NghiPhepDTO
    {
        string manp;
        string manv;
        DateTime ngaybatdau;
        DateTime ngayketthuc;
        string lydo;
        string trangthai;
        public string MaNghiPhep
        {
            get { return manp; }
            set { manp = value; }
        }
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        public DateTime NgayBatDau
        {
            get { return ngaybatdau; }
            set { ngaybatdau = value; }
        }
        public DateTime NgayKetThuc
        {
            get { return ngayketthuc; }
            set { ngayketthuc = value; }
        }
        public string LyDo
        {
            get { return lydo; }
            set { lydo = value; }
        }
        public string TrangThai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        public NghiPhepDTO()
        {

        }
        public NghiPhepDTO(string maNP, string maNV, DateTime ngayBatDau, DateTime ngayKetThuc, string lyDo, string trangThai)
        {
            MaNghiPhep = maNP;
            MaNV = maNV;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            LyDo = lyDo;
            TrangThai = trangThai;
        }
    }
}
