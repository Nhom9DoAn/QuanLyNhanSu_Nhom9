using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;

namespace KimPhuong.DAL
{
    public class ThuongPhatDAL
    {
        dbQuanLyNhanSuDataContext db = new dbQuanLyNhanSuDataContext();
        public List<ThuongPhatDTO> getAllThuongPhat()
        {
            var thuongphat = from tp in db.ThuongPhats
                             join nv in db.NhanViens on tp.MaNV equals nv.MaNV
                             select new ThuongPhatDTO(
                                 tp.MaTP,
                                 tp.MaNV.Value,
                                 nv.HoTen,
                                 tp.Ngay.Value,
                                 tp.Loai,
                                 tp.SoTien.Value,
                                 tp.LyDo,
                                 tp.TrangThai
                                 );
            return thuongphat.ToList();
        }


        //thêm
        public bool AddThuongPhat(ThuongPhatDTO tp)
        {
            try
            {
                var newThuongPhat = new ThuongPhat
                {
                    MaNV = tp.MaNV,
                    Ngay = tp.Ngay,
                    Loai = tp.Loai,
                    SoTien = tp.SoTien,
                    LyDo = tp.LyDo,
                    TrangThai = tp.TrangThai
                };

                db.ThuongPhats.InsertOnSubmit(newThuongPhat);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // sửa
        public bool UpdateThuongPhat(ThuongPhatDTO tp)
        {
            try
            {
                var thuongPhat = db.ThuongPhats.SingleOrDefault(x => x.MaTP == tp.MaTP);
                if (thuongPhat != null)
                {
                    thuongPhat.MaNV = tp.MaNV;
                    thuongPhat.Ngay = tp.Ngay;
                    thuongPhat.Loai = tp.Loai;
                    thuongPhat.SoTien = tp.SoTien;
                    thuongPhat.LyDo = tp.LyDo;
                    thuongPhat.TrangThai = tp.TrangThai;

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // xóa
        public bool DeleteThuongPhat(int maTP)
        {
            try
            {
                var thuongPhat = db.ThuongPhats.SingleOrDefault(x => x.MaTP == maTP);
                if (thuongPhat != null)
                {
                    db.ThuongPhats.DeleteOnSubmit(thuongPhat);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
