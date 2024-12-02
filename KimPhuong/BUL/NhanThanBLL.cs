using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;
using KimPhuong.DAL;

namespace KimPhuong.BUL
{
    public class NhanThanBLL
    {
        NhanThanDAL ntdal = new NhanThanDAL();

        public List<NhanThanDTO> getAllNhanThan()
        {
            return ntdal.getAllNhanThan();
        }

        //thêm
        public bool AddNhanThan(NhanThanDTO nhanThanDTO)
        {
            return ntdal.AddNhanThan(nhanThanDTO);
        }


        //sửa
        public bool UpdateNhanThan(NhanThanDTO nhanThanDTO)
        {
            return ntdal.UpdateNhanThan(nhanThanDTO);
        }

        //xóa
        public bool DeleteNhanThan(int maNT)
        {
            return ntdal.DeleteNhanThan(maNT);
        }

    }
}
