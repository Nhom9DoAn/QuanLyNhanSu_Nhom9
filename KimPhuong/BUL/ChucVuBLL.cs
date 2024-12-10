using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DAL;
using KimPhuong.DTO;

namespace KimPhuong.BUL
{
   public class ChucVuBLL
    {
        ChucVuDAL cvdal = new ChucVuDAL();
        public List<ChucVuDTO> GetAllChucVu()
        {
            return cvdal.GetAllChucVu();
        }

        //thêm
        public bool InsertChucVu(ChucVuDTO chucvu)
        {
            return cvdal.InsertChucVu(chucvu);
        }

        //sửa
        public bool UpdateChucVu(ChucVuDTO chucvu)
        {
            return cvdal.UpdateChucVu(chucvu);
        }

        ////xóa
        public bool DeleteChucVu(int maCV)
        {
            return cvdal.DeleteChucVu(maCV);
        }
    }
}
