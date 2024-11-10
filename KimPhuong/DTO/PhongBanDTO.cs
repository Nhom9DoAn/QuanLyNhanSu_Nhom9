﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimPhuong.DTO
{
    public class PhongBanDTO
    {
        int mapb;
        string tenpb;
        string diachi;
        string sodienthoai;
        public int MaPB
        {
            get { return mapb; }
            set { mapb = value; }
        }
        public string TenPB
        {
            get { return tenpb; }
            set { tenpb = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string SoDienThoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }
        public PhongBanDTO()
        {
            
        }
        public PhongBanDTO(int maPB, string tenPB, string diaChi, string soDienThoai)
        {
            MaPB = maPB;
            TenPB = tenPB;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }
    }
}
