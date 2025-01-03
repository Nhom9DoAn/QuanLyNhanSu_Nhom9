﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DBC;
using KimPhuong.DTO;
using System.Windows.Forms;

namespace KimPhuong.DAL
{
    public class PhongBanDAO
    {
        private dbQuanLyNhanSuDataContext db;

        public PhongBanDAO()
        {
            db = new dbQuanLyNhanSuDataContext();
        }

        public List<PhongBan> getAll()
        {
            try
            {
                return db.PhongBans.ToList();
            }
            catch
            {
                return new List<PhongBan>();
            }
        }

        public dynamic ThongKeGioiTinhTheoPhong(int maPhongBan)
        {
            var result = db.NhanViens
                .Where(nv => nv.MaPB == maPhongBan)
                .GroupBy(nv => nv.PhongBan)
                .Select(g => new
                {
                    MaPhongBan = g.Key.MaPB,
                    TenPhongBan = g.Key.TenPB,
                    SoNam = g.Count(nv => nv.GioiTinh == "Nam"),
                    SoNu = g.Count(nv => nv.GioiTinh == "Nữ"),
                    TongSo = g.Count()
                })
                .FirstOrDefault();

            return result;

        }


        public bool insert(string tenPB, string diaChi, string sdtPB)
        {
            try
            {
                PhongBan pb = new PhongBan
                {
                    TenPB = tenPB,
                    DiaChi = diaChi,
                    SDTPB = sdtPB
                };
                db.PhongBans.InsertOnSubmit(pb);
                db.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool delete(int maPB)
        {
            try
            {
                var np = db.PhongBans.FirstOrDefault(x => x.MaPB == maPB);
                if (np != null)
                {
                    db.PhongBans.DeleteOnSubmit(np);
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

        public bool update(int maPB, string tenPB, string diaChi, string sdtPB)
        {
            try
            {
                var np = db.PhongBans.FirstOrDefault(x => x.MaPB == maPB);
                if (np != null)
                {
                    np.TenPB = tenPB;
                    np.DiaChi = diaChi;
                    np.SDTPB = sdtPB;

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

        public List<PhongBan> SearchPhongBan(string keyword)
        {
            try
            {
                var query = from pb in db.PhongBans
                            where
                                (string.IsNullOrEmpty(keyword) ||
                                pb.MaPB.ToString().Contains(keyword) ||
                                pb.TenPB.ToLower().Contains(keyword.ToLower()))
                            select pb;

                return query.ToList();
            }
            catch
            {
                return new List<PhongBan>();
            }
        }

    }


}
