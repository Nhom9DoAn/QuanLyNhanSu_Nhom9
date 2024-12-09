using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DAL;
using KimPhuong.DTO;

namespace KimPhuong.BUL
{
    public class ThamGiaKhoaDaoTaoBLL
    {
        ThamGiaKhoaDAL tgdal = new ThamGiaKhoaDAL();
        public List<ThamGiaKhoaDaoTaoDTO> getAllKhoaDaoTao()
        {
            return tgdal.getAllKhoaDaoTao();
        }

        // Thêm mới ThamGiaDaoTao
        public bool AddThamGiaDaoTao(ThamGiaKhoaDaoTaoDTO tgDTO)
        {
            return tgdal.AddThamGiaDaoTao(tgDTO);
        }

        // Sửa ThamGiaDaoTao
        public bool UpdateThamGiaDaoTao(ThamGiaKhoaDaoTaoDTO tgDTO)
        {
            return tgdal.UpdateThamGiaDaoTao(tgDTO);
        }

        // Xóa ThamGiaDaoTao
        public bool DeleteThamGiaDaoTao(int maNV, int maKhoaDaoTao)
        {
            return tgdal.DeleteThamGiaDaoTao(maNV, maKhoaDaoTao);
        }

        public ThamGiaKhoaDaoTaoDTO GetThamGiaDaoTaoByMa(int maNV, int maKhoaDaoTao)
        {
            return tgdal.GetThamGiaDaoTaoByMa(maNV, maKhoaDaoTao);
        }

        public List<ThamGiaKhoaDaoTaoDTO> Search(string keyword)
        {
            return tgdal.Search(keyword);
        }

    }
}
