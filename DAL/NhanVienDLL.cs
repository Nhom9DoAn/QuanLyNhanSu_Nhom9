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
        public List<TableNhanVien> GetTavleNhanViens()
        {
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
        public int DiemDanh(int id, DateTime ngay, string ghiChu, DateTime? gioRa, DateTime? gioVao, int phep)
        {
            try
            {
                if (phep == 1)
                {
                    var a = db.ChamCongs.Where(x => x.MaNV == id && x.Ngay == ngay && x.TrangThai == "Nghĩ phép").FirstOrDefault();
                    if (a != null)
                    { return 0; }
                    ChamCong chamCong1 = new ChamCong();
                    chamCong1.MaNV = id;
                    chamCong1.TrangThai = "Nghĩ phép";
                    chamCong1.Ngay = ngay;
                    chamCong1.GhiChu = ghiChu;
                    db.ChamCongs.InsertOnSubmit(chamCong1);
                    db.SubmitChanges();
                    return 1;
                }

                ChamCong chamCong = new ChamCong();
                chamCong.TrangThai = "Đi trễ";
                if (gioRa == null)
                {
                    var a = db.ChamCongs.Where(x => x.MaNV == id && x.Ngay == ngay).FirstOrDefault();
                    if (a != null)
                    {
                        return 0;
                    }
                    chamCong.MaNV = id;
                    chamCong.Ngay = ngay;
                    chamCong.GhiChu = ghiChu;
                    if (gioVao.HasValue)
                    {
                        chamCong.GioVao = gioVao.Value.TimeOfDay;
                    }
                    TimeSpan gioTruoc8h = new TimeSpan(8, 0, 0);
                    if (gioVao.HasValue)  // Kiểm tra xem gioVao có giá trị hay không
                    {
                        if (gioVao.Value.TimeOfDay <= gioTruoc8h)
                        {
                            chamCong.TrangThai = "Đi đúng giờ";
                        }
                        else
                        {
                            chamCong.TrangThai = "Đi trễ";
                        }
                    }
                    db.ChamCongs.InsertOnSubmit(chamCong);
                    db.SubmitChanges();
                    return 1;
                }
                if (gioVao == null)
                {
                    // Tìm bản ghi chấm công của nhân viên trong ngày
                    var a = db.ChamCongs.Where(x => x.MaNV == id && x.Ngay == ngay).FirstOrDefault();

                    // Nếu không tìm thấy bản ghi hoặc chưa có giờ vào
                    if (a == null || a.GioVao == null)
                    {
                        return 2;  // Chưa điểm danh giờ vào
                    }
                    else
                    {
                        // Tìm bản ghi chấm công của nhân viên trong n
                        if (a != null && a.GioVao != null && a.GioRa==null)
                        {
                            if (gioRa.HasValue)
                            {
                                a.GioRa = gioRa.Value.TimeOfDay;
                            }

                            // Kiểm tra giờ ra sau 17h và cập nhật trạng thái
                            if (gioRa.HasValue)
                            {
                                TimeSpan gioSau17h = new TimeSpan(17, 0, 0);
                                TimeSpan gioRaTime = gioRa.Value.TimeOfDay;

                                if (gioRaTime >= gioSau17h)
                                {
                                    // Cập nhật trạng thái là "Về sớm"
                                    a.TrangThai = a.TrangThai + " Về sớm";
                                }
                            }

                            db.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                            return 1;  // Cập nhật thành công
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
              

            }

            catch
            {
                return 0;
            }
            return 0;
        }
    }
}
