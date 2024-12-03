using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
    public class PhongBanDll
    {
        NhanvienDataContext db = new NhanvienDataContext();
        public List<PhongBan> GetPhongBans()
        {
            return db.PhongBans.ToList();
        }
        public List<TableNhanVien> GetEmployeeInDepartment(int id)
        {
            var query = from pb in db.PhongBans
                        join nv in db.NhanViens on pb.MaPB equals nv.MaPB
                        where pb.MaPB == id
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
    }
}
