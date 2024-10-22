﻿using System;
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
    public class NghiPhepDAO
    {
        DataTable dt_nghiphep;
        SqlDataAdapter adapter;
        private DBConnection dB;
        public NghiPhepDAO()
        {
            dB = new DBConnection();
            dt_nghiphep = new DataTable();
            adapter = new SqlDataAdapter("select * from NGHIPHEP", dB.GetConnection());
            adapter.Fill(dt_nghiphep);
        }
        public List<NghiPhepDTO> getAll()
        {
            List<NghiPhepDTO> lst = new List<NghiPhepDTO>();
            foreach (DataRow row in dt_nghiphep.Rows)
            {
                NghiPhepDTO nghiphep = new NghiPhepDTO(
                    row["MaNP"].ToString(), row["MaNV"].ToString(),
                    Convert.ToDateTime(row["TuNgay"].ToString()), Convert.ToDateTime(row["DenNgay"].ToString()), row["LyDo"].ToString(), row["TinhTrang"].ToString());
                lst.Add(nghiphep);
            }
            return lst;
        }

        public string LayTenNhanVienTheoMa(string maNV)
        {
            dB.Open();
            string tenNV = string.Empty;
            SqlCommand cmd = new SqlCommand("SELECT HoTen FROM NHANVIEN WHERE MaNV = @manv", dB.GetConnection());
            cmd.Parameters.AddWithValue("@manv", maNV);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tenNV = reader["HoTen"].ToString();
            }

            dB.Close();
            return tenNV;
        }
        public string LayNgaySinhNhanVienTheoMa(string maNV)
        {
            dB.Open();
            string ngaySinh = string.Empty;
            SqlCommand cmd = new SqlCommand("SELECT NgaySinh FROM NHANVIEN WHERE MaNV = @manv", dB.GetConnection());
            cmd.Parameters.AddWithValue("@manv", maNV);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                ngaySinh = reader["NgaySinh"].ToString();
            }

            dB.Close();
            return ngaySinh;
        }
        public string LaySDTNhanVienTheoMa(string maNV)
        {
            dB.Open();
            string SDT = string.Empty;
            SqlCommand cmd = new SqlCommand("SELECT SoDienThoai FROM NHANVIEN WHERE MaNV = @manv", dB.GetConnection());
            cmd.Parameters.AddWithValue("@manv", maNV);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                SDT = reader["SoDienThoai"].ToString();
            }

            dB.Close();
            return SDT;
        }
        public string LayTenChucVu(string maNV)
        {
            dB.Open();
            string tenCV = string.Empty;
            SqlCommand cmd = new SqlCommand("SELECT CHUCVU.TenCV FROM NHANVIEN INNER JOIN CHUCVU ON NHANVIEN.MaCV = CHUCVU.MaCV WHERE NHANVIEN.MaNV = @maNV", dB.GetConnection());
            cmd.Parameters.AddWithValue("@maNV", maNV);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tenCV = reader["TenCV"].ToString();
            }

            dB.Close();
            return tenCV;
        }
        public bool delete(NghiPhepDTO nghiPhep)
        {
            DataRow[] deleteRows = dt_nghiphep.Select($"MaNP = '{nghiPhep.MaNP}'");
            foreach (DataRow row in deleteRows)
            {
                row.Delete();
            }
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            int kq = adapter.Update(dt_nghiphep);
            if (kq > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insert(NghiPhepDTO nghiPhep)
        {
            DataRow newRow = dt_nghiphep.NewRow();
            newRow["MaNP"] = nghiPhep.MaNP;
            newRow["MaNV"] = nghiPhep.MaNV;
            newRow["TuNgay"] = nghiPhep.TuNgay;
            newRow["DenNgay"] = nghiPhep.DenNgay;
            newRow["LyDo"] = nghiPhep.LyDo;
            newRow["TinhTrang"] = nghiPhep.TinhTrang;

            dt_nghiphep.Rows.Add(newRow);

            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            int kq = adapter.Update(dt_nghiphep);
            if (kq > 0)
            {
                return true;
            }
            else { return false; }
        }
        public bool KiemTraTrungMa(string maNP)
        {
            dB.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NGHIPHEP WHERE MaNP = @MaNP", dB.GetConnection());
            cmd.Parameters.AddWithValue("@MaNP", maNP);

            int count = (int) cmd.ExecuteScalar();
            if (count > 0)
                return false;
            else
                return true;
        }
        public bool update(NghiPhepDTO nghiPhep)
        {
            string query = "UPDATE NGHIPHEP SET LyDo = @lyDo, TuNgay = @tuNgay, DenNgay = @denNgay, TinhTrang = @tinhTrang" +
                " where MaNP = @maNP";
            SqlCommand cmd = new SqlCommand(query, dB.GetConnection());
            cmd.Parameters.AddWithValue("@maNP", nghiPhep.MaNP);
            cmd.Parameters.AddWithValue("@lyDo", nghiPhep.LyDo);
            cmd.Parameters.AddWithValue("@tuNgay", nghiPhep.TuNgay);
            cmd.Parameters.AddWithValue("@denNgay", nghiPhep.DenNgay);
            cmd.Parameters.AddWithValue("@tinhTrang", nghiPhep.TinhTrang);
            dB.Open();
            int kq = cmd.ExecuteNonQuery();
            dB.Close();
            if (kq > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<NghiPhepDTO> searchLinq(string maNV)
        {
            var query = this.getAll().AsQueryable();
            if (!string.IsNullOrEmpty(maNV))
            {
                query = query.Where(pb => pb.MaNV.ToLower().Contains(maNV.ToLower()));
            }
            return query.ToList();
        }
    }
}
