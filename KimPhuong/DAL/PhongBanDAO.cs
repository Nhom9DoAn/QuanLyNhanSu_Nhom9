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
        public bool insert(PhongBanDTO phongBan)
        {
            DataRow newRow = dt_phongban.NewRow();
            newRow["MaPB"] = phongBan.MaPB;
            newRow["TenPB"] = phongBan.TenPB;
            newRow["DiaChi"] = phongBan.DiaChi;
            newRow["SDTPB"] = phongBan.SoDienThoai;
            dt_phongban.Rows.Add(newRow);

            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            int kq = adapter.Update(dt_phongban);
            if (kq != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool delete(PhongBanDTO phongBan)
        {
            DataRow[] deleteRow = dt_phongban.Select("MaPB = '" + phongBan.MaPB + "'");
            foreach (DataRow row in deleteRow)
            {
                row.Delete();
            }

            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            int kq = adapter.Update(dt_phongban);

            if (kq != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool update(PhongBanDTO phongBan)
        {
            DataRow updateRow = dt_phongban.Select("MaPB = '" + phongBan.MaPB + "'").FirstOrDefault();

            if (updateRow != null)
            {
                updateRow["TenPB"] = phongBan.TenPB;
                updateRow["DiaChi"] = phongBan.DiaChi;
                updateRow["SDTPB"] = phongBan.SoDienThoai;

                SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
                int kq = adapter.Update(dt_phongban);
                return kq != 0;
            }
            return false;
        }
        public int tinhTongNhanVienTrongPhongBan(string maPB)
        {
            int soNhanVien = 0;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NHANVIEN WHERE MaPB = @MaPB", dB.GetConnection());
            cmd.Parameters.AddWithValue("@MaPB", maPB);
            soNhanVien = (int) cmd.ExecuteScalar();
            return soNhanVien;
        }
        public List<PhongBanDTO> searchLinq(string maPB, string tenPB)
        {
            var query = this.getAll().AsQueryable();

            if (!string.IsNullOrEmpty(maPB))
            {
                query = query.Where(pb => pb.MaPB.ToLower().Contains(maPB.ToLower()));
            }
            if (!string.IsNullOrEmpty(tenPB))
            {
                query = query.Where(pb => pb.TenPB.ToLower().Contains(tenPB.ToLower()));
            }
            return query.ToList();
        }


    }

}
