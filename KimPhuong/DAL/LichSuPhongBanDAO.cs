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

        public List<LichSuPhongBan> GetLichSuByNhanVien(int maNV)
        {
            return db.LichSuPhongBans.Where(x => x.MaNV == maNV)
                                    .OrderByDescending(x => x.NgayChuyen)
                                    .ToList();
        }
        public List<LichSuPhongBan> GetAll()
        {
            try
            {
                return db.LichSuPhongBans.ToList();
            }
            catch
            {
                return new List<LichSuPhongBan>();
            }
        }
        public string GetTenPhongBan(int maPhongBan)
        {
            var phongBan = db.PhongBans.FirstOrDefault(x => x.MaPB == maPhongBan);
            return phongBan != null ? phongBan.TenPB : "";
        }
    }
}
