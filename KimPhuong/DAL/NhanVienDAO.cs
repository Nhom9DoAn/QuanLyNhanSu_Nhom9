using System;
using System.Collections.Generic;
using System.Linq;

namespace KimPhuong.DAL
{
    public class NhanVienDAO
    {
        private dbQuanLyNhanSuDataContext db;

        public NhanVienDAO()
        {
            db = new dbQuanLyNhanSuDataContext();
        }

        public List<NhanVien> GetAll()
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    return db.NhanViens.ToList();
                }
            }
            catch
            {
                return new List<NhanVien>();
            }
        }

        public bool Insert(string hoTen, string gioiTinh, DateTime ngaySinh,
            string cccd, string email, string dienThoai, string diaChi,
            DateTime ngayVaoLam, int luongCB, string trangThai, string soYeuLyLich,
            int nguoiQuanLy, byte[] hinh, string tinhTrangHonNhan, string danToc,
            int maPB, int maCV)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    NhanVien nv = new NhanVien
                    {
                        HoTen = hoTen,
                        GioiTinh = gioiTinh,
                        NgaySinh = ngaySinh,
                        CCCD = cccd,
                        Email = email,
                        DienThoai = dienThoai,
                        DiaChi = diaChi,
                        NgayVaoLam = ngayVaoLam,
                        LuongCB = luongCB,
                        TrangThai = trangThai,
                        SoYeuLyLich = soYeuLyLich,
                        NguoiQuanLy = nguoiQuanLy,
                        Hinh = hinh,
                        TinhTrangHonNhan = tinhTrangHonNhan,
                        DanToc = danToc,
                        MaPB = maPB,
                        MaCV = maCV
                    };

                    db.NhanViens.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int maNV, string hoTen, string gioiTinh, DateTime ngaySinh,
            string cccd, string email, string dienThoai, string diaChi,
            DateTime ngayVaoLam, int luongCB, string trangThai, string soYeuLyLich,
            int nguoiQuanLy, byte[] hinh, string tinhTrangHonNhan, string danToc,
            int maPB, int maCV)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
                    if (nv != null)
                    {
                        nv.HoTen = hoTen;
                        nv.GioiTinh = gioiTinh;
                        nv.NgaySinh = ngaySinh;
                        nv.CCCD = cccd;
                        nv.Email = email;
                        nv.DienThoai = dienThoai;
                        nv.DiaChi = diaChi;
                        nv.NgayVaoLam = ngayVaoLam;
                        nv.LuongCB = luongCB;
                        nv.TrangThai = trangThai;
                        nv.SoYeuLyLich = soYeuLyLich;
                        nv.NguoiQuanLy = nguoiQuanLy;
                        nv.Hinh = hinh;
                        nv.TinhTrangHonNhan = tinhTrangHonNhan;
                        nv.DanToc = danToc;
                        nv.MaPB = maPB;
                        nv.MaCV = maCV;

                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        // Xóa nhân viên
        public bool Delete(int maNV)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
                    if (nv != null)
                    {
                        db.NhanViens.DeleteOnSubmit(nv);
                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        // Tìm kiếm nhân viên theo nhiều tiêu chí
        public List<NhanVien> Search(string keyword, int maPB, int maCV,
            string trangThai, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    var query = from nv in db.NhanViens
                                where
                                    (string.IsNullOrEmpty(keyword) ||
                                     nv.HoTen.Contains(keyword) ||
                                     nv.CCCD.Contains(keyword) ||
                                     nv.Email.Contains(keyword) ||
                                     nv.DienThoai.Contains(keyword)) &&
                                    (maPB == 0 || nv.MaPB == maPB) &&
                                    (maCV == 0 || nv.MaCV == maCV) &&
                                    (string.IsNullOrEmpty(trangThai) || nv.TrangThai == trangThai) &&
                                    (tuNgay == DateTime.MinValue || nv.NgayVaoLam >= tuNgay) &&
                                    (denNgay == DateTime.MinValue || nv.NgayVaoLam <= denNgay)
                                select nv;

                    return query.ToList();
                }
            }
            catch
            {
                return new List<NhanVien>();
            }
        }

        // Lấy thông tin nhân viên theo mã
        public NhanVien GetByID(int maNV)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    return db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
                }
            }
            catch
            {
                return null;
            }
        }

        // Kiểm tra email đã tồn tại
        public bool IsEmailExists(string email, int excludeMaNV)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    return db.NhanViens.Any(x => x.Email == email &&
                        (excludeMaNV == 0 || x.MaNV != excludeMaNV));
                }
            }
            catch
            {
                return false;
            }
        }

        // Kiểm tra CCCD đã tồn tại
        public bool IsCCCDExists(string cccd, int excludeMaNV)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    return db.NhanViens.Any(x => x.CCCD == cccd &&
                        (excludeMaNV == 0 || x.MaNV != excludeMaNV));
                }
            }
            catch
            {
                return false;
            }
        }

        // Lấy danh sách nhân viên theo phòng ban
        public List<NhanVien> GetByPhongBan(int maPB)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    return db.NhanViens.Where(x => x.MaPB == maPB).ToList();
                }
            }
            catch
            {
                return new List<NhanVien>();
            }
        }
        public string GetChucVuName(int maNV)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    var nv = db.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
                    if (nv != null)
                    {
                        var chucVu = db.ChucVus.FirstOrDefault(cv => cv.MaCV == nv.MaCV);
                        return chucVu?.TenCV ?? string.Empty;
                    }
                    return string.Empty;
                }
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}