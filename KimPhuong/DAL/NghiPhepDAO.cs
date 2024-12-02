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

        public List<dynamic> GetAll()
        {
            try
            {


                var result = db.NghiPheps.Select(np => new
                {
                    np.MaNghiPhep,
                    np.MaNV,
                    TenNhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == np.MaNV).HoTen,
                    np.TrangThai,
                    np.NgayBatDau,
                    np.NgayKetThuc,
                    np.TongNgay,
                    np.LyDo
                }).ToList();

                return result.Cast<dynamic>().ToList();

            }
            catch
            {
                return new List<dynamic>();
            }
        }


        public bool Insert(int maNV, DateTime ngayBatDau, DateTime ngayKetThuc,
            string lyDo, string trangThai)
        {
            try
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
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                return false;
            }
        }

        public bool Delete(int maNghiPhep)
        {
            try
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
            catch
            {
                return false;
            }
        }

        public NghiPhep GetByID(int maNghiPhep)
        {
            try
            {


                return db.NghiPheps.FirstOrDefault(x => x.MaNghiPhep == maNghiPhep);

            }
            catch
            {
                return null;
            }
        }

        public List<dynamic> GetByNhanVien(int maNV)
        {
            try
            {
                var result = db.NghiPheps
                    .Where(x => maNV == 0 || x.MaNV == maNV)
                    .Select(np => new
                    {
                        np.MaNghiPhep,
                        np.MaNV,
                        TenNhanVien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == np.MaNV).HoTen,
                        np.TrangThai,
                        np.NgayBatDau,
                        np.NgayKetThuc,
                        np.TongNgay,
                        np.LyDo
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

                var result = from np in db.NghiPheps
                             join nv in db.NhanViens on np.MaNV equals nv.MaNV into nvGroup
                             from nv in nvGroup.DefaultIfEmpty()
                             where
                                 (string.IsNullOrEmpty(keyword) ||
                                  np.MaNV.ToString().Contains(keyword) ||
                                  np.TrangThai.ToLower().Contains(keyword.ToLower()) ||
                                  nv.HoTen.ToLower().Contains(keyword.ToLower()) ||
                                  np.NgayBatDau.ToString().Contains(keyword) ||
                                  np.NgayKetThuc.ToString().Contains(keyword))
                             select new
                             {
                                 np.MaNghiPhep,
                                 np.MaNV,
                                 TenNhanVien = nv.HoTen,
                                 np.TrangThai,
                                 np.NgayBatDau,
                                 np.NgayKetThuc,
                                 np.TongNgay,
                                 np.LyDo
                             };

                return result.Cast<dynamic>().ToList();

            }
            catch
            {
                return new List<dynamic>();
            }
        }



        public int GetTongNgayNghi(int maNV, DateTime tuNgay, DateTime denNgay)
        {
            try
            {


                var tongNgay = db.NghiPheps
                    .Where(x => x.MaNV == maNV &&
                           x.NgayBatDau >= tuNgay &&
                           x.NgayKetThuc <= denNgay &&
                           x.TrangThai == "Đã duyệt")
                    .Sum(x => x.TongNgay);

                return tongNgay.HasValue ? tongNgay.Value : 0;

            }
            catch
            {
                return 0;
            }
        }
    }
}