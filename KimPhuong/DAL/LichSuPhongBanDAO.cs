using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DAL
{
    public class LichSuPhongBanDAO
    {
        private dbQuanLyNhanSuDataContext db;
        public LichSuPhongBanDAO()
        {
            db = new dbQuanLyNhanSuDataContext();
        }

        public List<dynamic> GetLichSuByNhanVien(int maNV)
        {
            try
            {
                var result = db.LichSuPhongBans
                    .Where(x => x.MaNV == maNV)
                    .OrderByDescending(x => x.NgayChuyen)
                    .Select(x => new
                    {
                        x.MaLichSu,
                        x.MaNV,
                        TenNhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == x.MaNV).HoTen,
                        x.MaPB,
                        TenPhongBan = db.PhongBans.FirstOrDefault(p => p.MaPB == x.MaPB).TenPB,
                        x.NgayChuyen,
                        x.GhiChu
                    })
                    .ToList();

                return result.Cast<dynamic>().ToList();
            }
            catch
            {
                return new List<dynamic>();
            }
        }


        public List<dynamic> GetAll()
        {
            try
            {
                var result = db.LichSuPhongBans.Select(x => new
                {
                    x.MaLichSu,
                    x.MaNV,
                    TenNhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == x.MaNV).HoTen,
                    x.MaPB,
                    TenPhongBan = db.PhongBans.FirstOrDefault(p => p.MaPB == x.MaPB).TenPB,
                    x.NgayChuyen,
                    x.GhiChu
                }).ToList();

                return result.Cast<dynamic>().ToList();
            }
            catch
            {
                return new List<dynamic>();
            }
        }


        public string GetTenPhongBan(int maPhongBan)
        {
            var phongBan = db.PhongBans.FirstOrDefault(x => x.MaPB == maPhongBan);
            return phongBan != null ? phongBan.TenPB : "";
        }

        public List<dynamic> Search(string keyword)
        {
            try
            {
                var query = db.LichSuPhongBans.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(x =>
                        x.MaLichSu.ToString().Contains(keyword) ||
                        x.MaNV.ToString().Contains(keyword) ||
                        x.MaPB.ToString().Contains(keyword) ||
                        x.GhiChu.Contains(keyword) ||
                        x.NgayChuyen.ToString().Contains(keyword) ||
                        db.PhongBans.FirstOrDefault(p => p.MaPB == x.MaPB).TenPB.Contains(keyword) || 
                        db.NhanViens.FirstOrDefault(nv => nv.MaNV == x.MaNV).HoTen.Contains(keyword) 
                    );
                }

                var result = query.Select(x => new
                {
                    x.MaLichSu,
                    x.MaNV,
                    TenNhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == x.MaNV).HoTen,
                    x.MaPB,
                    TenPhongBan = db.PhongBans.FirstOrDefault(p => p.MaPB == x.MaPB).TenPB,
                    x.NgayChuyen,
                    x.GhiChu
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
