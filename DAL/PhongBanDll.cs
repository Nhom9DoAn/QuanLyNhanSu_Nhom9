using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
    public class PhongBanDll
    {
        NhanvienDataContext db = new NhanvienDataContext();
        public List<PhongBan> GetPhongBans()
        {
            return db.PhongBans.ToList();
        }
    }
}
