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
using KimPhuong.DTO;
using KimPhuong.BUS;


namespace KimPhuong.GUI
{
    public partial class frmQuanLyHopDongLaoDong : UIPage
    {
        HopDongBLL hdbll = new HopDongBLL();
        NhanVienBUS nvbll = new NhanVienBUS();
        ChucVuBLL cvbll = new ChucVuBLL();
        bool them, sua, tim = false;
        Button btnDelete = new Button();
        private ContextMenuStrip contextMenu = new ContextMenuStrip();
        public frmQuanLyHopDongLaoDong()
        {
            InitializeComponent();

            rad_HD6Thang.CheckedChanged += rad_HD6Thang_CheckedChanged;
            rad_HD1Nam.CheckedChanged += rad_HD1Nam_CheckedChanged;
            dtp_NgayBD.ValueChanged += dtp_NgayBD_ValueChanged;


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

            dgv_DSHopDong.ContextMenuStrip = contextMenu;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_DSHopDong.SelectedRows.Count > 0)
            {
                int maHD = Convert.ToInt32(dgv_DSHopDong.SelectedRows[0].Cells["MaHD"].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = hdbll.DeleteHopDong(maHD);
                    if (success)
                    {
                        MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadHopDong();
                        btnDelete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa hợp đồng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rad_HD1Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_HD1Nam.Checked)
            {
                dtp_NgayKT.Enabled = false;
                dtp_NgayKT.Value = dtp_NgayBD.Value.AddYears(1);
            }
        }

        private void dtp_NgayBD_ValueChanged(object sender, EventArgs e)
        {
            if (rad_HD6Thang.Checked)
            {
                dtp_NgayKT.Value = dtp_NgayBD.Value.AddMonths(6);
            }
            else if (rad_HD1Nam.Checked)
            {
                dtp_NgayKT.Value = dtp_NgayBD.Value.AddYears(1);
            }
        }

        private void rad_HD6Thang_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_HD6Thang.Checked)
            {
                dtp_NgayKT.Enabled = false;
                dtp_NgayKT.Value = dtp_NgayBD.Value.AddMonths(6);
            }
        }

        public void loadHopDong()
        {
            dgv_DSHopDong.DataSource = hdbll.getAllHopDong();
            if (dgv_DSHopDong.Columns["HoTen"] != null)
            {
                dgv_DSHopDong.Columns["HoTen"].DisplayIndex = 2;
            }

            dgv_DSHopDong.Columns["NgayBatDau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_DSHopDong.Columns["NgayKetThuc"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void dgv_DSHopDong_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void frmQuanLyHopDongLaoDong_Load(object sender, EventArgs e)
        {
            loadHopDong();
            loadNhanVien();
            loadChucVu();
            disable();
        }


        public void resetText()
        {
            dtp_NgayBD.Value = DateTime.Now;
            dtp_NgayKT.Value = DateTime.Now;
            cb_LoaiHD.SelectedIndex = 0;
            txt_BieuMau.ResetText();
            cb_TinhTrang.SelectedIndex = 0;
            cb_TenNV.SelectedIndex = 0;
            dtp_NgaySinh.Value = DateTime.Now;

            txt_BieuMau.ResetText();
        }


        private void menu_QLHopDongLD_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol2.ButtonType.Add:
                    them = true;
                    resetText();
                    enable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Edit:
                    if (dgv_DSHopDong.SelectedRows.Count > 0)
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
                    var newHopDong = new HopDongDTO
                    {
                        MaHD = sua ? Convert.ToInt32(dgv_DSHopDong.SelectedRows[0].Cells["MaHD"].Value) : 0,
                        MaNV = maNV,
                        LoaiHD = cb_LoaiHD.Text,
                        NgayBatDau = dtp_NgayBD.Value,
                        NgayKetThuc = dtp_NgayKT.Value,
                        BieuMau = txt_BieuMau.Text,
                        TinhTrang =cb_TinhTrang.Text
                    };

                    //// Kiểm tra ngày bắt đầu phải bé hơn ngày kết thúc
                    //if (newHopDong.NgayBatDau >= newHopDong.NgayKetThuc)
                    //{
                    //    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}

                    if (rad_HD6Thang.Checked)
                    {
                        dtp_NgayKT.Enabled = false;
                        dtp_NgayKT.Value = dtp_NgayBD.Value.AddMonths(6);
                    }
                    else
                    {
                        dtp_NgayKT.Enabled = false;
                        dtp_NgayKT.Value = dtp_NgayBD.Value.AddYears(1);

                    }


                    if (them)
                    {
                        hdbll.AddHopDong(newHopDong);
                        loadHopDong();
                        disable();
                    }
                    else if (sua)
                    {
                        if (hdbll.UpdateHopDong(newHopDong))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                            loadHopDong();
                            sua = false;
                            disable();
                            menu_QLHopDongLD.SetStatus(DynamicControl.menucontrol2.Status.View);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tim == true)
                    {

                        string locLoaiHD = cb_LoaiHD.SelectedItem?.ToString();                       
                        //string filterTrangThai = cb_TrangThai.SelectedItem?.ToString();
                        //int? filterMaNV = cb_NhanVien.SelectedValue as int?;
                        DateTime? filterNgayBatDau = dtp_NgayBD.Value.Date;
                        var filteredData = hdbll.getAllHopDong();

                        if (!string.IsNullOrEmpty(locLoaiHD))
                        {
                            filteredData = filteredData.Where(hd => hd.LoaiHD.Equals(locLoaiHD)).ToList();
                        }
                        //if (filterMaNV.HasValue)
                        //{
                        //    filteredData = filteredData.Where(ct => ct.MaNV == filterMaNV.Value).ToList();
                        //}
                        //if (filterNgayBatDau.HasValue)
                        //{
                        //    filteredData = filteredData.Where(hd => hd.NgayBatDau.Date == filterNgayBatDau.Value).ToList();
                        //}
                        int recordCount = filteredData.Count;
                        MessageBox.Show($"Tìm thấy {recordCount} bản ghi tương ứng.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgv_DSHopDong.DataSource = filteredData;
                    }
                    break;

                case DynamicControl.menucontrol2.ButtonType.Cancel:

                    break;

                case DynamicControl.menucontrol2.ButtonType.Search:
                    tim = true;
                    cb_LoaiHD.Enabled = true;
                    break;

                case DynamicControl.menucontrol2.ButtonType.Reload:
                    loadHopDong();
                    disable();
                    break;

                case DynamicControl.menucontrol2.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }

        public void loadNhanVien()
        {
            cb_TenNV.DataSource = nvbll.GetAll();
            cb_TenNV.ValueMember = "MaNV";
            cb_TenNV.DisplayMember = "HoTen";
        }

        public void loadChucVu()
        {
            cb_ChucVu.DataSource = cvbll.GetAllChucVu();
            cb_ChucVu.ValueMember = "MaCV";
            cb_ChucVu.DisplayMember = "TenCV";
        }



        private void dgv_DSHopDong_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgv_DSHopDong.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgv_DSHopDong.SelectedRows[0];
                dtp_NgayBD.Value = Convert.ToDateTime(selected.Cells["NgayBatDau"].Value);
                dtp_NgayKT.Value = Convert.ToDateTime(selected.Cells["NgayKetThuc"].Value);
                
                cb_LoaiHD.SelectedItem = selected.Cells["LoaiHD"].Value.ToString();
                txt_BieuMau.Text = selected.Cells["BieuMau"].Value.ToString();
                cb_TinhTrang.SelectedItem = selected.Cells["TinhTrang"].Value.ToString();
                cb_TenNV.SelectedValue = Convert.ToInt32(selected.Cells["MaNV"].Value);
                
                int manv = Convert.ToInt32(selected.Cells["MaNV"].Value);
                var nv = nvbll.GetByID(manv);
                txt_DiaChi.Text = nv.DiaChi ?? string.Empty;
                dtp_NgaySinh.Value = nv.NgaySinh.HasValue ? nv.NgaySinh.Value : DateTime.Now;
                txt_CCCD.Text = nv.CCCD ?? string.Empty;
                txt_SDT.Text = nv.DienThoai ?? string.Empty;
                cb_ChucVu.SelectedValue = nv.MaCV.HasValue ? nv.MaCV.Value : -1;

            }
        }

        public void disable()
        {
            dtp_NgayBD.Enabled = dtp_NgayKT.Enabled = cb_LoaiHD.Enabled = txt_BieuMau.Enabled = cb_TinhTrang.Enabled =
                cb_TenNV.Enabled = dtp_NgaySinh.Enabled = txt_SDT.Enabled = txt_DiaChi.Enabled = txt_CCCD.Enabled = cb_ChucVu.Enabled = false;
        }

        public void enable()
        {
            dtp_NgayBD.Enabled = dtp_NgayKT.Enabled = cb_LoaiHD.Enabled = txt_BieuMau.Enabled = cb_TinhTrang.Enabled =
                cb_TenNV.Enabled =true;
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
                            txt_DiaChi.Text = nv.DiaChi ?? string.Empty;
                            dtp_NgaySinh.Value = nv.NgaySinh.HasValue ? nv.NgaySinh.Value : DateTime.Now;
                            txt_CCCD.Text = nv.CCCD ?? string.Empty;
                            txt_SDT.Text = nv.DienThoai ?? string.Empty;
                            cb_ChucVu.SelectedValue = nv.MaCV.HasValue ? nv.MaCV.Value : -1;
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
    }
}
