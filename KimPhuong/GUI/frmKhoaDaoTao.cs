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
    public partial class frmKhoaDaoTao : UIPage
    {
        bool them, sua, loc = false;
        KhoaDaoTaoBUS khoaDaoTaoBUS;
        public frmKhoaDaoTao()
        {
            InitializeComponent();
            khoaDaoTaoBUS = new KhoaDaoTaoBUS();
            loadKhoaDaoTao();

            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Đang mở đăng kí");
            cbTrangThai.Items.Add("Đã đóng đăng kí");
            cbTrangThai.Items.Add("Đã hoàn thành");
            cbTrangThai.Items.Add("Đã hủy");
            cbTrangThai.SelectedIndex = 0;

        }
        private void loadKhoaDaoTao()
        {
            dgvKhoaDaoTao.DataSource = null;

            var khoa = khoaDaoTaoBUS.GetAll();

            dgvKhoaDaoTao.DataSource = khoa;

            if (dgvKhoaDaoTao.Rows.Count > 0)
            {
                dgvKhoaDaoTao.Columns["MaKhoaDaoTao"].HeaderText = "Mã khóa đào tạo";
                dgvKhoaDaoTao.Columns["TenKhoaHoc"].HeaderText = "Tên khóa học";
                dgvKhoaDaoTao.Columns["DonViDaoTao"].HeaderText = "Đơn vị đào tạo";
                dgvKhoaDaoTao.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
                dgvKhoaDaoTao.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
                dgvKhoaDaoTao.Columns["ChiPhi"].HeaderText = "Chi phí";
                dgvKhoaDaoTao.Columns["TrangThai"].HeaderText = "Trạng thái";

            }
        }
        private void loaddisable()
        {
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = txtDonVi.Enabled = cbTrangThai.Enabled = dtpNgayBatDau.Enabled = dtpNgayKetThuc.Enabled = txtChiPhi.Enabled = false;

        }
        private void loadenable()
        {
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = txtDonVi.Enabled = cbTrangThai.Enabled = dtpNgayBatDau.Enabled = dtpNgayKetThuc.Enabled = txtChiPhi.Enabled = true;
        }

        private void dgvKhoaDaoTao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoaDaoTao.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgvKhoaDaoTao.SelectedRows[0];
                txtMaKhoa.Text = row.Cells["MaKhoaDaoTao"].Value.ToString();
                txtTenKhoa.Text = row.Cells["TenKhoaHoc"].Value.ToString();
                txtDonVi.Text = row.Cells["DonViDaoTao"].Value.ToString();

                DateTime? ngayBatDau = row.Cells["NgayBatDau"].Value as DateTime?;
                if (ngayBatDau.HasValue)
                {
                    dtpNgayBatDau.Value = ngayBatDau.Value;
                }

                DateTime? ngayKetThuc = row.Cells["NgayKetThuc"].Value as DateTime?;
                if (ngayKetThuc.HasValue)
                {
                    dtpNgayKetThuc.Value = ngayKetThuc.Value;
                }

                txtChiPhi.Text = row.Cells["ChiPhi"].Value.ToString();
                string trangThai = row.Cells["TrangThai"].Value.ToString();

                if (cbTrangThai.Items.Contains(trangThai))
                {
                    cbTrangThai.SelectedItem = trangThai;
                }
                else
                {
                    cbTrangThai.SelectedIndex = -1;
                }
            }
            else
            {
                txtMaKhoa.Clear();
                txtTenKhoa.Clear();
                txtDonVi.Clear();
                dtpNgayBatDau.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                txtChiPhi.Clear();
                cbTrangThai.SelectedIndex = -1;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();

            var results = khoaDaoTaoBUS.Search(keyword);
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (results.Any())
            {
                dgvKhoaDaoTao.DataSource = results;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuatWord_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateInput()
        {


            if (Convert.ToDateTime(dtpNgayBatDau.Value) > Convert.ToDateTime(dtpNgayKetThuc.Value))
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtTenKhoa.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên khóa học!", "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtDonVi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đơn vị đào tạo", "Thông báo",
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
                    txtMaKhoa.Enabled = false;
                    cbTrangThai.Enabled = false;
                    cbTrangThai.SelectedIndex = 0;
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgvKhoaDaoTao.SelectedRows.Count > 0)
                    {
                        if (cbTrangThai.SelectedItem != null && cbTrangThai.SelectedItem.ToString() == "Đang mở đăng kí")
                        {
                            sua = true;
                            loaddisable();
                            txtChiPhi.Enabled = dtpNgayBatDau.Enabled = dtpNgayKetThuc.Enabled = cbTrangThai.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa khi trạng thái không phải 'Đang mở đăng kí'!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (dgvKhoaDaoTao.SelectedRows.Count > 0)
                    {
                        if (cbTrangThai.SelectedItem != null && cbTrangThai.SelectedItem.ToString() == "Đã hủy")
                        {
                            MessageBox.Show("Chỉ có thể xóa khi trạng thái là đã hủy", "Thông báo");
                            return;
                        }
                        if (MessageBox.Show("Bạn có chắc muốn xóa " + dgvKhoaDaoTao.SelectedRows.Count + " dòng đã chọn?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool hasError = false;
                            foreach (DataGridViewRow row in dgvKhoaDaoTao.SelectedRows)
                            {
                                int makhoa = Convert.ToInt32(row.Cells["MaKhoaDaoTao"].Value);
                                if (!khoaDaoTaoBUS.Delete(makhoa))
                                {
                                    hasError = true;
                                    MessageBox.Show("Xóa thất bại mã chuyển phòng ban: " + makhoa,
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            if (!hasError)
                            {
                                MessageBox.Show("Xóa thành công tất cả dòng đã chọn!", "Thông báo");
                            }
                            loadKhoaDaoTao();
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
                        if (khoaDaoTaoBUS.Insert(txtTenKhoa.Text, txtDonVi.Text, Convert.ToDateTime(dtpNgayBatDau.Value),
                            Convert.ToDateTime(dtpNgayKetThuc.Value), Convert.ToInt32(txtChiPhi.Text), "Đang mở đăng kí"))
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo");
                            loadKhoaDaoTao();
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
                        if (dgvKhoaDaoTao.SelectedRows[0].Cells["TrangThai"].Value.ToString() == "Đang mở đăng kí")
                        {
                            if (khoaDaoTaoBUS.Update(
                            Convert.ToInt32(dgvKhoaDaoTao.SelectedRows[0].Cells["MaKhoaDaoTao"].Value), txtTenKhoa.Text,
                            txtDonVi.Text, Convert.ToDateTime(dtpNgayBatDau.Value),
                            Convert.ToDateTime(dtpNgayKetThuc.Value), Convert.ToInt32(txtChiPhi.Text), cbTrangThai.SelectedItem.ToString()))
                            {
                                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                                loadKhoaDaoTao();
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
                        else
                        {
                            MessageBox.Show("Chỉ có thể sửa khi trạng thái là đang mở đăng kí!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (loc)
                    {

                        if (cbTrangThai.SelectedItem != null)
                        {
                            string trangThai = cbTrangThai.SelectedItem.ToString();

                            dgvKhoaDaoTao.DataSource = khoaDaoTaoBUS.GetKhoaDaoTaoByTrangThai(trangThai);
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu theo trạng thái đã lọc", "Thông báo", MessageBoxButtons.OK);
                            dgvKhoaDaoTao.DataSource = khoaDaoTaoBUS.GetAll();
                        }

                        if (dgvKhoaDaoTao.Rows.Count > 0)
                        {
                            dgvKhoaDaoTao.Columns["MaKhoaDaoTao"].HeaderText = "Mã khóa đào tạo";
                            dgvKhoaDaoTao.Columns["TenKhoaHoc"].HeaderText = "Tên khóa học";
                            dgvKhoaDaoTao.Columns["DonViDaoTao"].HeaderText = "Đơn vị đào tạo";
                            dgvKhoaDaoTao.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
                            dgvKhoaDaoTao.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
                            dgvKhoaDaoTao.Columns["ChiPhi"].HeaderText = "Chi phí";
                            dgvKhoaDaoTao.Columns["TrangThai"].HeaderText = "Trạng thái";
                        }

                        loc = false;
                        loaddisable();
                        menucontrol.SetStatus(DynamicControl.menucontrol2.Status.View);
                    }
                    break;


                case DynamicControl.menucontrol2.ButtonType.Cancel:
                    loaddisable();
                    them = sua = false;
                    loadKhoaDaoTao();
                    loaddisable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Reload:
                    loadKhoaDaoTao();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Exit:
                    Application.Exit();
                    break;
                case DynamicControl.menucontrol2.ButtonType.Loc:
                    cbTrangThai.Enabled = true;
                    loc = true;
                    break;
            }
        }
    }
}
