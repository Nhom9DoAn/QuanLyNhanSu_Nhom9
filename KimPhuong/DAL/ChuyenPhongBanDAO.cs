using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DAL
{
    public class ChuyenPhongBanDAO
    {
        dbQuanLyNhanSuDataContext db;
        public ChuyenPhongBanDAO()
        {
            db = new dbQuanLyNhanSuDataContext();
        }
        public List<ChuyenPhongBan> GetAll()
        {
            try
            {
                return db.ChuyenPhongBans.ToList();
            }
            catch
            {
                return new List<ChuyenPhongBan>();
            }
        }
    }
}
