using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimPhuong.BUL;
using KimPhuong.DTO;
using Sunny.UI;
namespace KimPhuong.GUI
{
    public partial class frmQuanLyPhongBan : UIPage
    {
        PhongBanBUL phongBanBUL;
        bool them, xoa, sua, tim = false;

        private void dgvPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhongBan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhongBan.SelectedRows[0];
                string maPB = selectedRow.Cells["MaPB"].Value.ToString();
                string tenPB = selectedRow.Cells["TenPB"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string sodienThoai = selectedRow.Cells["SDTPB"].Value.ToString();

                txtMaPhongBan.Text = maPB;
                txtTenPhongBan.Text = tenPB;
                txtDiaChi.Text = diaChi;
                txtSDT.Text = sodienThoai;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtMaPhongBan.Text))
            {
                MessageBox.Show("Mã phòng ban không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhongBan.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTenPhongBan.Text))
            {
                MessageBox.Show("Tên phòng ban không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhongBan.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ phòng ban không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if (txtSDT.Text.Length != 10 || !txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
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
                    txtTenPhongBan.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = true;
                    txtMaPhongBan.Text = txtTenPhongBan.Text = txtDiaChi.Text = txtSDT.Text = "";
                    txtMaPhongBan.Focus();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgvPhongBan.SelectedRows.Count > 0)
                    {
                        sua = true;
                        txtTenPhongBan.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Delete:
                    if (dgvPhongBan.SelectedRows.Count > 0)
                    {
                        if (MessageBox.Show("Bạn có chắc muốn xóa " + dgvPhongBan.SelectedRows.Count + " dòng đã chọn?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool hasError = false;
                            foreach (DataGridViewRow row in dgvPhongBan.SelectedRows)
                            {
                                int maPB = Convert.ToInt32(row.Cells["MaPB"].Value);
                                if (!phongBanBUL.delete(maPB))
                                {
                                    hasError = true;
                                    MessageBox.Show("Xóa thất bại mã phòng ban: " + maPB, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Hãy chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (phongBanBUL.insert(txtTenPhongBan.Text, txtDiaChi.Text, txtSDT.Text))
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo");
                            LoadData();
                            them = false;
                            loaddisable();
                            menucontrol.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (sua)
                    {
                        int maPB = Convert.ToInt32(txtMaPhongBan.Text);
                        if (phongBanBUL.update(maPB, txtTenPhongBan.Text, txtDiaChi.Text, txtSDT.Text))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            LoadData();
                            sua = false;
                            loaddisable();
                            menucontrol.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:
                    txtTenPhongBan.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = false;
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
            }
        }

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

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = phongBanBUL.searchPhongBan(keyword);
            if (results.Any())
            {
                dgvPhongBan.AutoGenerateColumns = true;
                dgvPhongBan.DataSource = results;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhongBan.DataSource = null;
            }

        }

        public frmQuanLyPhongBan()
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
            dgvPhongBan.Columns["SDTPB"].HeaderText = "Số Điện Thoại Phòng Ban";
        }
        private void loaddisable()
        {
            txtMaPhongBan.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = txtTenPhongBan.Enabled = false;
        }
    }
}
