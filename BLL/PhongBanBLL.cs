﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PhongBanBLL
    {
        public List<PhongBan> GetPhongBans()
        {
            PhongBanDll phongBanDll = new PhongBanDll();
            return phongBanDll.GetPhongBans();
        }
    }
}
