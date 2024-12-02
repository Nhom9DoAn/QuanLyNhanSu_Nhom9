using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DAL;
using KimPhuong.DTO;


namespace KimPhuong.BUL
{
    public class HopDongBLL
    {
        HopDongDAL hdal = new HopDongDAL();
        public List<HopDongDTO> getAllHopDong()
        {
            return hdal.getAllHopDong();
        }

        // Thêm hợp đồng
        public bool AddHopDong(HopDongDTO hopDong)
        {
            return hdal.AddHopDong(hopDong);
        }

        // Sửa hợp đồng
        public bool UpdateHopDong(HopDongDTO hopDong)
        {
            return hdal.UpdateHopDong(hopDong);
        }

        // Xóa hợp đồng
        public bool DeleteHopDong(int maHD)
        {
            return hdal.DeleteHopDong(maHD);
        }
    }
}
