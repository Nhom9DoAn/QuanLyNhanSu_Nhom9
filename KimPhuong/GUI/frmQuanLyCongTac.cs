using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using KimPhuong.BUL;
using KimPhuong.BUS;
using KimPhuong.DAL;
using KimPhuong.DTO;

namespace KimPhuong.GUI
{
    public partial class frmQuanLyCongTac : UIPage
    {

        CongTacBUL ctbll = new CongTacBUL();
        NhanVienBUS nvbll = new NhanVienBUS();
        bool them, xoa, sua, tim = false;
        Button btnDelete = new Button();
        private ContextMenuStrip contextMenu = new ContextMenuStrip();
        public frmQuanLyCongTac()
        {
            InitializeComponent();
            loadCongTac();
            loadNhanVien();
            disable();
            btnDelete.Text = "Delete";
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Size = new Size(100, 40);
            btnDelete.Location = new Point(200, 400);
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);
            btnDelete.Visible = false; 

            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            deleteMenuItem.BackColor = Color.Red; 
            deleteMenuItem.ForeColor = Color.Black;
            deleteMenuItem.Font = new Font(deleteMenuItem.Font, FontStyle.Bold);
            deleteMenuItem.Click += DeleteMenuItem_Click;
            contextMenu.Items.Add(deleteMenuItem);

            dgvCongTac.ContextMenuStrip = contextMenu;
            menucontrol_CongTac.ButtonClicked += menucontrol_CongTac_ButtonClicked;
            rad_LocTenNV.CheckedChanged += rad_Loc_CheckedChanged;
            rad_LocTheoNgay.CheckedChanged += rad_Loc_CheckedChanged;
            rad_LocTrangThai.CheckedChanged += rad_Loc_CheckedChanged;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCongTac.SelectedRows.Count > 0)
            {
                int maCT = Convert.ToInt32(dgvCongTac.SelectedRows[0].Cells["MaCT"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa công tác này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = ctbll.DeleteCongTac(maCT);
                    if (success)
                    {
                        MessageBox.Show("Xóa công tác thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadCongTac();
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa công tác thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public void loadNhanVien()
        {
            cb_NhanVien.DataSource = nvbll.GetAll();
            cb_NhanVien.ValueMember = "MaNV";
            cb_NhanVien.DisplayMember = "HoTen";
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        public void loadCongTac()
        {
            dgvCongTac.DataSource = ctbll.GetAll();
            if (dgvCongTac.Columns["MaNV"] != null)
            {
                dgvCongTac.Columns["MaNV"].Visible = false;
            }
            if (dgvCongTac.Columns["HoTen"] != null)
            {
                dgvCongTac.Columns["HoTen"].DisplayIndex = 1;
            }

        }

        public void resetText()
        {           
            dtp_NgayBD.Value =DateTime.Now;
            dtp_NgayKT.Value = DateTime.Now;
            txt_DiaDiem.ResetText();
            txt_MucDich.ResetText();
            txt_BieuMau.ResetText();
        }

        public void disable()
        {
            cb_NhanVien.Enabled = dtp_NgayBD.Enabled = dtp_NgayKT.Enabled =
                txt_DiaDiem.Enabled = txt_MucDich.Enabled = txt_BieuMau.Enabled = cb_TrangThai.Enabled = false;
        }
        public void enable()
        {
            cb_NhanVien.Enabled = dtp_NgayBD.Enabled = dtp_NgayKT.Enabled =
                txt_DiaDiem.Enabled = txt_MucDich.Enabled = txt_BieuMau.Enabled = cb_TrangThai.Enabled = true;
        }


        private void menucontrol_CongTac_ButtonClicked(object sender, DynamicControl.menucontrol3.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol3.ButtonType.Add:
                    them = true;
                    resetText();
                    enable();
                    break;

                case DynamicControl.menucontrol3.ButtonType.Edit:
                    if (dgvCongTac.SelectedRows.Count > 0)
                    {
                        sua = true;
                        enable();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                    break;

                case DynamicControl.menucontrol3.ButtonType.Delete:

                    break;

                case DynamicControl.menucontrol3.ButtonType.Save:
                    int maNV = Convert.ToInt32(cb_NhanVien.SelectedValue);
                    var newCongTac = new CongTacDTO
                    {
                        MaCT = sua ? Convert.ToInt32(dgvCongTac.SelectedRows[0].Cells["MaCT"].Value) : 0,
                        MaNV = maNV,
                        NgayBatDau = dtp_NgayBD.Value,
                        NgayKetThuc = dtp_NgayKT.Value,
                        DiaDiem = txt_DiaDiem.Text,
                        MucDich = txt_MucDich.Text,
                        BieuMau = txt_BieuMau.Text,
                        TrangThai = cb_TrangThai.Text
                    };

                    // Kiểm tra ngày bắt đầu phải bé hơn ngày kết thúc
                    if (newCongTac.NgayBatDau >= newCongTac.NgayKetThuc)
                    {
                        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra số lần công tác của nhân viên trong tháng
                    var existingAssignments = ctbll.GetAll()
                        .Where(ct => ct.MaNV == maNV && ct.NgayBatDau.Month == newCongTac.NgayBatDau.Month)
                        .ToList();

                    if (existingAssignments.Count >= 3)
                    {
                        MessageBox.Show("Nhân viên này đã đủ số lần công tác trong tháng, vui lòng chọn nhân viên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (them)
                    {
                        
                        ctbll.AddCongTac(newCongTac);
                        loadCongTac();
                        disable();
                    }else if (sua)
                    {
                        if (ctbll.UpdateCongTac(newCongTac))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            loadCongTac();
                            sua = false;
                            disable();
                            menucontrol_CongTac.SetStatus(DynamicControl.menucontrol3.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }else if (tim == true)
                    {
                        MessageBox.Show("Bạn muốn lọc hả?");
                        string filterTrangThai = cb_TrangThai.SelectedItem?.ToString();
                        int? filterMaNV = cb_NhanVien.SelectedValue as int?;
                        DateTime? filterNgayBatDau = dtp_NgayBD.Value.Date;

                        var filteredData = ctbll.GetAll();

                        if (!string.IsNullOrEmpty(filterTrangThai))
                        {
                            filteredData = filteredData.Where(ct => ct.TrangThai.Equals(filterTrangThai)).ToList();
                        }

                        if (filterMaNV.HasValue)
                        {
                            filteredData = filteredData.Where(ct => ct.MaNV == filterMaNV.Value).ToList();
                        }

                        if (filterNgayBatDau.HasValue)
                        {
                            filteredData = filteredData.Where(ct => ct.NgayBatDau.Date == filterNgayBatDau.Value).ToList();
                        }

                        dgvCongTac.DataSource = filteredData;
                    }
                    
                    
                    break;

                case DynamicControl.menucontrol3.ButtonType.Cancel:

                    break;

                case DynamicControl.menucontrol3.ButtonType.Search:
                    tim = true; enable();
                    break;

                case DynamicControl.menucontrol3.ButtonType.Reload:
                    loadCongTac();
                    disable();
                    break;

                case DynamicControl.menucontrol3.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }

        private void menucontrol_CongTac_Load(object sender, EventArgs e)
        {

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            string filterTrangThai = cb_TrangThai.SelectedItem?.ToString();
            int? filterMaNV = cb_NhanVien.SelectedValue as int?;
            DateTime? filterNgayBatDau = dtp_NgayBD.Value.Date;

            var filteredData = ctbll.GetAll();
            if(rad_LocTenNV.Checked == rad_LocTheoNgay.Checked == rad_LocTrangThai.Checked == false)
            {
                disable();
                MessageBox.Show("Vui lòng chọn chế độ tìm kiếm");
            }

            if ( rad_LocTrangThai.Checked==true && !string.IsNullOrEmpty(filterTrangThai))
            {
                cb_TrangThai.Enabled = true;
                filteredData = filteredData.Where(ct => ct.TrangThai.Equals(filterTrangThai)).ToList();
            }

            if (rad_LocTenNV.Checked==true && filterMaNV.HasValue)
            {
                cb_NhanVien.Enabled = true;
                filteredData = filteredData.Where(ct => ct.MaNV == filterMaNV.Value).ToList();
            }

            if (rad_LocTheoNgay.Checked == true &&filterNgayBatDau.HasValue)
            {
                dtp_NgayBD.Enabled = true;
                filteredData = filteredData.Where(ct => ct.NgayBatDau.Date == filterNgayBatDau.Value).ToList();
            }

            dgvCongTac.DataSource = filteredData;
        }

        private void rad_Loc_CheckedChanged(object sender, EventArgs e)
        {
            // Đảm bảo tất cả Control đều bị vô hiệu hóa ban đầu
            cb_NhanVien.Enabled = false;
            dtp_NgayBD.Enabled = false;
            cb_TrangThai.Enabled = false;

            // Bật Control tương ứng với RadioButton được chọn
            if (rad_LocTenNV.Checked)
            {
                cb_NhanVien.Enabled = true;
            }
            else if (rad_LocTheoNgay.Checked)
            {
                dtp_NgayBD.Enabled = true;
            }
            else if (rad_LocTrangThai.Checked)
            {
                cb_TrangThai.Enabled = true;
            }
        }


        private void btn_enable_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rad_LocTheoNgay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvCongTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    int maCT = Convert.ToInt32(dgvCongTac.Rows[e.RowIndex].Cells["MaCT"].Value);

            //    var congTac = ctbll.GetAll().FirstOrDefault(ct => ct.MaCT == maCT);

            //    if (congTac != null)
            //    {
            //        cb_NhanVien.SelectedValue = Convert.ToInt32(dgvCongTac.Rows[e.RowIndex].Cells["MaNV"].Value);
            //        dtp_NgayBD.Value = congTac.NgayBatDau;
            //        dtp_NgayKT.Value = congTac.NgayKetThuc;
            //        txt_DiaDiem.Text = congTac.DiaDiem;
            //        txt_MucDich.Text = congTac.MucDich;
            //        txt_BieuMau.Text = congTac.BieuMau;
            //        cb_TrangThai.SelectedItem = congTac.TrangThai;
            //    }
            //}
        }

        private void dgvCongTac_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCongTac.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgvCongTac.SelectedRows[0];

                cb_NhanVien.SelectedValue = Convert.ToInt32(selected.Cells["MaNV"].Value);
                dtp_NgayBD.Value = Convert.ToDateTime(selected.Cells["NgayBatDau"].Value);
                dtp_NgayKT.Value = Convert.ToDateTime(selected.Cells["NgayKetThuc"].Value);
                txt_DiaDiem.Text = selected.Cells["DiaDiem"].Value.ToString();
                txt_MucDich.Text = selected.Cells["MucDich"].Value.ToString();
                txt_BieuMau.Text = selected.Cells["BieuMau"].Value?.ToString();
                cb_TrangThai.SelectedItem = selected.Cells["TrangThai"].Value.ToString();

                btnDelete.Visible = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCongTac.SelectedRows.Count > 0)
            {
                int maCT = Convert.ToInt32(dgvCongTac.SelectedRows[0].Cells["MaCT"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa công tác này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = ctbll.DeleteCongTac(maCT);
                    if (success)
                    {
                        MessageBox.Show("Xóa công tác thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadCongTac(); // Tải lại dữ liệu
                        btnDelete.Visible = false; // Ẩn nút Delete sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Xóa công tác thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
