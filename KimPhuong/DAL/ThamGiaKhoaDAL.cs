using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;

namespace KimPhuong.DAL
{
    public class ThamGiaKhoaDAL
    {
        dbQuanLyNhanSuDataContext db = new dbQuanLyNhanSuDataContext();
        public List<ThamGiaKhoaDaoTaoDTO> getAllKhoaDaoTao()
        {
            var tgkhoadt = from tgkdt in db.ThamGiaDaoTaos
                           join nv in db.NhanViens on tgkdt.MaNV equals nv.MaNV
                           join khoadt in db.KhoaDaoTaos on tgkdt.MaKhoaDaoTao equals khoadt.MaKhoaDaoTao
                           select new ThamGiaKhoaDaoTaoDTO(
                               tgkdt.MaNV,
                               nv.HoTen,
                               tgkdt.MaKhoaDaoTao,
                               khoadt.TenKhoaHoc,
                               tgkdt.NgayThamGia.Value,
                               tgkdt.KetQua,
                               tgkdt.ChungChi

                               );
            return tgkhoadt.ToList();
                            
        }


        // Thêm mới ThamGiaDaoTao
        public bool AddThamGiaDaoTao(ThamGiaKhoaDaoTaoDTO tgDTO)
        {
            try
            {
                var tg = new ThamGiaDaoTao
                {
                    MaNV = tgDTO.MaNV,
                    MaKhoaDaoTao = tgDTO.MaKhoaDaoTao,
                    NgayThamGia = tgDTO.NgayThamGia,
                    KetQua = tgDTO.KetQua,
                    ChungChi = tgDTO.ChungChi
                };
                db.ThamGiaDaoTaos.InsertOnSubmit(tg);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Sửa ThamGiaDaoTao
        public bool UpdateThamGiaDaoTao(ThamGiaKhoaDaoTaoDTO tgDTO)
        {
            try
            {
                var tg = db.ThamGiaDaoTaos.FirstOrDefault(t => t.MaNV == tgDTO.MaNV && t.MaKhoaDaoTao == tgDTO.MaKhoaDaoTao);
                if (tg != null)
                {
                    tg.NgayThamGia = tgDTO.NgayThamGia;
                    tg.KetQua = tgDTO.KetQua;
                    tg.ChungChi = tgDTO.ChungChi;
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

        // Xóa ThamGiaDaoTao
        public bool DeleteThamGiaDaoTao(int maNV, int maKhoaDaoTao)
        {
            try
            {
                var tg = db.ThamGiaDaoTaos.FirstOrDefault(t => t.MaNV == maNV && t.MaKhoaDaoTao == maKhoaDaoTao);
                if (tg != null)
                {
                    db.ThamGiaDaoTaos.DeleteOnSubmit(tg);
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

        public ThamGiaKhoaDaoTaoDTO GetThamGiaDaoTaoByMa(int maNV, int maKhoaDaoTao)
        {
            var tg = db.ThamGiaDaoTaos
                       .Where(t => t.MaNV == maNV && t.MaKhoaDaoTao == maKhoaDaoTao)
                       .FirstOrDefault();

            if (tg != null)
            {
                return new ThamGiaKhoaDaoTaoDTO
                {
                    MaNV = tg.MaNV,
                    MaKhoaDaoTao = tg.MaKhoaDaoTao,
                    NgayThamGia = tg.NgayThamGia ?? DateTime.MinValue,
                    KetQua = tg.KetQua,
                    ChungChi = tg.ChungChi
                };
            }

            return null;
        }

    }
}
