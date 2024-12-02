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
    public partial class frmChuyenPhongBan : UIPage
    {
        NhanVienBUS nhanVienBUS;
        ChuyenPhongBanBUS chuyenPhongBanBUS;
        PhongBanBUL phongBanBUL = new PhongBanBUL();
        public frmChuyenPhongBan()
        {
            chuyenPhongBanBUS = new ChuyenPhongBanBUS();
            nhanVienBUS = new NhanVienBUS();
            InitializeComponent();
            LoadCombobox();
            LoadData();
            loadPhongBan();
        }

        private void loadPhongBan()
        {
            cbPhongBan.DataSource = null;

            var phongBan = phongBanBUL.getAll();
            cbPhongBan.DataSource = phongBan;
            cbPhongBan.ValueMember = "TenPB";
            cbPhongBan.DisplayMember = "MaPB";
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
                    return;
                }

                var nv = nhanVienBUS.GetByID(maNV);
                if (nv != null)
                {
                    txtTenNV.Text = nv.HoTen;
                    dtpNgaySinh.Value = nv.NgaySinh ?? DateTime.Now;
                    txtSDT.Text = nv.DienThoai;
                    txtChucVu.Text = nhanVienBUS.GetChucVuName(nv.MaNV);
                    cbPhongBan.SelectedValue = nv.MaPB;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý thông tin nhân viên: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            dgvChuyenPhongBan.DataSource = chuyenPhongBanBUS.GetAll().Select(np => new
            {
                np.MaChuyenPB,
                np.MaNV,
                np.MaPB_Cu,
                np.MaPB_Moi,
                np.NgayHieuLuc,
                np.NgayTao,
                np.NguoiTao,
                np.LyDoChuyen,
                np.TrangThai,
                np.NgayCapNhatTrangThai,
                np.NguoiDuyet,
                np.GhiChuDuyet
            }).ToList();

            dgvChuyenPhongBan.Columns["MaChuyenPB"].HeaderText = "Mã chuyển phòng ban";
            dgvChuyenPhongBan.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvChuyenPhongBan.Columns["MaPB_Cu"].HeaderText = "Mã phòng ban cũ";
            dgvChuyenPhongBan.Columns["MaPB_Moi"].HeaderText = "Mã phòng ban mới";
            dgvChuyenPhongBan.Columns["NgayHieuLuc"].HeaderText = "Ngày hiệu lực";
            dgvChuyenPhongBan.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dgvChuyenPhongBan.Columns["NguoiTao"].HeaderText = "Người tạo";
            dgvChuyenPhongBan.Columns["LyDoChuyen"].HeaderText = "Lý do chuyển";
            dgvChuyenPhongBan.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvChuyenPhongBan.Columns["NgayCapNhatTrangThai"].HeaderText = "Ngày cập nhật trạng thái";
            dgvChuyenPhongBan.Columns["NguoiDuyet"].HeaderText = "Người duyệt";
            dgvChuyenPhongBan.Columns["GhiChuDuyet"].HeaderText = "Ghi chú duyệt";
        }

        private void dgvChuyenPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvChuyenPhongBan.SelectedRows.Count>0)
            {
                DataGridViewRow selected = dgvChuyenPhongBan.SelectedRows[0];

                cboMaNV.SelectedValue = selected.Cells["MaNV"].Value;
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvChuyenPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayTao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtNguoiTao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayHieuLuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtLyDo_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radDaHuy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radDangCho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radDaDuyet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayCapNhat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNguoiDuyet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menucontrol31_Load(object sender, EventArgs e)
        {

        }
    }
}
