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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KimPhuong.GUI
{
    public partial class frmChuyenPhongBan : UIPage
    {
        static string TENNV;
        bool them, sua, loc = false;
        NhanVienBUS nhanVienBUS;
        ChuyenPhongBanBUS chuyenPhongBanBUS;
        PhongBanBUL phongBanBUL;
        public frmChuyenPhongBan(string tennv)
        {
            chuyenPhongBanBUS = new ChuyenPhongBanBUS();
            nhanVienBUS = new NhanVienBUS();
            phongBanBUL = new PhongBanBUL();
            InitializeComponent();
            LoadCombobox();
            loadPhongBanMoi();
            LoadData();
            TENNV = tennv;
            txtNguoiTao.Text = TENNV;
            loaddisable();
            cboMaNV.SelectedIndexChanged += cboMaNV_SelectedIndexChanged;

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
        private void loadPhongBanMoi()
        {

            var dspb = phongBanBUL.getAll();


            cbPhongBanMoi.DataSource = dspb;
            cbPhongBanMoi.DisplayMember = "TenPB";
            cbPhongBanMoi.ValueMember = "MaPB";
            
        }

        private void loaddisable()
        {
            cboMaNV.Enabled = cbPhongBanMoi.Enabled = txtNguoiTao.Enabled = dtpNgayTao.Enabled = dtpNgayHieuLuc.Enabled = txtLyDo.Enabled = radDaDuyet.Enabled = radDaHuy.Enabled = radDangCho.Enabled = dtpNgayCapNhat.Enabled = cbNguoiDuyet.Enabled = txtGhiChu.Enabled = false;

        }
        private void loadenable()
        {
            cboMaNV.Enabled = cbPhongBanMoi.Enabled = txtNguoiTao.Enabled = dtpNgayTao.Enabled = dtpNgayHieuLuc.Enabled = txtLyDo.Enabled = radDaDuyet.Enabled = radDaHuy.Enabled = radDangCho.Enabled = dtpNgayCapNhat.Enabled = cbNguoiDuyet.Enabled = txtGhiChu.Enabled = true;

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
                    txtTenNV.Text = "";
                    dtpNgaySinh.Value = DateTime.Now;
                    txtSDT.Text = "";
                    txtChucVu.Text = "";
                    txtPhongBan.Text = "";
                    return;
                }

                var nv = nhanVienBUS.GetByID(maNV);
                if (nv != null)
                {
                    txtTenNV.Text = nv.HoTen;
                    dtpNgaySinh.Value = nv.NgaySinh ?? DateTime.Now;
                    txtSDT.Text = nv.DienThoai;
                    txtChucVu.Text = nhanVienBUS.GetChucVuName(nv.MaNV);
                    if (txtPhongBan.Text != nhanVienBUS.GetPhongBanName(nv.MaNV))
                    {
                        txtPhongBan.Text = nhanVienBUS.GetPhongBanName(nv.MaNV);
                    }
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
            dgvChuyenPhongBan.DataSource = null;
            dgvChuyenPhongBan.DataSource = chuyenPhongBanBUS.GetAll();

            if (dgvChuyenPhongBan.Rows.Count > 0)
            {
                dgvChuyenPhongBan.Columns["MaChuyenPB"].HeaderText = "Mã chuyển phòng ban";
                dgvChuyenPhongBan.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dgvChuyenPhongBan.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                dgvChuyenPhongBan.Columns["MaPB_Cu"].HeaderText = "Mã phòng ban cũ";
                dgvChuyenPhongBan.Columns["TenPhongBanCu"].HeaderText = "Tên phòng ban cũ";
                dgvChuyenPhongBan.Columns["MaPB_Moi"].HeaderText = "Mã phòng ban mới";
                dgvChuyenPhongBan.Columns["TenPhongBanMoi"].HeaderText = "Tên phòng ban mới";
                dgvChuyenPhongBan.Columns["NgayHieuLuc"].HeaderText = "Ngày hiệu lực";
                dgvChuyenPhongBan.Columns["NgayTao"].HeaderText = "Ngày tạo";
                dgvChuyenPhongBan.Columns["NguoiTao"].HeaderText = "Người tạo";
                dgvChuyenPhongBan.Columns["LyDoChuyen"].HeaderText = "Lý do chuyển";
                dgvChuyenPhongBan.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvChuyenPhongBan.Columns["NgayCapNhatTrangThai"].HeaderText = "Ngày cập nhật trạng thái";
                dgvChuyenPhongBan.Columns["NguoiDuyet"].HeaderText = "Người duyệt";
                dgvChuyenPhongBan.Columns["GhiChuDuyet"].HeaderText = "Ghi chú duyệt";
            }

        }

        private void dgvChuyenPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChuyenPhongBan.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgvChuyenPhongBan.SelectedRows[0];

                cboMaNV.SelectedValue = selected.Cells["MaNV"].Value;
                cbPhongBanMoi.SelectedValue = selected.Cells["MaPB_Moi"].Value;
                txtNguoiTao.Text = selected.Cells["NguoiTao"].Value?.ToString() ?? "";
                dtpNgayTao.Value = Convert.ToDateTime(selected.Cells["NgayTao"].Value.ToString());
                dtpNgayHieuLuc.Value = Convert.ToDateTime(selected.Cells["NgayHieuLuc"].Value.ToString());
                txtLyDo.Text = selected.Cells["LyDoChuyen"].Value?.ToString() ?? "";
                string trangThai = selected.Cells["TrangThai"].Value?.ToString() ?? "";
                if (trangThai == "Đã duyệt")
                    radDaDuyet.Checked = true;
                else if (trangThai == "Đã hủy")
                    radDaHuy.Checked = true;
                else
                    radDangCho.Checked = true;
                dtpNgayCapNhat.Value = Convert.ToDateTime(selected.Cells["NgayCapNhatTrangThai"].Value?.ToString() ?? "");
                cbNguoiDuyet.Text = selected.Cells["NguoiDuyet"].Value.ToString();
                txtGhiChu.Text = selected.Cells["GhiChuDuyet"].Value?.ToString() ?? "";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();
            var results = chuyenPhongBanBUS.Search(keyword);
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (results.Any())
            {
                dgvChuyenPhongBan.DataSource = results;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmChuyenPhongBan_Load(object sender, EventArgs e)
        {
            loadPhongBanMoi();
            LoadData();
            txtNguoiTao.Text = TENNV;
            loaddisable();
            cboMaNV.SelectedIndexChanged += cboMaNV_SelectedIndexChanged;

        }

        private bool ValidateInput()
        {
            if (cboMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(dtpNgayHieuLuc.Value < dtpNgayTao.Value)
            {
                MessageBox.Show("Ngày có hiệu lực phải bắt đầu từ ngày hôm nay trở đi!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbNguoiDuyet.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn người duyệt!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(string.IsNullOrEmpty(txtLyDo.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập lí do chuyển!", "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void menucontrol_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol2.ButtonType.Add:
                    them = true;
                    loadenable();
                    txtNguoiTao.Enabled = dtpNgayCapNhat.Enabled = dtpNgayTao.Enabled = radDaDuyet.Enabled = radDangCho.Enabled = radDaHuy.Enabled = false;
                    txtNguoiTao.Enabled = false;
                    txtNguoiTao.Text = TENNV;
                    radDangCho.Checked = true;
                    dtpNgayTao.Value = DateTime.UtcNow;
                    dtpNgayCapNhat.Value = DateTime.UtcNow;
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgvChuyenPhongBan.SelectedRows.Count > 0)
                    {
                        if (radDangCho.Checked)
                        {
                            sua = true;
                            loaddisable();
                            dtpNgayHieuLuc.Enabled = cbNguoiDuyet.Enabled = txtGhiChu.Enabled = true;
                            txtLyDo.Enabled = radDaDuyet.Enabled = radDaHuy.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa khi đã xác nhận!", "Thông báo");
                            loaddisable();
                            menucontrol.SetStatus(DynamicControl.menucontrol2.Status.View);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Delete:
                    if (dgvChuyenPhongBan.SelectedRows.Count > 0)
                    {
                        if (!radDaHuy.Checked)
                        {
                            MessageBox.Show("Chỉ có thể xóa khi trạng thái là đã hủy", "Thông báo");
                            return;
                        }
                        if (MessageBox.Show("Bạn có chắc muốn xóa " + dgvChuyenPhongBan.SelectedRows.Count + " dòng đã chọn?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool hasError = false;
                            foreach (DataGridViewRow row in dgvChuyenPhongBan.SelectedRows)
                            {
                                int machuyen = Convert.ToInt32(row.Cells["MaChuyenPB"].Value);
                                if (!chuyenPhongBanBUS.Delete(machuyen))
                                {
                                    hasError = true;
                                    MessageBox.Show("Xóa thất bại mã chuyển phòng ban: " + machuyen,
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            if (!hasError)
                            {
                                MessageBox.Show("Xóa thành công tất cả dòng đã chọn!", "Thông báo");
                            }
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn dữ liệu", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Save:
                    if (!ValidateInput())
                    {
                        menucontrol.SetStatus(DynamicControl.menucontrol2.Status.Edit);
                        return;
                    }

                    if (them)
                    {
                        int manv = Convert.ToInt32(cboMaNV.SelectedValue);
                        int mapbcu = nhanVienBUS.GetPhongBanID(manv);
                        if (chuyenPhongBanBUS.Insert(
                            manv,
                            mapbcu,
                            Convert.ToInt32(cbPhongBanMoi.SelectedValue),
                            dtpNgayHieuLuc.Value,
                            txtNguoiTao.Text,
                            txtLyDo.Text,
                            "Đang chờ",
                            dtpNgayCapNhat.Value,
                            cbNguoiDuyet.SelectedItem.ToString(),
                            txtGhiChu.Text))
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo");
                            LoadData();
                            them = false;
                            loaddisable();
                            menucontrol.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (sua)
                    {
                        string trangThai = "";
                        if (radDangCho.Checked)
                        {
                            trangThai = "Đang chờ";
                        }
                        else if (radDaDuyet.Checked)
                        {
                            trangThai = "Đã duyệt";
                        }
                        else if (radDaHuy.Checked)
                        {
                            trangThai = "Đã hủy";
                        }

                        if (chuyenPhongBanBUS.Update(
                            Convert.ToInt32(dgvChuyenPhongBan.SelectedRows[0].Cells["MaChuyenPB"].Value),
                            dtpNgayHieuLuc.Value,
                            trangThai,
                            cbNguoiDuyet.Text,
                            txtGhiChu.Text))
                        {
                            if (trangThai == "Đã duyệt")
                            {
                                int nv = Convert.ToInt32(cboMaNV.SelectedValue);
                                int pbmoi = Convert.ToInt32(cbPhongBanMoi.SelectedValue);
                                bool kq = chuyenPhongBanBUS.updatePhongBan(nv, pbmoi);
                                if (kq)
                                {
                                    MessageBox.Show("Đã đổi phỏng ban cho nhân viên thành công!", "Thông báo");
                                }
                            }
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            LoadData();
                            LoadCombobox();
                            sua = false;
                            loaddisable();
                            menucontrol.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (loc)
                    {
                        int maNV = 0;
                        if (cboMaNV.SelectedValue != null)
                        {
                            maNV = (int) cboMaNV.SelectedValue;
                        }

                        var ketQua = chuyenPhongBanBUS.GetByNhanVien(
                            maNV);

                        dgvChuyenPhongBan.DataSource = ketQua;

                        if (dgvChuyenPhongBan.Rows.Count > 0)
                        {
                            dgvChuyenPhongBan.Columns["MaChuyenPB"].HeaderText = "Mã chuyển phòng ban";
                            dgvChuyenPhongBan.Columns["MaNV"].HeaderText = "Mã nhân viên";
                            dgvChuyenPhongBan.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                            dgvChuyenPhongBan.Columns["MaPB_Cu"].HeaderText = "Mã phòng ban cũ";
                            dgvChuyenPhongBan.Columns["TenPhongBanCu"].HeaderText = "Tên phòng ban cũ";
                            dgvChuyenPhongBan.Columns["MaPB_Moi"].HeaderText = "Mã phòng ban mới";
                            dgvChuyenPhongBan.Columns["TenPhongBanMoi"].HeaderText = "Tên phòng ban mới";
                            dgvChuyenPhongBan.Columns["NgayHieuLuc"].HeaderText = "Ngày hiệu lực";
                            dgvChuyenPhongBan.Columns["NgayTao"].HeaderText = "Ngày tạo";
                            dgvChuyenPhongBan.Columns["NguoiTao"].HeaderText = "Người tạo";
                            dgvChuyenPhongBan.Columns["LyDoChuyen"].HeaderText = "Lý do chuyển";
                            dgvChuyenPhongBan.Columns["TrangThai"].HeaderText = "Trạng thái";
                            dgvChuyenPhongBan.Columns["NgayCapNhatTrangThai"].HeaderText = "Ngày cập nhật trạng thái";
                            dgvChuyenPhongBan.Columns["NguoiDuyet"].HeaderText = "Người duyệt";
                            dgvChuyenPhongBan.Columns["GhiChuDuyet"].HeaderText = "Ghi chú duyệt";
                        }

                        loc = false;
                        loaddisable();
                        menucontrol.SetStatus(DynamicControl.menucontrol2.Status.View);
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:
                    loaddisable();
                    them = sua = false;
                    LoadData();
                    loaddisable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Reload:
                    LoadData();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Exit:
                    Application.Exit();
                    break;
                case DynamicControl.menucontrol2.ButtonType.Loc:
                    cboMaNV.Enabled = true;
                    loc = true;
                    break;
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
