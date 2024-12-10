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
using KimPhuong.DTO;
using KimPhuong.BUL;
using KimPhuong.BUS;

namespace KimPhuong.GUI
{
    public partial class frmQuanLyThuongPhat : UIPage
    {
        ThuongPhatBLL tpbll = new ThuongPhatBLL();
        NhanVienBUS nvbll = new NhanVienBUS();
        PhongBanBUL pbbll = new PhongBanBUL();

        bool them, sua, tim = false;
        Button btnDelete = new Button();
        private ContextMenuStrip contextMenu = new ContextMenuStrip();
        public frmQuanLyThuongPhat()
        {
            InitializeComponent();

            //tạo button xóa ở dgv
            btnDelete.Text = "Delete";
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Size = new Size(100, 40);
            btnDelete.Location = new Point(200, 400);
            this.Controls.Add(btnDelete);
            btnDelete.Visible = false;

            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            deleteMenuItem.BackColor = Color.Red;
            deleteMenuItem.ForeColor = Color.Black;
            deleteMenuItem.Font = new Font(deleteMenuItem.Font, FontStyle.Bold);
            deleteMenuItem.Click += DeleteMenuItem_Click;
            contextMenu.Items.Add(deleteMenuItem);

            dgv_QLThuongPhat.ContextMenuStrip = contextMenu;

        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_QLThuongPhat.SelectedRows.Count > 0)
            {
                int maTP = Convert.ToInt32(dgv_QLThuongPhat.SelectedRows[0].Cells["MaTP"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = tpbll.DeleteThuongPhat(maTP);
                    if (success)
                    {
                        MessageBox.Show("Xóa thưởng phạt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadThuongPhat();
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thưởng phạt thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void loadThuongPhat()
        {
            dgv_QLThuongPhat.DataSource = tpbll.getAllThuongPhat();
            if (dgv_QLThuongPhat.Columns["HoTen"] != null)
            {
                dgv_QLThuongPhat.Columns["HoTen"].DisplayIndex = 2;
            }

            dgv_QLThuongPhat.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public void disable()
        {
            dtp_NgayXet.Enabled = txt_SoTien.Enabled = txtx_LyDo.Enabled = cb_TrangThai.Enabled =
                cb_TenNV.Enabled = txt_SDT.Enabled = txt_PhongBan.Enabled = dtp_NgayVaoLam.Enabled = false;
        }

        public void resetText()
        {
            dtp_NgayXet.Value = DateTime.Now;
            txt_SoTien.ResetText();
            cb_TrangThai.SelectedIndex = 0;
            cb_TenNV.SelectedIndex = 0;
            txtx_LyDo.ResetText();
        }

        public void enable()
        {
            dtp_NgayXet.Enabled = txt_SoTien.Enabled = txtx_LyDo.Enabled = cb_TrangThai.Enabled =
                cb_TenNV.Enabled =  true;
        }


        public void loadNV()
        {
            cb_TenNV.DataSource = nvbll.GetAll();
            cb_TenNV.ValueMember = "MaNV";
            cb_TenNV.DisplayMember = "HoTen";
        }

        private void menucontrol21_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyThuongPhat_Load(object sender, EventArgs e)
        {
            loadThuongPhat();
            loadNV();
            disable();
        }

        private void cb_TenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_TenNV.SelectedValue != null)
                {
                    int maNV;
                    if (int.TryParse(cb_TenNV.SelectedValue.ToString(), out maNV))
                    {
                        var nv = nvbll.GetByID(maNV);
                        if (nv != null)
                        {
                            int mapb = nv.MaPB.Value;
                            var phongban = pbbll.getAll();
                            var phongBanSelected = phongban.FirstOrDefault(b => b.MaPB == mapb);

                            if (phongBanSelected != null)
                            {
                                txt_PhongBan.Text = phongBanSelected.TenPB;
                            }
                            else
                            {
                                txt_PhongBan.Text = "Không tìm thấy phòng ban";
                            }
                            dtp_NgayVaoLam.Value = nv.NgayVaoLam.Value;
                            dtp_NgayVaoLam.Value = nv.NgayVaoLam.HasValue ? nv.NgaySinh.Value : DateTime.Now;
                            txt_SDT.Text = nv.DienThoai ?? string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_QLThuongPhat_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgv_QLThuongPhat.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgv_QLThuongPhat.SelectedRows[0]; 
                int manv = Convert.ToInt32(selected.Cells["MaNV"].Value);
                cb_TenNV.SelectedValue = Convert.ToInt32(selected.Cells["MaNV"].Value);
                dtp_NgayXet.Value = Convert.ToDateTime(selected.Cells["Ngay"].Value);
                if(selected.Cells["Loai"].Value.ToString() == "Thưởng")
                {
                    rad_Thuong.Checked = true;
                }
                else
                {
                    rad_Phat.Checked = true;
                }
                txt_SoTien.Text = selected.Cells["SoTien"].Value.ToString();
                txtx_LyDo.Text = selected.Cells["LyDo"].Value.ToString();
                cb_TrangThai.SelectedItem = selected.Cells["TrangThai"].Value.ToString();


                //load nhân viên
                var nhanvien = nvbll.GetByID(manv);
                txt_SDT.Text = nhanvien.DienThoai;
                int mapb = nhanvien.MaPB.Value;
                var phongban = pbbll.getAll();
                var phongBanSelected = phongban.FirstOrDefault(b => b.MaPB == mapb);

                if (phongBanSelected != null)
                {
                    txt_PhongBan.Text = phongBanSelected.TenPB;
                }
                else
                {
                    txt_PhongBan.Text = "Không tìm thấy phòng ban";
                }
                dtp_NgayVaoLam.Value = nhanvien.NgayVaoLam.Value;


            }
        }

        private void menu_QLThuongPhat_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol2.ButtonType.Add:
                    them = true;
                    resetText();
                    enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgv_QLThuongPhat.SelectedRows.Count > 0)
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
                    int maNV = Convert.ToInt32(cb_TenNV.SelectedValue);
                    int soTien;
                    if (!int.TryParse(txt_SoTien.Text, out soTien))
                    {
                        MessageBox.Show("Vui lòng nhập một số hợp lệ cho Số Tiền!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var newThuongPhat = new ThuongPhatDTO
                    {
                        MaTP = sua ? Convert.ToInt32(dgv_QLThuongPhat.SelectedRows[0].Cells["MaTP"].Value) : 0,
                        MaNV = maNV,
                        Ngay = dtp_NgayXet.Value,
                        Loai = rad_Phat.Checked ? "Phạt" :"Thưởng",
                        SoTien = soTien,
                        LyDo = txtx_LyDo.Text,
                        TrangThai = cb_TrangThai.SelectedItem?.ToString()
                    };

                    
                    if (them)
                    {
                        tpbll.AddThuongPhat(newThuongPhat);
                        loadThuongPhat();
                        disable();
                    }
                    else if (sua)
                    {
                        if (tpbll.UpdateThuongPhat(newThuongPhat))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            loadThuongPhat();
                            sua = false;
                            disable();
                            menu_QLThuongPhat.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tim == true)
                    {
                        string loai_xet = string.Empty;
                        if (rad_Phat.Checked)
                        {
                            loai_xet = "Phạt";
                        }
                        else
                        {
                            loai_xet = "Thưởng";
                        }
                        var filteredData = tpbll.getAllThuongPhat();
                        if (!string.IsNullOrEmpty(loai_xet))
                        {
                            filteredData = filteredData.Where(hd => hd.Loai.Equals(loai_xet, StringComparison.OrdinalIgnoreCase)).ToList();
                        }
                        int recordCount = filteredData.Count;
                        MessageBox.Show($"Tìm thấy {recordCount} bản ghi tương ứng.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_QLThuongPhat.DataSource = filteredData;
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:

                    break;

                case DynamicControl.menucontrol2.ButtonType.Loc:
                    tim = true;
                    break;

                case DynamicControl.menucontrol2.ButtonType.Reload:
                    loadThuongPhat();
                    disable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }
    }
}
