using KimPhuong.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DAL
{
    public class CongTacDAO
    {
        dbQuanLyNhanSuDataContext db = new dbQuanLyNhanSuDataContext();

        public List<CongTacDTO> GetAll()
        {
            var congtac = from ct in db.CongTacs
                          join nv in db.NhanViens on ct.MaNV equals nv.MaNV
                          select new CongTacDTO(
                            ct.MaCT,
                            (int)ct.MaNV,
                            nv.HoTen,
                            ct.NgayBatDau.GetValueOrDefault(),
                            ct.NgayKetThuc.GetValueOrDefault(),
                            ct.DiaDiem,
                            ct.MucDich,
                            ct.BieuMau,
                            ct.TrangThai
                        );

            return congtac.ToList();
        }
        public bool InsertCongTac(CongTacDTO congTac)
        {
            try
            {
                var newCongTac = new CongTac
                {
                    MaNV = congTac.MaNV,
                    NgayBatDau = congTac.NgayBatDau,
                    NgayKetThuc = congTac.NgayKetThuc,
                    DiaDiem = congTac.DiaDiem,
                    MucDich = congTac.MucDich,
                    BieuMau = congTac.BieuMau,
                    TrangThai = congTac.TrangThai
                };

                db.CongTacs.InsertOnSubmit(newCongTac);
                db.SubmitChanges(); 

                return true; 
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm công tác: {ex.Message}");
            }
        }
        public bool UpdateCongTac(CongTacDTO congTac)
        {
            try
            {
                var existingCongTac = db.CongTacs.SingleOrDefault(ct => ct.MaCT == congTac.MaCT);
                if (existingCongTac == null)
                {
                    throw new Exception("Không tìm thấy công tác cần sửa.");
                }
                existingCongTac.MaNV = congTac.MaNV;
                existingCongTac.NgayBatDau = congTac.NgayBatDau;
                existingCongTac.NgayKetThuc = congTac.NgayKetThuc;
                existingCongTac.DiaDiem = congTac.DiaDiem;
                existingCongTac.MucDich = congTac.MucDich;
                existingCongTac.BieuMau = congTac.BieuMau;
                existingCongTac.TrangThai = congTac.TrangThai;
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật công tác: {ex.Message}");
            }
        }

        //xóa
        public bool DeleteCongTac(int maCT)
        {
            try
            {
                var congTacToDelete = db.CongTacs.SingleOrDefault(ct => ct.MaCT == maCT);
                if (congTacToDelete == null)
                {
                    throw new Exception("Không tìm thấy công tác cần xóa.");
                }
                db.CongTacs.DeleteOnSubmit(congTacToDelete);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa công tác: {ex.Message}");
            }
        }

        //lọc theo ngày bd, ngày kt hoặc tên nhân viên
        public List<CongTacDTO> FilterCongTac(DateTime? startDate, DateTime? endDate, string employeeName)
        {
            var query = from ct in db.CongTacs
                        join nv in db.NhanViens on ct.MaNV equals nv.MaNV
                        select new { ct, nv.HoTen };

            if (startDate.HasValue)
            {
                query = query.Where(x => x.ct.NgayBatDau >= startDate.Value);
            }
            if (endDate.HasValue)
            {
                query = query.Where(x => x.ct.NgayKetThuc <= endDate.Value);
            }
            if (!string.IsNullOrEmpty(employeeName))
            {
                query = query.Where(x => x.HoTen.Contains(employeeName));
            }
            var result = query.Select(x => new CongTacDTO
            {
                MaCT = x.ct.MaCT,
                MaNV = (int)x.ct.MaNV,
                HoTen = x.HoTen,
                NgayBatDau = x.ct.NgayBatDau.GetValueOrDefault(),
                NgayKetThuc = x.ct.NgayKetThuc.GetValueOrDefault(),
                DiaDiem = x.ct.DiaDiem,
                MucDich = x.ct.MucDich,
                BieuMau = x.ct.BieuMau,
                TrangThai = x.ct.TrangThai
            }).ToList();

            return result;
        }



    }
}
