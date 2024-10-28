using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KimPhuong.DAL
{
    public class NghiPhepDAO
    {
        private dbQuanLyNhanSuDataContext db;

        public NghiPhepDAO()
        {
            db = new dbQuanLyNhanSuDataContext();
        }

        public List<NghiPhep> GetAll()
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    return db.NghiPheps.ToList();
                }
            }
            catch
            {
                return new List<NghiPhep>();
            }
        }

        public bool Insert(int maNV, DateTime ngayBatDau, DateTime ngayKetThuc,
            string lyDo, string trangThai)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    int tongNgay = (ngayKetThuc - ngayBatDau).Days + 1;

                    NghiPhep np = new NghiPhep
                    {
                        MaNV = maNV,
                        NgayBatDau = ngayBatDau,
                        NgayKetThuc = ngayKetThuc,
                        TongNgay = tongNgay,
                        LyDo = lyDo,
                        TrangThai = trangThai
                    };

                    db.NghiPheps.InsertOnSubmit(np);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Update(int maNghiPhep, DateTime ngayBatDau, DateTime ngayKetThuc,
            string lyDo, string trangThai)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    var np = db.NghiPheps.FirstOrDefault(x => x.MaNghiPhep == maNghiPhep);
                    if (np != null)
                    {
                        np.NgayBatDau = ngayBatDau;
                        np.NgayKetThuc = ngayKetThuc;
                        np.TongNgay = (ngayKetThuc - ngayBatDau).Days + 1;
                        np.LyDo = lyDo;
                        np.TrangThai = trangThai;

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

        public bool Delete(int maNghiPhep)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    var np = db.NghiPheps.FirstOrDefault(x => x.MaNghiPhep == maNghiPhep);
                    if (np != null)
                    {
                        db.NghiPheps.DeleteOnSubmit(np);
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

        public NghiPhep GetByID(int maNghiPhep)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    return db.NghiPheps.FirstOrDefault(x => x.MaNghiPhep == maNghiPhep);
                }
            }
            catch
            {
                return null;
            }
        }

        public List<NghiPhep> GetByNhanVien(int maNV)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    return db.NghiPheps.Where(x => x.MaNV == maNV).ToList();
                }
            }
            catch
            {
                return new List<NghiPhep>();
            }
        }

        public List<NghiPhep> Search(int maNV, DateTime tuNgay, DateTime denNgay, string trangThai)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    var query = from np in db.NghiPheps
                                where
                                    (maNV == 0 || np.MaNV == maNV) &&
                                    (tuNgay == DateTime.MinValue || np.NgayBatDau >= tuNgay) &&
                                    (denNgay == DateTime.MinValue || np.NgayKetThuc <= denNgay) &&
                                    (string.IsNullOrEmpty(trangThai) || np.TrangThai == trangThai)
                                select np;

                    return query.ToList();
                }
            }
            catch
            {
                return new List<NghiPhep>();
            }
        }


        public int GetTongNgayNghi(int maNV, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                using (var db = new dbQuanLyNhanSuDataContext())
                {
                    var tongNgay = db.NghiPheps
                        .Where(x => x.MaNV == maNV &&
                               x.NgayBatDau >= tuNgay &&
                               x.NgayKetThuc <= denNgay &&
                               x.TrangThai == "Đã duyệt")
                        .Sum(x => x.TongNgay);

                    return tongNgay.HasValue ? tongNgay.Value : 0;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}