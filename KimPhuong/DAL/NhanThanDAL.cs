using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;

namespace KimPhuong.DAL
{
    public class NhanThanDAL
    {
        dbQuanLyNhanSuDataContext db = new dbQuanLyNhanSuDataContext();
        public List<NhanThanDTO> getAllNhanThan()
        {
            var nhanthan = from nt in db.NhanThans
                           join nv in db.NhanViens on nt.MaNV equals nv.MaNV
                           select new NhanThanDTO(
                               nt.MaNT,
                               nt.MaNV.Value,
                               nv.HoTen,
                               nt.HoTen,
                               nt.QuanHe,
                               nt.NgaySinh.Value,
                               nt.DienThoai,
                               nt.DiaChi.ToString()
                               );
            return nhanthan.ToList();
        }

        //thêm
        public bool AddNhanThan(NhanThanDTO nhanThanDTO)
        {
            try
            {
                NhanThan newNhanThan = new NhanThan
                {
                    MaNV = nhanThanDTO.MaNV,
                    HoTen = nhanThanDTO.HoTenNT,
                    QuanHe = nhanThanDTO.QuanHe,
                    NgaySinh = nhanThanDTO.NgaySinh,
                    DienThoai = nhanThanDTO.DienThoai,
                    DiaChi = nhanThanDTO.DiaChi
                };

                db.NhanThans.InsertOnSubmit(newNhanThan);
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
        public bool UpdateNhanThan(NhanThanDTO nhanThanDTO)
        {
            try
            {
                var nhanThanToUpdate = db.NhanThans.SingleOrDefault(nt => nt.MaNT == nhanThanDTO.MaNT);
                if (nhanThanToUpdate != null)
                {
                    nhanThanToUpdate.MaNV = nhanThanDTO.MaNV;
                    nhanThanToUpdate.HoTen = nhanThanDTO.HoTenNT;
                    nhanThanToUpdate.QuanHe = nhanThanDTO.QuanHe;
                    nhanThanToUpdate.NgaySinh = nhanThanDTO.NgaySinh;
                    nhanThanToUpdate.DienThoai = nhanThanDTO.DienThoai;
                    nhanThanToUpdate.DiaChi = nhanThanDTO.DiaChi;

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

        //xóa
        public bool DeleteNhanThan(int maNT)
        {
            try
            {
                var nhanThanToDelete = db.NhanThans.SingleOrDefault(nt => nt.MaNT == maNT);
                if (nhanThanToDelete != null)
                {
                    db.NhanThans.DeleteOnSubmit(nhanThanToDelete);
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
