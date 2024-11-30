using KimPhuong.BUL;
using KimPhuong.BUS;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimPhuong.GUI
{
    public partial class frmLichSuPhongBan : UIPage
    {
        LichSuPhongBanBUS lichSuPhongBanBUS;
        NhanVienBUS nhanVienBUS;
        public frmLichSuPhongBan()
        {
            lichSuPhongBanBUS = new LichSuPhongBanBUS();
            nhanVienBUS = new NhanVienBUS();
            InitializeComponent();
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            var dsHienThi = new List<dynamic>()
    {
        new { MaNV = 0, Display = "Tất cả" }
    };

            var dsNhanVien = nhanVienBUS.GetAll();
            foreach (var nv in dsNhanVien)
            {
                dsHienThi.Add(new { MaNV = nv.MaNV, Display = nv.MaNV.ToString() });
            }

            cboMaNV.DataSource = dsHienThi;
            cboMaNV.DisplayMember = "Display";
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.SelectedIndex = 0;

        }
        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMaNV.SelectedItem == null) return;

                dynamic selected = cboMaNV.SelectedItem;
                int maNV = selected.MaNV;

                if (maNV == 0)
                {
                    txtTenNV.Clear();
                    dtpNgaySinh.Value = DateTime.Now;
                    txtSDT.Clear();
                    txtChucVu.Clear();
                }

                var nv = nhanVienBUS.GetByID(maNV);
                if (nv != null)
                {
                    txtTenNV.Text = nv.HoTen;
                    dtpNgaySinh.Value = nv.NgaySinh ?? DateTime.Now;
                    txtSDT.Text = nv.DienThoai;
                    txtChucVu.Text = nhanVienBUS.GetChucVuName(nv.MaNV);
                }
                LoadLichSuPhongBan(maNV);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý thông tin nhân viên: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadLichSuPhongBan(int maNV)
        {
            try
            {
                if (maNV == 0)
                {
                    dgvLichSuPhongBan.DataSource = lichSuPhongBanBUS.GetAll();
                }
                else
                {
                    dgvLichSuPhongBan.DataSource = lichSuPhongBanBUS.GetLichSuByNhanVien(maNV);
                }
                if (dgvLichSuPhongBan.Columns.Count > 0)
                {
                    dgvLichSuPhongBan.Columns["MaNV"].HeaderText = "Mã nhân viên";
                    dgvLichSuPhongBan.Columns["MaLichSu"].HeaderText = "Mã lịch sử";
                    dgvLichSuPhongBan.Columns["MaPB"].HeaderText = "Mã phòng ban";
                    dgvLichSuPhongBan.Columns["NgayChuyen"].HeaderText = "Ngày chuyển";
                    dgvLichSuPhongBan.Columns["GhiChu"].HeaderText = "Ghi chú";
                    dgvLichSuPhongBan.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                    dgvLichSuPhongBan.Columns["TenPhongBan"].HeaderText = "Tên phòng ban"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lịch sử phòng ban: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLichSuPhongBan_SizeChanged(object sender, EventArgs e)
        {

        }

        private void dgvLichSuPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLichSuPhongBan.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgvLichSuPhongBan.SelectedRows[0];

                txtMaNP.Text = selected.Cells["MaLichSu"].Value.ToString();
                dtpNgayChuyen.Value = Convert.ToDateTime(selected.Cells["NgayChuyen"].Value.ToString());
                txtGhiChu.Text = selected.Cells["GhiChu"].Value?.ToString() ?? "";

                int mapb = Convert.ToInt32(selected.Cells["MaPB"].Value.ToString());
                txtTenPhongBan.Text = lichSuPhongBanBUS.GetTenPhongBan(mapb);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text;
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = lichSuPhongBanBUS.Search(keyword);
            if (results.Any())
            {
                dgvLichSuPhongBan.AutoGenerateColumns = true;
                dgvLichSuPhongBan.DataSource = results;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLichSuPhongBan.DataSource = null;
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void dgvLichSuPhongBan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvLichSuPhongBan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgvLichSuPhongBan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
