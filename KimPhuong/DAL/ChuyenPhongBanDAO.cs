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
                    cp.NguoiTao,
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
        public bool Insert(int maNV, int maPBCu, int maPBMoi, DateTime ngayHieuLuc, string nguoiTao, string lyDoChuyen, string trangThai, DateTime ngaycapnhat, string nguoiduyet, string ghichu)
        {
            try
            {
                ChuyenPhongBan cpb = new ChuyenPhongBan
                {
                    MaNV = maNV,
                    MaPB_Cu = maPBCu,
                    MaPB_Moi = maPBMoi,
                    NgayHieuLuc = ngayHieuLuc,
                    NgayTao = DateTime.Now,
                    NguoiTao = nguoiTao,
                    LyDoChuyen = lyDoChuyen,
                    TrangThai = trangThai,
                    NgayCapNhatTrangThai = ngaycapnhat,
                    NguoiDuyet = nguoiduyet,
                    GhiChuDuyet = ghichu
                };

                db.ChuyenPhongBans.InsertOnSubmit(cpb);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int maChuyenPB)
        {
            try
            {
                var cpb = db.ChuyenPhongBans.FirstOrDefault(x => x.MaChuyenPB == maChuyenPB);
                if (cpb != null)
                {
                    db.ChuyenPhongBans.DeleteOnSubmit(cpb);
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
        public bool Update(int maChuyenPB, DateTime ngayHieuLuc, string trangThai, string nguoiDuyet, string ghiChuDuyet)
        {
            try
            {
                var cpb = db.ChuyenPhongBans.FirstOrDefault(x => x.MaChuyenPB == maChuyenPB);
                if (cpb != null)
                {
                    cpb.NgayHieuLuc = ngayHieuLuc;
                    cpb.TrangThai = trangThai;
                    cpb.NgayCapNhatTrangThai = DateTime.Now;
                    cpb.NguoiDuyet = nguoiDuyet;
                    cpb.GhiChuDuyet = ghiChuDuyet;

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
        public bool updatePhongBan(int maNV, int maPBMoi)
        {
            try
            {
                var nhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == maNV);
                if (nhanVien != null)
                {
                    nhanVien.MaPB = maPBMoi;
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

        public List<dynamic> GetByNhanVien(int maNV)
        {
            try
            {
                var result = db.ChuyenPhongBans
                    .Where(cp => cp.MaNV == maNV)
                    .Select(cp => new
                    {
                        cp.MaChuyenPB,
                        cp.MaNV,
                        TenNhanVien = cp.NhanVien.HoTen,
                        cp.MaPB_Cu,
                        TenPhongBanCu = cp.PhongBan.TenPB,
                        cp.MaPB_Moi,
                        TenPhongBanMoi = cp.PhongBan.TenPB,
                        cp.NgayHieuLuc,
                        cp.NgayTao,
                        cp.NguoiTao,
                        cp.LyDoChuyen,
                        cp.TrangThai,
                        cp.NgayCapNhatTrangThai,
                        cp.NguoiDuyet,
                        cp.GhiChuDuyet
                    })
                    .ToList();

                return result.Cast<dynamic>().ToList();
            }
            catch
            {
                return new List<dynamic>();
            }
        }
        public List<dynamic> Search(string keyword)
        {
            try
            {
                var query = db.ChuyenPhongBans.AsQueryable();
                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(cp =>
                        cp.NhanVien.HoTen.Contains(keyword) ||
                        cp.PhongBan.TenPB.Contains(keyword) ||
                        cp.LyDoChuyen.Contains(keyword) ||
                        cp.NguoiTao.Contains(keyword) ||
                        cp.TrangThai.Contains(keyword)
                    );
                }

                var result = query.Select(cp => new
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
                    cp.NguoiTao,
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
