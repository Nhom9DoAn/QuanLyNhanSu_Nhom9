using KimPhuong.BUL;
using KimPhuong.BUS;
using KimPhuong.DAL;
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
    public partial class frmHocVanBangCap : UIPage
    {
        HocVanBangCapBUS hocVanBUS;
        NhanVienBUS nhanVienBUS;
        bool them, xoa, sua, tim, loc = false;

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
        private bool ValidateInput()
        {
            if (cboMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbBangCap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại bằng cấp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiemTB.Text) || string.IsNullOrWhiteSpace(txtTenTruong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ điểm trung bình và tên trường", "Thông báo",
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
                    txtTenTruong.Enabled = txtChuyenNganh.Enabled = cbBangCap.Enabled =
                    txtNamTotNghiep.Enabled = txtDiemTB.Enabled = txtGhiChu.Enabled = true;
                    cboMaNV.Enabled = true;
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgvHocVan.SelectedRows.Count > 0)
                    {
                        sua = true;
                        txtTenTruong.Enabled = txtChuyenNganh.Enabled = cbBangCap.Enabled =
                        txtNamTotNghiep.Enabled = txtDiemTB.Enabled = txtGhiChu.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Delete:
                    if (dgvHocVan.SelectedRows.Count > 0)
                    {
                        if (MessageBox.Show("Bạn có chắc muốn xóa " + dgvHocVan.SelectedRows.Count + " dòng đã chọn?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool hasError = false;
                            foreach (DataGridViewRow row in dgvHocVan.SelectedRows)
                            {
                                int maHVBC = Convert.ToInt32(row.Cells["MaHVBC"].Value);
                                if (!hocVanBUS.Delete(maHVBC))
                                {
                                    hasError = true;
                                    MessageBox.Show("Xóa thất bại mã học vấn: " + maHVBC,
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
                        if (hocVanBUS.Insert(
                            Convert.ToInt32(cboMaNV.SelectedValue),
                            txtTenTruong.Text,
                            txtChuyenNganh.Text,
                            cbBangCap.Text,
                            Convert.ToInt32(txtNamTotNghiep.Text),
                            Convert.ToDouble(txtDiemTB.Text),
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
                        if (hocVanBUS.Update(
                            Convert.ToInt32(dgvHocVan.SelectedRows[0].Cells["MaHVBC"].Value),
                            txtTenTruong.Text,
                            txtChuyenNganh.Text,
                            cbBangCap.Text,
                            Convert.ToInt32(txtNamTotNghiep.Text),
                            Convert.ToDouble(txtDiemTB.Text),
                            txtGhiChu.Text))
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
                    else if (loc)
                    {
                        int maNV = 0;
                        if (cboMaNV.SelectedValue != null)
                        {
                            maNV = (int) cboMaNV.SelectedValue;
                        }

                        var ketQua = hocVanBUS.GetByNhanVien(
                            maNV);

                        dgvHocVan.DataSource = ketQua.Select(hv => new
                        {
                            hv.MaHVBC,
                            hv.MaNV,
                            hv.TenTruong,
                            hv.ChuyenNganh,
                            hv.BangCap,
                            hv.NamTotNghiep,
                            hv.DiemTB,
                            hv.GhiChu
                        }).ToList();

                        dgvHocVan.Columns["MaHVBC"].HeaderText = "Mã học vấn/bằng cấp";
                        dgvHocVan.Columns["MaNV"].HeaderText = "Mã nhân viên";
                        dgvHocVan.Columns["TenTruong"].HeaderText = "Tên trường";
                        dgvHocVan.Columns["ChuyenNganh"].HeaderText = "Chuyên ngành";
                        dgvHocVan.Columns["BangCap"].HeaderText = "Bằng cấp";
                        dgvHocVan.Columns["NamTotNghiep"].HeaderText = "Năm tốt nghiệp";
                        dgvHocVan.Columns["DiemTB"].HeaderText = "Điểm trung bình";
                        dgvHocVan.Columns["GhiChu"].HeaderText = "Ghi chú";

                        loc = false;
                        loaddisable();
                        menucontrol.SetStatus(DynamicControl.menucontrol2.Status.View);
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:
                    txtTenTruong.Enabled = txtChuyenNganh.Enabled = cbBangCap.Enabled =
                    txtNamTotNghiep.Enabled = txtDiemTB.Enabled = txtGhiChu.Enabled = false;
                    cboMaNV.Enabled = false;
                    them = sua = tim = false;
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

        private void dgvHocVan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocVan.SelectedRows.Count > 0)
            {

                DataGridViewRow selected = dgvHocVan.SelectedRows[0];

                txtMaHV.Text = selected.Cells["MaHVBC"].Value?.ToString() ?? "";
                cboMaNV.SelectedValue = selected.Cells["MaNV"].Value;
                txtTenTruong.Text = selected.Cells["TenTruong"].Value?.ToString() ?? "";
                txtChuyenNganh.Text = selected.Cells["ChuyenNganh"].Value?.ToString() ?? "";
                cbBangCap.Text = selected.Cells["BangCap"].Value?.ToString() ?? "";

                if (selected.Cells["NamTotNghiep"].Value != null)
                {
                    txtNamTotNghiep.Text = selected.Cells["NamTotNghiep"].Value?.ToString() ?? "";
                }

                if (selected.Cells["DiemTB"].Value != null)
                {
                    txtDiemTB.Text = selected.Cells["DiemTB"].Value?.ToString() ?? "";
                }
                if (selected.Cells["MaNV"].Value != null)
                {
                    cboMaNV.Text = selected.Cells["MaNV"].Value?.ToString() ?? "";
                }

                txtGhiChu.Text = selected.Cells["GhiChu"].Value?.ToString() ?? "";
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = hocVanBUS.Search(keyword);
            if (results.Any())
            {
                dgvHocVan.DataSource = results;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHocVan.DataSource = null;
            }
        }

        private void dgvHocVan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvHocVan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgvHocVan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void frmHocVanBangCap_Load(object sender, EventArgs e)
        {
            LoadData();
            loaddisable();
            LoadCombobox();
        }

        public frmHocVanBangCap()
        {
            InitializeComponent();
            hocVanBUS = new HocVanBangCapBUS();
            nhanVienBUS = new NhanVienBUS();
            LoadData();
            loaddisable();
            LoadCombobox();
        }

        private void loadenable()
        {
            txtMaHV.Enabled = txtTenTruong.Enabled = txtChuyenNganh.Enabled = cbBangCap.Enabled = txtNamTotNghiep.Enabled = txtDiemTB.Enabled = txtGhiChu.Enabled = cboMaNV.Enabled = dtpNgaySinh.Enabled = true;
        }
        private void loaddisable()
        {
            txtMaHV.Enabled = txtTenTruong.Enabled = txtChuyenNganh.Enabled = cbBangCap.Enabled = txtNamTotNghiep.Enabled = txtDiemTB.Enabled = txtGhiChu.Enabled = cboMaNV.Enabled = dtpNgaySinh.Enabled = false;
        }
        private void LoadData()
        {
            dgvHocVan.DataSource = hocVanBUS.GetAll();

            dgvHocVan.Columns["MaHVBC"].HeaderText = "Mã học vấn/bằng cấp";
            dgvHocVan.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvHocVan.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvHocVan.Columns["TenTruong"].HeaderText = "Tên trường";
            dgvHocVan.Columns["ChuyenNganh"].HeaderText = "Chuyên ngành";
            dgvHocVan.Columns["BangCap"].HeaderText = "Bằng cấp";
            dgvHocVan.Columns["NamTotNghiep"].HeaderText = "Năm tốt nghiệp";
            dgvHocVan.Columns["DiemTB"].HeaderText = "D9iểm trung bình";
            dgvHocVan.Columns["GhiChu"].HeaderText = "Ghi chú";
        }
    }
}
