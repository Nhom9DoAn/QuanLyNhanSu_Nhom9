using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class ChucVuDTO
    {
        private int maCV;
        private string mota;
        private string tenCV;

        public int MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public string Mota { get => mota; set => mota = value; }
        public ChucVuDTO() { }

        public ChucVuDTO(int maCV, string mota, string tenCV)
        {
            MaCV = maCV;
            TenCV = mota;
            Mota = tenCV;
        }

        
    }
}
