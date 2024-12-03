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
using KimPhuong.DTO;

namespace KimPhuong.GUI
{
    public partial class frmQuanLyTuyenDung : UIPage
    {
        TuyenDungBLL tdbll = new TuyenDungBLL();
        PhongBanBUL pbdll = new PhongBanBUL();
        NhanVienBUS nvbll = new NhanVienBUS();

        bool them, xoa, sua, tim = false;
        Button btnDelete = new Button();
        private ContextMenuStrip contextMenu = new ContextMenuStrip();
        public int manv;

        public frmQuanLyTuyenDung()
        {
            InitializeComponent();
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_QLTuyenDung.SelectedRows.Count > 0)
            {
                int maUT = Convert.ToInt32(dgv_QLTuyenDung.SelectedRows[0].Cells["MaUT"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = tdbll.DeleteTuyenDung(maUT);
                    if (success)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadTuyenDung();
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public frmQuanLyTuyenDung(int maNV)
        {
            InitializeComponent();
            manv = maNV;

            //tạo button xóa ở dgv
            btnDelete.Text = "Delete";
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Size = new Size(100, 40);
            btnDelete.Location = new Point(200, 400);
            this.Controls.Add(btnDelete);
            btnDelete.Visible = true;

            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            deleteMenuItem.BackColor = Color.Red;
            deleteMenuItem.ForeColor = Color.Black;
            deleteMenuItem.Font = new Font(deleteMenuItem.Font, FontStyle.Bold);
            deleteMenuItem.Click += DeleteMenuItem_Click;
            contextMenu.Items.Add(deleteMenuItem);

            dgv_QLTuyenDung.ContextMenuStrip = contextMenu;
        }

        public void loadTuyenDung()
        {
            dgv_QLTuyenDung.DataSource = tdbll.getAllTuyenDung();

            if (dgv_QLTuyenDung.Columns["MaPhong"] != null)
            {
                dgv_QLTuyenDung.Columns["MaPhong"].Visible = false;
            }
            if (dgv_QLTuyenDung.Columns["NguoiPhuTrach"] != null)
            {
                dgv_QLTuyenDung.Columns["NguoiPhuTrach"].Visible = false;
            }

            dgv_QLTuyenDung.Columns["HoTen"].HeaderText = "Người phụ trách";
            dgv_QLTuyenDung.Columns["TenPB"].HeaderText = "Phòng ban";
        }

        public void loadPhongBan()
        {
            cb_PhongBan.DataSource = pbdll.getAll();
            cb_PhongBan.ValueMember = "MaPB";
            cb_PhongBan.DisplayMember = "TenPB";
        }
        public void loadNhanVien()
        {
            cb_NhanVien.DataSource = nvbll.GetAll();
            cb_NhanVien.ValueMember = "MaNV";
            cb_NhanVien.DisplayMember = "HoTen";
        }

        private void frmQuanLyTuyenDung_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có mã nhân viên: " + manv);
            loadTuyenDung();
            loadPhongBan();
            loadNhanVien();
            disable();

        }

        public void resetText()
        {
            txt_TenViTri.ResetText();
            txt_SoLuong.ResetText();
            dtp_NgayBD.Value = DateTime.Now;
            dtp_NgayKT.Value = DateTime.Now;
            txt_YeuCau.ResetText();
        }

        public void disable()
        {
            txt_TenViTri.Enabled = txt_SoLuong.Enabled = dtp_NgayBD.Enabled = dtp_NgayKT.Enabled =
                txt_YeuCau.Enabled = cb_PhongBan.Enabled = cb_TrangThai.Enabled = dtp_NgayKT.Enabled = cb_NhanVien.Enabled = false;
        }

        private void dgv_QLTuyenDung_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_QLTuyenDung.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgv_QLTuyenDung.SelectedRows[0];
                txt_TenViTri.Text = selected.Cells["TenViTri"].Value.ToString();
                txt_SoLuong.Text = selected.Cells["SoLuong"].Value.ToString();
                dtp_NgayBD.Value = Convert.ToDateTime(selected.Cells["NgayBatDau"].Value);
                txt_YeuCau.Text = selected.Cells["YeuCau"].Value.ToString();
                dtp_NgayKT.Value = Convert.ToDateTime(selected.Cells["NgayKetThuc"].Value);
                cb_PhongBan.SelectedValue = Convert.ToInt32(selected.Cells["MaPhong"].Value);
                cb_TrangThai.SelectedItem = selected.Cells["TrangThai"].Value.ToString();
                cb_NhanVien.SelectedValue = Convert.ToInt32(selected.Cells["NguoiPhuTrach"].Value);
            }
        }
        public void enable()
        {
            txt_TenViTri.Enabled = txt_SoLuong.Enabled = dtp_NgayBD.Enabled = dtp_NgayKT.Enabled =
                txt_YeuCau.Enabled = cb_PhongBan.Enabled = cb_TrangThai.Enabled = dtp_NgayKT.Enabled = true;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_QLTuyenDung_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol2.ButtonType.Add:
                    them = true;
                    resetText();
                    enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgv_QLTuyenDung.SelectedRows.Count > 0)
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

                case DynamicControl.menucontrol2.ButtonType.Delete:

                    break;

                case DynamicControl.menucontrol2.ButtonType.Save:
                    //int maNV = Convert.ToInt32(cb_NhanVien.SelectedValue);
                    int maPB = Convert.ToInt32(cb_PhongBan.SelectedValue);

                    int soLuong;
                    if (!int.TryParse(txt_SoLuong.Text, out soLuong))
                    {
                        MessageBox.Show("Số lượng phải là một số nguyên hợp lệ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var newTuyenDung = new TuyenDungDTO
                    {
                        MaUT = sua ? Convert.ToInt32(dgv_QLTuyenDung.SelectedRows[0].Cells["MaUT"].Value) : 0,
                        TenViTri = txt_TenViTri.Text,
                        MaPhong = maPB,
                        SoLuong = soLuong,
                        TrangThai = cb_TrangThai.Text,
                        NgayBatDau = dtp_NgayBD.Value,
                        NgayKetThuc = dtp_NgayKT.Value,
                        YeuCau = txt_YeuCau.Text,
                        NguoiPhuTrach = manv,                       
                    };

                    // Kiểm tra ngày bắt đầu phải bé hơn ngày kết thúc
                    if (newTuyenDung.NgayBatDau >= newTuyenDung.NgayKetThuc)
                    {
                        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (them)
                    {
                        tdbll.AddTuyenDung(newTuyenDung);
                        loadTuyenDung();
                        disable();
                    }
                    else if (sua)
                    {
                        if (tdbll.UpdateTuyenDung(newTuyenDung))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            loadTuyenDung();
                            sua = false;
                            disable();
                            menu_QLTuyenDung.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tim == true)
                    {
                        string filterTrangThai = cb_TrangThai.SelectedItem?.ToString();

                        var filteredData = tdbll.getAllTuyenDung();

                        if (!string.IsNullOrEmpty(filterTrangThai))
                        {
                            filteredData = filteredData.Where(ct => ct.TrangThai.Equals(filterTrangThai)).ToList();
                        }

                        dgv_QLTuyenDung.DataSource = filteredData;
                    }


                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:

                    break;

                case DynamicControl.menucontrol2.ButtonType.Search:
                    tim = true; enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Reload:
                    loadTuyenDung();
                    disable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }
    }
}
