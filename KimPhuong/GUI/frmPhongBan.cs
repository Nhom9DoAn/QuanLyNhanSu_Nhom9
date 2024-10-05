using KimPhuong.BUL;
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

namespace KimPhuong
{
    public partial class frmPhongBan : UIPage
    {
        bool them, xoa, sua, tim = false;

        private void dgvPhongBan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvPhongBan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgvPhongBan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgvPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhongBan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhongBan.SelectedRows[0];
                string maPB = selectedRow.Cells["MaPB"].Value.ToString();
                string tenPB = selectedRow.Cells["TenPB"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string sodienThoai = selectedRow.Cells["SoDienThoai"].Value.ToString();

                txtMaPhongBan.Text = maPB;
                txtTenPhongBan.Text = tenPB;
                txtDiaChi.Text = diaChi;
                txtSDT.Text = sodienThoai;
                txtTongNV.Text = phongBanBUL.tinhTongNhanVienTrongPhongBan(maPB).ToString();

            }
        }

        PhongBanBUL phongBanBUL;
        PhongBanDTO phongBanDTO;

        private void dgvPhongBan_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvPhongBan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhongBan.SelectedRows[0];
                string maPB = selectedRow.Cells["MaPB"].Value.ToString();
                string tenPB = selectedRow.Cells["TenPB"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string sodienThoai = selectedRow.Cells["SoDienThoai"].Value.ToString();

                txtMaPhongBan.Text = maPB;
                txtTenPhongBan.Text = tenPB;
                txtDiaChi.Text = diaChi;
                txtSDT.Text = sodienThoai;
                txtTongNV.Text = phongBanBUL.tinhTongNhanVienTrongPhongBan(maPB).ToString();

            }
        }

        public frmPhongBan()
        {
            InitializeComponent();
            phongBanBUL = new PhongBanBUL();
            LoadData();
        }
        private void LoadData()
        {
            dgvPhongBan.DataSource = null;
            phongBanBUL = new PhongBanBUL();
            dgvPhongBan.DataSource = phongBanBUL.getAll();

            dgvPhongBan.Columns["MaPB"].HeaderText = "Mã Phòng Ban";
            dgvPhongBan.Columns["TenPB"].HeaderText = "Tên Phòng Ban";
            dgvPhongBan.Columns["DiaChi"].HeaderText = "Địa Chỉ Phòng Ban";
            dgvPhongBan.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại Phòng Ban";
        }

        private void menucontrol1_ButtonClicked(object sender, DynamicControl.menucontrol.ButtonType buttonType, EventArgs e)
        {
            string ma = txtMaPhongBan.Text.Trim();

            switch (buttonType)
            {
                case DynamicControl.menucontrol.ButtonType.Add:
                    them = true;
                    txtMaPhongBan.Enabled = txtTenPhongBan.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = true;
                    txtMaPhongBan.Text = txtTenPhongBan.Text = txtSDT.Text = txtDiaChi.Text = "";
                    txtMaPhongBan.Focus();
                    break;
                case DynamicControl.menucontrol.ButtonType.Edit:
                    sua = true;
                    txtTenPhongBan.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = true;
                    txtTenPhongBan.Focus();
                    break;
                case DynamicControl.menucontrol.ButtonType.Search:
                    tim = true;
                    txtMaPhongBan.Enabled = txtTenPhongBan.Enabled = true;
                    txtMaPhongBan.Text = txtTenPhongBan.Text = txtSDT.Text = txtDiaChi.Text = "";
                    txtMaPhongBan.Focus();
                    break;
                case DynamicControl.menucontrol.ButtonType.Delete:
                    if (dgvPhongBan.SelectedRows.Count > 0)
                    {

                        DialogResult result = MessageBox.Show("Bạn có xác nhận xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            DataGridViewRow selectedRow = dgvPhongBan.SelectedRows[0];
                            string maPB = selectedRow.Cells["MaPB"].Value.ToString();
                            int sonv = phongBanBUL.tinhTongNhanVienTrongPhongBan(maPB);
                            if (sonv > 0)
                            {
                                MessageBox.Show("Có nhân viên thuộc phòng ban này nên không thể xóa", "Thông báo", MessageBoxButtons.OK);
                                break;
                            }
                            PhongBanDTO phongBanDTO = new PhongBanDTO();
                            phongBanDTO.MaPB = maPB;
                            bool kq = phongBanBUL.delete(phongBanDTO);
                            if (kq == true)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công");
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case DynamicControl.menucontrol.ButtonType.Cancel:
                    txtMaPhongBan.Enabled = txtTenPhongBan.Enabled = txtSDT.Enabled = false;
                    break;
                case DynamicControl.menucontrol.ButtonType.Save:
                    if (them)
                    {
                        if (!string.IsNullOrEmpty(txtMaPhongBan.Text) || !string.IsNullOrEmpty(txtTenPhongBan.Text))
                        {
                            PhongBanDTO phongBanDTO = new PhongBanDTO(txtMaPhongBan.Text, txtTenPhongBan.Text, txtDiaChi.Text, txtSDT.Text);
                            if (phongBanBUL.insert(phongBanDTO))
                            {
                                LoadData();
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                them = !them;
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hãy nhập đầy đủ mã và tên phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (sua)
                    {
                        PhongBanDTO phongBanDTO = new PhongBanDTO(txtMaPhongBan.Text, txtTenPhongBan.Text, txtDiaChi.Text, txtSDT.Text);
                        if (phongBanBUL.update(phongBanDTO))
                        {
                            LoadData();
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sua = !sua;
                        }
                    }
                    else if (tim)
                    {
                        string maPB = txtMaPhongBan.Text.Trim();
                        string tenPB = txtTenPhongBan.Text.Trim();

                        dgvPhongBan.DataSource = null;

                        List<PhongBanDTO> result = phongBanBUL.searchLinq(maPB, tenPB);

                        dgvPhongBan.DataSource = result;

                        if (result.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        txtMaPhongBan.Enabled = txtTenPhongBan.Enabled = txtSDT.Enabled = false;
                        tim = !tim;
                    }
                    break;
                case DynamicControl.menucontrol.ButtonType.Reload:
                    LoadData();
                    txtMaPhongBan.Enabled = txtTenPhongBan.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = false;
                    break;

                case DynamicControl.menucontrol.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }
    }
}
