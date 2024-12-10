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
    public partial class frmQLNhanThan : UIPage
    {
        NhanThanBLL ntbll = new NhanThanBLL();
        NhanVienBUS nvbll = new NhanVienBUS();
        PhongBanBUL pbbll = new PhongBanBUL();

        bool them, sua, tim = false;
        Button btnDelete = new Button();
        private ContextMenuStrip contextMenu = new ContextMenuStrip();
        public frmQLNhanThan()
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

            dgv_QLNhanThan.ContextMenuStrip = contextMenu;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_QLNhanThan.SelectedRows.Count > 0)
            {
                int maNT = Convert.ToInt32(dgv_QLNhanThan.SelectedRows[0].Cells["MaNT"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = ntbll.DeleteNhanThan(maNT);
                    if (success)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadNhanThan();
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void loadNhanVien()
        {
            cb_TenNV.DataSource = nvbll.GetAll();
            cb_TenNV.ValueMember = "MaNV";
            cb_TenNV.DisplayMember = "HoTen";
        }

        public void loadNhanThan()
        {
            dgv_QLNhanThan.DataSource = ntbll.getAllNhanThan();
            if (dgv_QLNhanThan.Columns["MaNV"] != null)
            {
                dgv_QLNhanThan.Columns["MaNV"].Visible = false;
            }
            dgv_QLNhanThan.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgv_QLNhanThan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_QLNhanThan.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgv_QLNhanThan.SelectedRows[0];
                int manv = Convert.ToInt32(selected.Cells["MaNV"].Value);
                cb_TenNV.SelectedValue = Convert.ToInt32(selected.Cells["MaNV"].Value);
                txt_HoTen.Text = selected.Cells["HoTenNT"].Value.ToString();
                txt_MoiQuanHe.Text = selected.Cells["QuanHe"].Value.ToString();
                dtp_NgaySinh.Value = Convert.ToDateTime(selected.Cells["NgaySinh"].Value);
                txt_SDT_NT.Text = selected.Cells["DienThoai"].Value.ToString();
                txt_DiaChiNT.Text = selected.Cells["DiaChi"].Value.ToString();


                //load nhân viên
                var nhanvien = nvbll.GetByID(manv);
                txt_SDT_NV.Text = nhanvien.DienThoai;
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

        public void resetText()
        {
            txt_HoTen.ResetText();
            txt_MoiQuanHe.ResetText();
            txt_DiaChiNT.ResetText();
            txt_SDT_NT.ResetText();
            dtp_NgaySinh.Value = DateTime.Now;
        }

        public void disable()
        {
            txt_HoTen.Enabled = txt_MoiQuanHe.Enabled = txt_DiaChiNT.Enabled = txt_PhongBan.Enabled =
                txt_SDT_NT.Enabled = txt_SDT_NV.Enabled = cb_TenNV.Enabled = dtp_NgaySinh.Enabled = dtp_NgayVaoLam.Enabled = false;
        }
        public void enable()
        {
            txt_HoTen.Enabled = txt_MoiQuanHe.Enabled = txt_DiaChiNT.Enabled = cb_TenNV.Enabled=
                 txt_SDT_NT.Enabled = dtp_NgaySinh.Enabled  = true;
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
                            txt_SDT_NV.Text = nv.DienThoai ?? string.Empty;
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

        private void frmQLNhanThan_Load(object sender, EventArgs e)
        {
            loadNhanThan();
            loadNhanVien();
            disable();
        }

        private void menu_QLNhanThan_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol2.ButtonType.Add:
                    them = true;
                    resetText();
                    enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgv_QLNhanThan.SelectedRows.Count > 0)
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
                    // Kiểm tra các trường bắt buộc không được bỏ trống
                    if (string.IsNullOrWhiteSpace(txt_HoTen.Text) || string.IsNullOrWhiteSpace(txt_MoiQuanHe.Text) ||
                        string.IsNullOrWhiteSpace(txt_SDT_NT.Text) || string.IsNullOrWhiteSpace(txt_DiaChiNT.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ các thông tin!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra số điện thoại (chỉ cho phép số và tối đa 10 chữ số)
                    if (!long.TryParse(txt_SDT_NT.Text, out _) || txt_SDT_NT.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại phải là một dãy số và có 10 chữ số!", "Lỗi nhập liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra ngày sinh không được lớn hơn ngày hiện tại
                    if (dtp_NgaySinh.Value > DateTime.Now)
                    {
                        MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!", "Lỗi nhập liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newNhanThan = new NhanThanDTO
                    {
                        MaNT = sua ? Convert.ToInt32(dgv_QLNhanThan.SelectedRows[0].Cells["MaNT"].Value) : 0,
                        MaNV = maNV,
                        HoTenNT = txt_HoTen.Text,
                        QuanHe = txt_MoiQuanHe.Text,
                        NgaySinh = dtp_NgaySinh.Value,
                        DienThoai = txt_SDT_NT.Text,
                        DiaChi = txt_DiaChiNT.Text
                    };


                    if (them)
                    {
                        ntbll.AddNhanThan(newNhanThan);
                        loadNhanThan();
                        disable();
                    }
                    else if (sua)
                    {
                        if (ntbll.UpdateNhanThan(newNhanThan))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            loadNhanThan();
                            sua = false;
                            disable();
                            menu_QLNhanThan.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tim == true)
                    {
                        int? filterMaNV = cb_TenNV.SelectedValue as int?;


                        var filteredData = ntbll.getAllNhanThan();
                        if (filterMaNV.HasValue)
                        {
                            filteredData = filteredData.Where(ct => ct.MaNV == filterMaNV.Value).ToList();
                        }
                        int recordCount = filteredData.Count;
                        if(recordCount == 0)
                        {
                            MessageBox.Show("Không tìm thấy bản ghi");
                        }
                        else
                        {
                            MessageBox.Show($"Tìm thấy {recordCount} bản ghi tương ứng.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                        dgv_QLNhanThan.DataSource = filteredData;
                    }

                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:
                    resetText();
                    enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Loc:
                    tim = true; cb_TenNV.Enabled = true;
                    break;

                case DynamicControl.menucontrol2.ButtonType.Reload:
                    loadNhanThan();
                    disable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }
    }
}
