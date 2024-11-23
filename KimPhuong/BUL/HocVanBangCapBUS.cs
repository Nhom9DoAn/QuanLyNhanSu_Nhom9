using KimPhuong.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.BUL
{
    public class HocVanBangCapBUS
    {
        HocVanBangCapDAO hocVan;
        public HocVanBangCapBUS()
        {
            hocVan = new HocVanBangCapDAO();
        }
        public List<HocVanBangCap> GetAll()
        {
            return hocVan.GetAll();
        }
        public bool Delete(int maHVBC)
        {
            return hocVan.Delete(maHVBC);
        }
        public bool Insert(int maNV, string tenTruong, string chuyenNganh,
            string bangCap, int namTotNghiep, double diemTB, string ghiChu)
        {
            return hocVan.Insert(maNV, tenTruong, chuyenNganh, bangCap, namTotNghiep, diemTB, ghiChu);
        }
        public bool Update(int maHVBC, string tenTruong, string chuyenNganh,
            string bangCap, int namTotNghiep, double diemTB, string ghiChu)
        {
            return hocVan.Update(maHVBC, tenTruong,chuyenNganh, bangCap,namTotNghiep,diemTB, ghiChu);
        }
        public List<HocVanBangCap> Search(int? maNV, string tenTruong, string bangCap)
        {
            return hocVan.Search(maNV, tenTruong, bangCap);
        }
        public List<HocVanBangCap> GetByNhanVien(int maNV)
        {
            return hocVan.GetByNhanVien(maNV);
        }
    }
}
