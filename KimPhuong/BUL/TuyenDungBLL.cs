using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DTO;
using KimPhuong.DAL;

namespace KimPhuong.BUL
{
    public class TuyenDungBLL
    {

        TuyenDungDAL td_dal = new TuyenDungDAL();
        public List<TuyenDungDTO> getAllTuyenDung()
        {
            return td_dal.getAllTuyenDung();
        }

        // thêm
        public bool AddTuyenDung(TuyenDungDTO td)
        {
            return td_dal.AddTuyenDung(td);
        }

        // sửa
        public bool UpdateTuyenDung(TuyenDungDTO td)
        {
            return td_dal.UpdateTuyenDung(td);
        }

        // xóa
        public bool DeleteTuyenDung(int maUT)
        {
            return td_dal.DeleteTuyenDung(maUT);
        }

        public TuyenDungDTO GetViTriById(int id)
        {
            return td_dal.GetViTriById(id);
        }
    }
}
