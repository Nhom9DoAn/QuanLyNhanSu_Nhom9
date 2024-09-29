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
        DateTime tungay;
        DateTime denngay;
        string lydo;
        string tinhtrang;
        public string MaNP
        {
            get { return manp; }
            set { manp = value; }
        }
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        public DateTime TuNgay
        {
            get { return tungay; }
            set { tungay = value; }
        }
        public DateTime DenNgay
        {
            get { return denngay; }
            set { denngay = value; }
        }
        public string LyDo
        {
            get { return lydo; }
            set { lydo = value; }
        }
        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        public NghiPhepDTO()
        {

        }
        public NghiPhepDTO(string maNP, string maNV, DateTime tuNgay, DateTime denNgay, string lyDo, string tinhTrang)
        {
            MaNP = maNP;
            MaNV = maNV;
            TuNgay = tuNgay;
            DenNgay = denNgay;
            LyDo = lyDo;
            TinhTrang = tinhTrang;
        }
    }
}
