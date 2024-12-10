using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DAL;
using KimPhuong.DTO;

namespace KimPhuong.BUL
{
    public class BaoCaoTongKetCongTacBLL
    {
        BaoCaoTongKetCongTacDAL bcdal = new BaoCaoTongKetCongTacDAL();
        public List<BaoCaoDTO> GetNhanVienXuatSacTheoThang(int thang, int nam)
        {
            return bcdal.GetNhanVienXuatSacTheoThang(thang, nam);
        }
    }
}
