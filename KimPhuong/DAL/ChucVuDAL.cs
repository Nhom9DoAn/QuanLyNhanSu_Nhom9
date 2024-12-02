using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;

namespace KimPhuong.DAL
{
    public class ChucVuDAL
    {
        dbQuanLyNhanSuDataContext db = new dbQuanLyNhanSuDataContext();
        public List<ChucVuDTO> GetAllChucVu()
        {
            var chucvu = from cv in db.ChucVus
                          select new ChucVuDTO
                          {
                              MaCV =(int) cv.MaCV,
                              TenCV = cv.TenCV,
                              Mota = cv.MoTa
                          };

            return chucvu.ToList();
        }

        //thêm
        public bool InsertChucVu(ChucVuDTO chucvu)
        {
            try
            {
                var newChucVu = new ChucVu
                {
                   TenCV = chucvu.TenCV,
                   MoTa = chucvu.Mota
                };

                db.ChucVus.InsertOnSubmit(newChucVu);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm chức vụ: {ex.Message}");
            }
        }

        //sửa
        public bool UpdateChucVu(ChucVuDTO chucvu)
        {
            try
            {
                var existingChucVu = db.ChucVus.SingleOrDefault(ct => ct.MaCV == chucvu.MaCV);
                if (existingChucVu == null)
                {
                    throw new Exception("Không tìm thấy chức vụ cần sửa.");
                }
                existingChucVu.TenCV = chucvu.TenCV;
                existingChucVu.MoTa = chucvu.Mota;
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật chức vụ: {ex.Message}");
            }
        }

        //xóa
        //xóa
        public bool DeleteChucVu(int maCV)
        {
            try
            {
                var chucvuDel = db.ChucVus.SingleOrDefault(ct => ct.MaCV == maCV);
                if (chucvuDel == null)
                {
                    throw new Exception("Không tìm thấy chức vụ cần xóa.");
                }
                db.ChucVus.DeleteOnSubmit(chucvuDel);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa chức vụ: {ex.Message}");
            }
        }
    }
}
