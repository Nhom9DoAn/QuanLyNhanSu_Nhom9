using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;

namespace KimPhuong.DAL
{
    public class TuyenDungDAL
    {
        dbQuanLyNhanSuDataContext db = new dbQuanLyNhanSuDataContext();
        public List<TuyenDungDTO> getAllTuyenDung()
        {
            var tuyendung = from td in db.TuyenDungs
                            join pb in db.PhongBans on td.MaPhong equals pb.MaPB
                            join nv in db.NhanViens on td.NguoiPhuTrach equals nv.MaNV
                            select new TuyenDungDTO(
                               td.MaUT,
                               td.TenViTri,
                               td.MaPhong.Value,
                               pb.TenPB,
                               td.SoLuong.Value,
                               td.TrangThai,
                               td.NgayBatDau.Value,
                               td.NgayKetThuc.Value,
                               td.YeuCau,
                               td.NguoiPhuTrach.Value,
                               nv.HoTen
                            );
            return tuyendung.ToList();

        }


        // thêm
        public bool AddTuyenDung(TuyenDungDTO td)
        {
            try
            {
                TuyenDung newTD = new TuyenDung
                {
                    TenViTri = td.TenViTri,
                    MaPhong = td.MaPhong,
                    SoLuong = td.SoLuong,
                    TrangThai = td.TrangThai,
                    NgayBatDau = td.NgayBatDau,
                    NgayKetThuc = td.NgayKetThuc,
                    YeuCau = td.YeuCau,
                    NguoiPhuTrach = td.NguoiPhuTrach
                };
                db.TuyenDungs.InsertOnSubmit(newTD);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // sửa
        public bool UpdateTuyenDung(TuyenDungDTO td)
        {
            try
            {
                var existingTD = db.TuyenDungs.FirstOrDefault(x => x.MaUT == td.MaUT);
                if (existingTD != null)
                {
                    existingTD.TenViTri = td.TenViTri;
                    existingTD.MaPhong = td.MaPhong;
                    existingTD.SoLuong = td.SoLuong;
                    existingTD.TrangThai = td.TrangThai;
                    existingTD.NgayBatDau = td.NgayBatDau;
                    existingTD.NgayKetThuc = td.NgayKetThuc;
                    existingTD.YeuCau = td.YeuCau;
                    existingTD.NguoiPhuTrach = td.NguoiPhuTrach;

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

        // xóa
        public bool DeleteTuyenDung(int maUT)
        {
            try
            {
                var tdToDelete = db.TuyenDungs.FirstOrDefault(x => x.MaUT == maUT);
                if (tdToDelete != null)
                {
                    db.TuyenDungs.DeleteOnSubmit(tdToDelete);
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

        public TuyenDungDTO GetViTriById(int id)
        {
            var viTri = db.TuyenDungs
                          .Where(td => td.MaUT == id)
                          .Select(td => new TuyenDungDTO
                          {
                              MaUT = td.MaUT,
                              TenViTri = td.TenViTri
                          })
                          .FirstOrDefault();

            return viTri;
        }


    }
}
