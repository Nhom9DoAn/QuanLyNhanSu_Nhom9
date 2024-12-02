using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;
using KimPhuong.DAL;

namespace KimPhuong.BUL
{
    public class ThuongPhatBLL
    {
        ThuongPhatDAL tpdal = new ThuongPhatDAL();
        public List<ThuongPhatDTO> getAllThuongPhat()
        {
            return tpdal.getAllThuongPhat();
        }

        // thêm
        public bool AddThuongPhat(ThuongPhatDTO tp)
        {
            return tpdal.AddThuongPhat(tp);
        }

        // sửa
        public bool UpdateThuongPhat(ThuongPhatDTO tp)
        {
            return tpdal.UpdateThuongPhat(tp);
        }

        // xóa
        public bool DeleteThuongPhat(int maTP)
        {
            return tpdal.DeleteThuongPhat(maTP);
        }
    }
}
