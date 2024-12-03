using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class NhanVienDLL
    {
        NhanvienDataContext db = new NhanvienDataContext();
        public List<NhanVien> GetNhanViens()
        {
            return db.NhanViens.ToList();
        }
        public List<TableNhanVien> GetTavleNhanViens() {
            var query = from nv in db.NhanViens
                        join pb in db.PhongBans on nv.MaPB equals pb.MaPB
                        select new TableNhanVien
                        {
                            MaNV = nv.MaNV,
                            HoTen = nv.HoTen,
                            DiaChi = nv.DiaChi,
                            TenPB = pb.TenPB,
                            GioiTinh = nv.GioiTinh,
                            LuongCB = nv.LuongCB,
                            NguoiQuanLy = nv.NguoiQuanLy,
                            NgayVaoLam = nv.NgayVaoLam,
                        };
            return query.ToList();
        }
        public List<TableNhanVien> SearchEmployeeByName(string name)
        {
            var query = from nv in db.NhanViens
                        join pb in db.PhongBans on nv.MaPB equals pb.MaPB
                        where nv.HoTen.Contains(name)
                        select new TableNhanVien
                        {
                            MaNV = nv.MaNV,
                            HoTen = nv.HoTen,
                            DiaChi = nv.DiaChi,
                            TenPB = pb.TenPB,
                            GioiTinh = nv.GioiTinh,
                            LuongCB = nv.LuongCB,
                            NguoiQuanLy = nv.NguoiQuanLy,
                            NgayVaoLam = nv.NgayVaoLam,
                        };
            return query.ToList();
        }
        public void AddEmployee(NhanVien nv)
        {
            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();
        }
        public void DeleteEmployee(int id)
        {
            NhanVien nv = db.NhanViens.Where(x => x.MaNV == id).FirstOrDefault();
            db.NhanViens.DeleteOnSubmit(nv);
            db.SubmitChanges();
        }
        public NhanVien GetEmployeeByID(int id)
        {
            NhanVien nv = db.NhanViens.Where(x => x.MaNV == id).FirstOrDefault();
            return nv;
        }
        public void UpdateEmployee(NhanVien nv)
        {
            NhanVien nvUpdate = db.NhanViens.Where(x => x.MaNV == nv.MaNV).FirstOrDefault();
            nvUpdate.HoTen = nv.HoTen;
            nvUpdate.MaPB = nv.MaPB;
            nvUpdate.GioiTinh = nv.GioiTinh;
            nvUpdate.Email = nv.Email;
            nvUpdate.NgaySinh = nv.NgaySinh;
            nvUpdate.NgayVaoLam = nv.NgayVaoLam;
            nvUpdate.NguoiQuanLy = nv.NguoiQuanLy;
            nvUpdate.TinhTrangHonNhan = nv.TinhTrangHonNhan;
            nvUpdate.DanToc = nv.DanToc;
            nvUpdate.DienThoai = nv.DienThoai;
            nvUpdate.CCCD = nv.CCCD;
            nvUpdate.DiaChi = nv.DiaChi;
            nvUpdate.LuongCB = nv.LuongCB;
            db.SubmitChanges();
        }
    }
}
