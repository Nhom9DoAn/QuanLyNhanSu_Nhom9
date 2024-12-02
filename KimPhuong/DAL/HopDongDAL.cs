using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;

namespace KimPhuong.DAL
{
    public class HopDongDAL
    {
        dbQuanLyNhanSuDataContext db = new dbQuanLyNhanSuDataContext();
        public List<HopDongDTO> getAllHopDong()
        {
            var hopdong = from hd in db.HopDongs
                          join nv in db.NhanViens on hd.MaNV equals nv.MaNV
                          select new HopDongDTO (
                              hd.MaHD,
                              nv.MaNV,
                              nv.HoTen,
                              hd.LoaiHD,
                              hd.NgayBatDau.Value,
                              hd.NgayKetThuc.Value,
                              hd.BieuMau,
                              hd.TinhTrang

                              );
            return hopdong.ToList();
        }


        // Thêm hợp đồng
        public bool AddHopDong(HopDongDTO hopDong)
        {
            try
            {
                HopDong newHD = new HopDong
                {
                    MaNV = hopDong.MaNV,
                    LoaiHD = hopDong.LoaiHD,
                    NgayBatDau = hopDong.NgayBatDau,
                    NgayKetThuc = hopDong.NgayKetThuc,
                    BieuMau = hopDong.BieuMau,
                    TinhTrang = hopDong.TinhTrang
                };
                db.HopDongs.InsertOnSubmit(newHD);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sửa hợp đồng
        public bool UpdateHopDong(HopDongDTO hopDong)
        {
            try
            {
                var existingHD = db.HopDongs.SingleOrDefault(hd => hd.MaHD == hopDong.MaHD);
                if (existingHD != null)
                {
                    existingHD.MaNV = hopDong.MaNV;
                    existingHD.LoaiHD = hopDong.LoaiHD;
                    existingHD.NgayBatDau = hopDong.NgayBatDau;
                    existingHD.NgayKetThuc = hopDong.NgayKetThuc;
                    existingHD.BieuMau = hopDong.BieuMau;
                    existingHD.TinhTrang = hopDong.TinhTrang;

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

        // Xóa hợp đồng
        public bool DeleteHopDong(int maHD)
        {
            try
            {
                var hdToDelete = db.HopDongs.SingleOrDefault(hd => hd.MaHD == maHD);
                if (hdToDelete != null)
                {
                    db.HopDongs.DeleteOnSubmit(hdToDelete);
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
    }
}
