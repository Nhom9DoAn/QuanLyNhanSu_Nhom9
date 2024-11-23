using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DAL
{
    public class HocVanBangCapDAO
    {
        private dbQuanLyNhanSuDataContext db;

        public HocVanBangCapDAO()
        {
            db = new dbQuanLyNhanSuDataContext();
        }

        public List<HocVanBangCap> GetAll()
        {
            try
            {
                return db.HocVanBangCaps.ToList();
            }
            catch
            {
                return new List<HocVanBangCap>();
            }
        }
        public bool Insert(int maNV, string tenTruong, string chuyenNganh, 
            string bangCap, int namTotNghiep, double diemTB, string ghiChu)
        {
            try
            {
                HocVanBangCap hv = new HocVanBangCap
                {
                    MaNV = maNV,
                    TenTruong = tenTruong,
                    ChuyenNganh = chuyenNganh,
                    BangCap = bangCap,
                    NamTotNghiep = namTotNghiep,
                    DiemTB = diemTB,
                    GhiChu = ghiChu
                };

                db.HocVanBangCaps.InsertOnSubmit(hv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int maHVBC, string tenTruong, string chuyenNganh,
            string bangCap, int namTotNghiep, double diemTB, string ghiChu)
        {
            try
            {
                var hv = db.HocVanBangCaps.FirstOrDefault(x => x.MaHVBC == maHVBC);
                if (hv != null)
                {
                    hv.TenTruong = tenTruong;
                    hv.ChuyenNganh = chuyenNganh;
                    hv.BangCap = bangCap;
                    hv.NamTotNghiep = namTotNghiep;
                    hv.DiemTB = diemTB;
                    hv.GhiChu = ghiChu;

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int maHVBC)
        {
            try
            {
                var hv = db.HocVanBangCaps.FirstOrDefault(x => x.MaHVBC == maHVBC);
                if (hv != null)
                {
                    db.HocVanBangCaps.DeleteOnSubmit(hv);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public List<HocVanBangCap> Search(int? maNV, string tenTruong, string bangCap)
        {
            try
            {
                var query = db.HocVanBangCaps.AsQueryable();

                if (maNV.HasValue && maNV.Value > 0)
                {
                    query = query.Where(hv => hv.MaNV == maNV.Value);
                }

                if (!string.IsNullOrEmpty(tenTruong))
                {
                    query = query.Where(hv => hv.TenTruong.Contains(tenTruong));
                }

                if (!string.IsNullOrEmpty(bangCap))
                {
                    query = query.Where(hv => hv.BangCap == bangCap);
                }

                return query.ToList();
            }
            catch
            {
                return new List<HocVanBangCap>();
            }
        }
        public List<HocVanBangCap> GetByNhanVien(int maNV)
        {
            try
            {
                return db.HocVanBangCaps.Where(hv => hv.MaNV == maNV).ToList();
            }
            catch
            {
                return new List<HocVanBangCap>();
            }
        }
    }
}
