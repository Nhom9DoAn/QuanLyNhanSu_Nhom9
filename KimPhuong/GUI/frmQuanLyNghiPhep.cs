using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2;
using KimPhuong.BUL;
using KimPhuong.BUS;
using KimPhuong.DAL;
using KimPhuong.DTO;
using Sunny.UI;

namespace KimPhuong.GUI
{
    public partial class frmQuanLyNghiPhep : UIPage
    {
        NghiPhepBUL nghiPhepBUS;
        NhanVienBUS nhanVienBUS;
        bool them, xoa, sua, tim, loc = false;

        private void dgvNghiPhep_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNghiPhep.SelectedRows.Count > 0)
            {
                var row = dgvNghiPhep.SelectedRows[0];
                txtMaNP.Text = row.Cells["MaNghiPhep"].Value.ToString();
                cboMaNV.SelectedValue = row.Cells["MaNV"].Value;
                dtpTuNgay.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                dtpDenNgay.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
                txtLyDo.Text = row.Cells["LyDo"].Value.ToString();

                string trangThai = row.Cells["TrangThai"].Value.ToString();
                if (trangThai == "Đã duyệt")
                    radDaDuyet.Checked = true;
                else if(trangThai == "Chưa duyệt")
                    radChuaDuyet.Checked = true;
                else
                    radDaTuChoi.Checked = true;
            }
        }

        private void dgvNghiPhep_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvNghiPhep.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgvNghiPhep.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void frmQuanLyNghiPhep_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadData();
            loaddisable();
        }
        private void loadenable()
        {
            txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled = dtpDenNgay.Enabled = dtpTuNgay.Enabled = cboMaNV.Enabled = dtpNgaySinh.Enabled = radChuaDuyet.Enabled = radDaDuyet.Enabled = radDaTuChoi.Enabled = true;
        }
        private void loaddisable()
        {
            txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled = dtpDenNgay.Enabled = dtpTuNgay.Enabled = cboMaNV.Enabled = dtpNgaySinh.Enabled = radChuaDuyet.Enabled = radDaDuyet.Enabled = radDaTuChoi.Enabled = false;
        }
        private void LoadData()
        {
            dgvNghiPhep.DataSource = nghiPhepBUS.GetAll();

            dgvNghiPhep.Columns["MaNghiPhep"].HeaderText = "Mã nghỉ phép";
            dgvNghiPhep.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvNghiPhep.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvNghiPhep.Columns["NgayBatDau"].HeaderText = "Từ ngày";
            dgvNghiPhep.Columns["NgayKetThuc"].HeaderText = "Đến ngày";
            dgvNghiPhep.Columns["TongNgay"].HeaderText = "Tổng ngày";
            dgvNghiPhep.Columns["LyDo"].HeaderText = "Lý do";
            dgvNghiPhep.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private bool ValidateInput()
        {
            if (cboMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpDenNgay.Value < dtpTuNgay.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLyDo.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do nghỉ phép!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void menucontrol_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = nghiPhepBUS.Search(keyword);
            if (results.Any())
            {
                dgvNghiPhep.AutoGenerateColumns = true;
                dgvNghiPhep.DataSource = results;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNghiPhep.DataSource = null;
            }
        }

        private void menucontrol_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol2.ButtonType.Add:
                    them = true;

                    txtLyDo.Enabled = dtpDenNgay.Enabled =
                    dtpTuNgay.Enabled = radChuaDuyet.Checked = true;
                    cboMaNV.Enabled = true;
                    txtSDT.Enabled = false;
                    txtMaNP.Text = txtLyDo.Text = "";
                    txtMaNP.Focus();
                    break;
                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgvNghiPhep.SelectedRows.Count > 0)
                    {
                        sua = true;
                        txtLyDo.Enabled = radChuaDuyet.Enabled = radDaDuyet.Enabled = radDaTuChoi.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Delete:
                    if (dgvNghiPhep.SelectedRows.Count > 0)
                    {
                        if (MessageBox.Show("Bạn có chắc muốn xóa " + dgvNghiPhep.SelectedRows.Count + " dòng đã chọn?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool hasError = false;
                            foreach (DataGridViewRow row in dgvNghiPhep.SelectedRows)
                            {
                                int maNghiPhep = Convert.ToInt32(row.Cells["MaNghiPhep"].Value);
                                if (!nghiPhepBUS.Delete(maNghiPhep))
                                {
                                    hasError = true;
                                    MessageBox.Show("Xóa thất bại mã nghỉ phép: " + maNghiPhep,
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
                        if (nghiPhepBUS.Insert(
                            Convert.ToInt32(cboMaNV.SelectedValue),
                            dtpTuNgay.Value,
                            dtpDenNgay.Value,
                            txtLyDo.Text,
                            "Chưa duyệt"))
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
                        string trangThai;
                        if (radDaDuyet.Checked)
                            trangThai = "Đã duyệt";
                        else if (radChuaDuyet.Checked)
                            trangThai = "Chưa duyệt";
                        else
                            trangThai = "Từ chối";

                        if (nghiPhepBUS.Update(
                            Convert.ToInt32(txtMaNP.Text),
                            dtpTuNgay.Value,
                            dtpDenNgay.Value,
                            txtLyDo.Text,
                            trangThai))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            LoadData();
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
                   
                    else if(loc)
                    {
                        int maNV = 0;
                        if (cboMaNV.SelectedValue != null)
                        {
                            maNV = (int) cboMaNV.SelectedValue;
                        }

                        var ketQua = nghiPhepBUS.GetByNhanVien(
                            maNV);

                        dgvNghiPhep.DataSource = ketQua;

                        dgvNghiPhep.Columns["MaNghiPhep"].HeaderText = "Mã nghỉ phép";
                        dgvNghiPhep.Columns["MaNV"].HeaderText = "Mã nhân viên";
                        dgvNghiPhep.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                        dgvNghiPhep.Columns["NgayBatDau"].HeaderText = "Từ ngày";
                        dgvNghiPhep.Columns["NgayKetThuc"].HeaderText = "Đến ngày";
                        dgvNghiPhep.Columns["TongNgay"].HeaderText = "Tổng ngày";
                        dgvNghiPhep.Columns["LyDo"].HeaderText = "Lý do";
                        dgvNghiPhep.Columns["TrangThai"].HeaderText = "Trạng thái";

                        loc = false;
                        loaddisable();
                        menucontrol.SetStatus(DynamicControl.menucontrol2.Status.View);
                    }

                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:
                    txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled =
                    dtpDenNgay.Enabled = dtpTuNgay.Enabled = cboMaNV.Enabled = false;
                    them = xoa = sua = tim = false;
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
                    cboMaNV.Enabled= true;
                    txtTenNV.Enabled = false;
                    loc = true;
                    break;
            }
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý thông tin nhân viên: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmQuanLyNghiPhep()
        {
            InitializeComponent();
            nghiPhepBUS = new NghiPhepBUL();
            nhanVienBUS = new NhanVienBUS();
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

    }
}
