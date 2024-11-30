using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DAL
{
    public class ChuyenPhongBanDAO
    {
        dbQuanLyNhanSuDataContext db;
        public ChuyenPhongBanDAO()
        {
            db = new dbQuanLyNhanSuDataContext();
        }
        public List<dynamic> GetAll()
        {
            try
            {
                var result = db.ChuyenPhongBans.Select(cp => new
                {
                    cp.MaChuyenPB,
                    cp.MaNV,
                    TenNhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == cp.MaNV).HoTen,
                    cp.MaPB_Cu,
                    TenPhongBanCu = db.PhongBans.FirstOrDefault(pb => pb.MaPB == cp.MaPB_Cu).TenPB,
                    cp.MaPB_Moi,
                    TenPhongBanMoi = db.PhongBans.FirstOrDefault(pb => pb.MaPB == cp.MaPB_Moi).TenPB,
                    cp.NgayHieuLuc,
                    cp.NgayTao,
                    TenNguoiTao = db.NhanViens.FirstOrDefault(nv => nv.MaNV == cp.NguoiTao).HoTen,
                    cp.LyDoChuyen,
                    cp.TrangThai,
                    cp.NgayCapNhatTrangThai,
                    cp.NguoiDuyet,
                    cp.GhiChuDuyet
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
