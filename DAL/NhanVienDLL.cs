using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class NhanVienDLL
    {
        NhanvienDataContext db = new NhanvienDataContext();
        public List<NhanVien> GetNhanViens()
        {
            return db.NhanViens.ToList();
        }
       
    }
}
