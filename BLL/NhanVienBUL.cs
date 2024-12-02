using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NhanVienBUL
    {
        public List<NhanVien> GetNhanViens()
        {
            NhanVienDLL nhanVienDll = new NhanVienDLL();
            return nhanVienDll.GetNhanViens();
        }
    }
}
