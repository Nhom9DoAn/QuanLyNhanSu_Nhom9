using KimPhuong.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KimPhuong.DBC;

namespace KimPhuong.DAL
{
    public class DAO_ChucVu
    {
        DataTable dt_chucvu;
        SqlDataAdapter adapter;
        private DBConnection dB;

        public DAO_ChucVu()
        {
            dB = new DBConnection();
            dt_chucvu = new DataTable();
            adapter = new SqlDataAdapter("select * from CHUCVU", dB.GetConnection());
            adapter.Fill(dt_chucvu);
        }
        public List<DTO_ChucVu> getAll()
        {
            List<DTO_ChucVu> lst = new List<DTO_ChucVu>();
            foreach (DataRow row in dt_chucvu.Rows)
            {
                DTO_ChucVu chucVu = new DTO_ChucVu(row["MaCV"].ToString(), row["TenCV"].ToString());
                lst.Add(chucVu);
            }
            return lst;
        }
    }
}
