using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DAL
{
    public class KhoaDaoTaoDAO
    {
        private dbQuanLyNhanSuDataContext db;

        public KhoaDaoTaoDAO()
        {
            db = new dbQuanLyNhanSuDataContext();
        }

        public List<dynamic> GetAll()
        {
            try
            {
                var result = db.KhoaDaoTaos.Select(x => new
                {
                    x.MaKhoaDaoTao,
                    x.TenKhoaHoc,
                    x.DonViDaoTao,
                    x.NgayBatDau,
                    x.NgayKetThuc,
                    x.ChiPhi,
                    x.TrangThai
                }).ToList();
                return result.Cast<dynamic>().ToList();
            }
            catch
            {
                return new List<dynamic>();
            }
        }

        public bool Insert(string tenkh, string donvi,
            DateTime ngaybd, DateTime ngaykt,
            int chiPhi, string ghiChu)
        {
            try
            {
                KhoaDaoTao kdt = new KhoaDaoTao
                {
                    TenKhoaHoc = tenkh,
                    DonViDaoTao = donvi,
                    NgayBatDau = ngaybd,
                    NgayKetThuc = ngaykt,
                    ChiPhi = chiPhi,
                    TrangThai = ghiChu
                };

                db.KhoaDaoTaos.InsertOnSubmit(kdt);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int maKDT, string tenkh, string donvi,
            DateTime ngaybd, DateTime ngaykt,
            int chiPhi, string ghiChu)
        {
            try
            {
                var kdt = db.KhoaDaoTaos.FirstOrDefault(x => x.MaKhoaDaoTao == maKDT);
                if (kdt != null)
                {
                    kdt.TenKhoaHoc = tenkh;
                    kdt.DonViDaoTao = donvi;
                    kdt.NgayBatDau = ngaybd;
                    kdt.NgayKetThuc = ngaykt;
                    kdt.ChiPhi = chiPhi;
                    kdt.TrangThai = ghiChu;

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

        public bool Delete(int maKDT)
        {
            try
            {
                var kdt = db.KhoaDaoTaos.FirstOrDefault(x => x.MaKhoaDaoTao == maKDT);
                if (kdt != null)
                {
                    db.KhoaDaoTaos.DeleteOnSubmit(kdt);
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
                var query = db.KhoaDaoTaos.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(kdt =>
                        kdt.TenKhoaHoc.Contains(keyword) ||
                        kdt.DonViDaoTao.Contains(keyword) ||
                        kdt.TrangThai.Contains(keyword)
                    );
                }

                var result = query.Select(x => new
                {
                    x.MaKhoaDaoTao,
                    x.TenKhoaHoc,
                    x.DonViDaoTao,
                    x.NgayBatDau,
                    x.NgayKetThuc,
                    x.ChiPhi,
                    x.TrangThai
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