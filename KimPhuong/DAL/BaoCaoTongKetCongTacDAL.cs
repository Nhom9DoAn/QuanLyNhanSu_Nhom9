using KimPhuong.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DAL
{
    public class BaoCaoTongKetCongTacDAL
    {
        dbQuanLyNhanSuDataContext db = new dbQuanLyNhanSuDataContext();
        public List<BaoCaoDTO> GetNhanVienXuatSacTheoThang(int thang, int nam)
        {
            var result = (from nv in db.NhanViens
                          join cc in db.ChamCongs on nv.MaNV equals cc.MaNV
                          join pb in db.PhongBans on nv.MaPB equals pb.MaPB
                          join cct in db.CongTacs on nv.MaNV equals cct.MaNV into cctGroup
                          from cct in cctGroup.DefaultIfEmpty() // Lấy tất cả chuyến công tác của nhân viên (nếu có)
                          where cc.Ngay.HasValue && cc.Ngay.Value.Month == thang && cc.Ngay.Value.Year == nam
                          group new { cc, cct } by new { nv.MaNV, nv.HoTen, pb.TenPB, nv.LuongCB } into g
                          let soNgayCong = g.Count(x => x.cc.Ngay.HasValue)  // Tính số ngày công
                          let soChuyenCongTac = g.Count(x => x.cct != null)  // Tính số chuyến công tác (nếu có)
                          where soNgayCong >= 1 // Ví dụ: chỉ những nhân viên có >= 20 ngày công mới được xem là xuất sắc
                          select new BaoCaoDTO
                          {
                              MaNV = g.Key.MaNV,
                              HoTen = g.Key.HoTen,
                              TenPB = g.Key.TenPB,
                              LuongCB = g.Key.LuongCB.Value,
                              Thuong = db.ThuongPhats.Where(tp => tp.MaNV == g.Key.MaNV).Sum(tp => tp.SoTien) ?? 0, // Tính tổng thưởng từ bảng ThuongPhat
                              SoNgayCong = soNgayCong,
                              SoChuyenCongTac = soChuyenCongTac,
                          }).ToList();

            return result;
        }
    }
}
