using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public dynamic ThongKeTheoBangCap()
        {
            
            var result = db.HocVanBangCaps
                .GroupBy(hv => hv.BangCap) 
                .Select(g => new
                {
                    BangCap = g.Key,
                    SoLuong = g.Count()
                })
                .ToList();

            return result;
        }


        public List<dynamic> GetAll()
        {
            try
            {
                var result = db.HocVanBangCaps.Select(x => new
                {
                    x.MaHVBC,
                    x.MaNV,
                    TenNhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == x.MaNV).HoTen,
                    x.TenTruong,
                    x.ChuyenNganh,
                    x.BangCap,
                    x.NamTotNghiep,
                    x.DiemTB,
                    x.HinhThucHoc,
                    x.GhiChu
                }).ToList();
                return result.Cast<dynamic>().ToList();
            }
            catch
            {
                return new List<dynamic>();
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

        public List<dynamic> Search(string keyword)
        {
            try
            {
                var query = db.HocVanBangCaps.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(hv =>
                        hv.TenTruong.Contains(keyword) ||
                        hv.BangCap.Contains(keyword) ||
                        hv.ChuyenNganh.Contains(keyword) ||
                        hv.NhanVien.HoTen.Contains(keyword) ||
                        hv.HinhThucHoc.Contains(keyword)
                    );
                }

                var result = query.Select(hv => new
                {
                    hv.MaHVBC,
                    hv.MaNV,
                    TenNhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == hv.MaNV).HoTen,
                    hv.TenTruong,
                    hv.ChuyenNganh,
                    hv.BangCap,
                    hv.NamTotNghiep,
                    hv.DiemTB,
                    hv.GhiChu

                }).ToList();

                return result.Cast<dynamic>().ToList();
            }
            catch
            {
                return new List<dynamic>();
            }
        }




        public List<dynamic> GetByNhanVien(int maNV)
        {
            try
            {
                var result = db.HocVanBangCaps.Where(hv => hv.MaNV == maNV).Select(hv => new
                {
                    hv.MaHVBC,
                    hv.MaNV,
                    TenNhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == hv.MaNV).HoTen,
                    hv.TenTruong,
                    hv.ChuyenNganh,
                    hv.BangCap,
                    hv.NamTotNghiep,
                    hv.DiemTB,
                    hv.GhiChu

                }).ToList();
                return result.Cast<dynamic>().ToList();
            }
            catch
            {
                return new List<dynamic>();
            }
        }
    }
}
