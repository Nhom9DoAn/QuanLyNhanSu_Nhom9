using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;

namespace KimPhuong.DAL
{
    public class UngVienDAL
    {
        dbQuanLyNhanSuDataContext db = new dbQuanLyNhanSuDataContext();

        public List<UngVienDTO> getAllUngVien()
        {
            var ungvien = from uv in db.UngViens
                            join td in db.TuyenDungs on uv.MaUT equals td.MaUT
                            select new UngVienDTO(
                                uv.MaUngVien,
                                uv.MaUT.Value,
                                td.TenViTri,
                                uv.HoTen,
                                uv.Email,
                                uv.DienThoai,
                                uv.DuongDanCV,
                                uv.NgayUngTuyen.Value,
                                uv.TrangThai
                            );
            return ungvien.ToList();
        }

        // thêm
        public bool AddUngVien(UngVienDTO uv)
        {
            try
            {
                UngVien newUngVien = new UngVien
                {
                    MaUT = uv.MaUT,
                    HoTen = uv.HoTen,
                    Email = uv.Email,
                    DienThoai = uv.DienThoai,
                    DuongDanCV = uv.DuongDanCV,
                    NgayUngTuyen = uv.NgayUngTuyen,
                    TrangThai = uv.TrangThai
                };
                db.UngViens.InsertOnSubmit(newUngVien);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //sửa
        public bool UpdateUngVien(UngVienDTO uv)
        {
            try
            {
                var existingUngVien = db.UngViens.FirstOrDefault(uv1 => uv1.MaUngVien == uv.MaUngVien);
                if (existingUngVien != null)
                {
                    existingUngVien.MaUT = uv.MaUT;
                    existingUngVien.HoTen = uv.HoTen;
                    existingUngVien.Email = uv.Email;
                    existingUngVien.DienThoai = uv.DienThoai;
                    existingUngVien.DuongDanCV = uv.DuongDanCV;
                    existingUngVien.NgayUngTuyen = uv.NgayUngTuyen;
                    existingUngVien.TrangThai = uv.TrangThai;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    Console.WriteLine("Không tìm thấy ứng viên có mã: " + uv.MaUngVien);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật: " + ex.Message);
                return false;
            }
        }

        // xóa
        public bool DeleteUngVien(int maUngVien)
        {
            try
            {
                var ungVienToDelete = db.UngViens.SingleOrDefault(uv => uv.MaUngVien == maUngVien);
                if (ungVienToDelete != null)
                {
                    db.UngViens.DeleteOnSubmit(ungVienToDelete);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
