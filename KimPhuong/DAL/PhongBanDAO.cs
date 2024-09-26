using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DBC;
using KimPhuong.DTO;

namespace KimPhuong.DAL
{
    public class PhongBanDAO
    {
        DataTable dt_phongban;
        SqlDataAdapter adapter;
        private DBConnection dB;
        public PhongBanDAO()
        {
            dB = new DBConnection();
            dt_phongban = new DataTable();
            adapter = new SqlDataAdapter("select * from PHONGBAN", dB.GetConnection());
            adapter.Fill(dt_phongban);
        }
        public List<PhongBanDTO> getAll()
        {
            List<PhongBanDTO> lst = new List<PhongBanDTO>();
            foreach (DataRow row in dt_phongban.Rows)
            {
                PhongBanDTO phongBan = new PhongBanDTO(row["MaPB"].ToString(), row["TenPB"].ToString(),
                    row["DiaChi"].ToString(), row["SDTPB"].ToString());
                lst.Add(phongBan);
            }
            return lst;
        }
    }
   
}
