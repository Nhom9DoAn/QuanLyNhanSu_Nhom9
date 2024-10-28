using KimPhuong.BUL;
using KimPhuong.BUS;
using KimPhuong.DAL;
using KimPhuong.DTO;
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
    public partial class frmNghiPhep : UIPage
    {
        NghiPhepBUL nghiPhepBUS;
        NhanVienBUS nhanVienBUS;
        bool them, xoa, sua, tim = false;

        private void dgvNghiPhep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }
        private void LoadCombobox()
        {
            var dsNhanVien = nhanVienBUS.GetAll();
            cboMaNV.DataSource = dsNhanVien;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.SelectedIndex = -1;
        }

        private void LoadControls()
        { 
        }

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
                else
                    radChuaDuyet.Checked = true;
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMaNV.SelectedItem != null && cboMaNV.SelectedItem is NhanVien nv)
                {
                    txtTenNV.Text = nv.HoTen;
                    dtpNgaySinh.Value = nv.NgaySinh ?? DateTime.Now;
                    txtSDT.Text = nv.DienThoai;
                    txtChucVu.Text = nhanVienBUS.GetChucVuName(nv.MaNV);
                }
                else
                {
                    txtTenNV.Clear();
                    dtpNgaySinh.Value = DateTime.Now;
                    txtSDT.Clear();
                    txtChucVu.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý thông tin nhân viên: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaNP_TextChanged(object sender, EventArgs e)
        {
            
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

        public frmNghiPhep()
        {
            InitializeComponent();
            nghiPhepBUS = new NghiPhepBUL();
            nhanVienBUS = new NhanVienBUS();
            
        }

        private void frmNghiPhep_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadData();
            txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled =
            dtpDenNgay.Enabled = dtpTuNgay.Enabled = cboMaNV.Enabled = false;

        }

        private void LoadData()
        {
            dgvNghiPhep.DataSource = nghiPhepBUS.GetAll().Select(np => new
            {
                np.MaNghiPhep,
                np.MaNV,
                np.NgayBatDau,
                np.NgayKetThuc,
                np.TongNgay,
                np.LyDo,
                np.TrangThai
            }).ToList();

            dgvNghiPhep.Columns["MaNghiPhep"].HeaderText = "Mã nghỉ phép";
            dgvNghiPhep.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvNghiPhep.Columns["NgayBatDau"].HeaderText = "Từ ngày";
            dgvNghiPhep.Columns["NgayKetThuc"].HeaderText = "Đến ngày";
            dgvNghiPhep.Columns["TongNgay"].HeaderText = "Tổng ngày";
            dgvNghiPhep.Columns["LyDo"].HeaderText = "Lý do";
            dgvNghiPhep.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaNP.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nghỉ phép!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

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


        private void menucontrol1_ButtonClicked(object sender, DynamicControl.menucontrol.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol.ButtonType.Add:
                    them = true;
                    txtMaNP.Enabled = txtLyDo.Enabled = dtpDenNgay.Enabled =
                    dtpTuNgay.Enabled = radChuaDuyet.Checked = true;
                    cboMaNV.Enabled = true;
                    txtSDT.Enabled = false;
                    txtMaNP.Text = txtLyDo.Text = "";
                    txtMaNP.Focus();
                    break;
                case DynamicControl.menucontrol.ButtonType.Edit:
                    if (dgvNghiPhep.SelectedRows.Count > 0)
                    {
                        sua = true;
                        txtLyDo.Enabled = radChuaDuyet.Enabled = radDaDuyet.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case DynamicControl.menucontrol.ButtonType.Delete:
                    if (dgvNghiPhep.SelectedRows.Count > 0)
                    {
                        if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int maNghiPhep = Convert.ToInt32(dgvNghiPhep.SelectedRows[0].Cells["MaNghiPhep"].Value);
                            if (nghiPhepBUS.Delete(maNghiPhep))
                            {
                                MessageBox.Show("Xóa thành công!", "Thông báo");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại!", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn dữ liệu", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case DynamicControl.menucontrol.ButtonType.Save:
                    if (ValidateInput())
                    {
                        if (them)
                        {
                            if (nghiPhepBUS.Insert(
                                Convert.ToInt32(cboMaNV.SelectedValue),
                                dtpTuNgay.Value,
                                dtpDenNgay.Value,
                                txtLyDo.Text,
                                radDaDuyet.Checked ? "Đã duyệt" : "Chưa duyệt"))
                            {
                                MessageBox.Show("Thêm thành công!", "Thông báo");
                                LoadData();
                                them = false;
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại!", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (sua)
                        {
                            if (nghiPhepBUS.Update(
                                Convert.ToInt32(txtMaNP.Text),
                                dtpTuNgay.Value,
                                dtpDenNgay.Value,
                                txtLyDo.Text,
                                radDaDuyet.Checked ? "Đã duyệt" : "Chưa duyệt"))
                            {
                                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                                LoadData();
                                sua = false;
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (tim)
                        {
                            int maNV = cboMaNV.SelectedIndex != -1 ?
                                Convert.ToInt32(cboMaNV.SelectedValue) : 0;

                            var ketQua = nghiPhepBUS.Search(
                                maNV,
                                dtpTuNgay.Value,
                                dtpDenNgay.Value,
                                radDaDuyet.Checked ? "Đã duyệt" :
                                radChuaDuyet.Checked ? "Chưa duyệt" : "");

                            dgvNghiPhep.DataSource = ketQua.Select(np => new
                            {
                                np.MaNghiPhep,
                                np.MaNV,
                                np.NgayBatDau,
                                np.NgayKetThuc,
                                np.TongNgay,
                                np.LyDo,
                                np.TrangThai
                            }).ToList();

                            dgvNghiPhep.Columns["MaNghiPhep"].HeaderText = "Mã nghỉ phép";
                            dgvNghiPhep.Columns["MaNV"].HeaderText = "Mã nhân viên";
                            dgvNghiPhep.Columns["NgayBatDau"].HeaderText = "Từ ngày";
                            dgvNghiPhep.Columns["NgayKetThuc"].HeaderText = "Đến ngày";
                            dgvNghiPhep.Columns["TongNgay"].HeaderText = "Tổng ngày";
                            dgvNghiPhep.Columns["LyDo"].HeaderText = "Lý do";
                            dgvNghiPhep.Columns["TrangThai"].HeaderText = "Trạng thái";
                            tim = false;
                        }
                    }
                    break;

                case DynamicControl.menucontrol.ButtonType.Cancel:
                    txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled =
                    dtpDenNgay.Enabled = dtpTuNgay.Enabled = cboMaNV.Enabled = false;
                    them = xoa = sua = tim = false;
                    LoadData();
                    break;

                case DynamicControl.menucontrol.ButtonType.Search:
                    tim = true;
                    cboMaNV.Enabled = dtpTuNgay.Enabled = dtpDenNgay.Enabled =
                    radDaDuyet.Enabled = radChuaDuyet.Enabled = true;
                    break;

                case DynamicControl.menucontrol.ButtonType.Reload:
                    LoadData();
                    txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled =
                    dtpDenNgay.Enabled = dtpTuNgay.Enabled = false;
                    cboMaNV.Enabled = false;
                    break;

                case DynamicControl.menucontrol.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }
    }
}
