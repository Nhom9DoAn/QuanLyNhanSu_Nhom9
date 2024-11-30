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
    public partial class frmChuyenPhongBan : UIPage
    {
        NhanVienBUS nhanVienBUS;
        ChuyenPhongBanBUS chuyenPhongBanBUS;
        PhongBanBUL phongBanBUL;
        public frmChuyenPhongBan()
        {
            chuyenPhongBanBUS = new ChuyenPhongBanBUS();
            nhanVienBUS = new NhanVienBUS();
            phongBanBUL = new PhongBanBUL();
            InitializeComponent();
            LoadCombobox();
            LoadData();
            loadPhongBan();
        }

        private void loadPhongBan()
        {
            cbPhongBan.DataSource = null;

            var phongBan = phongBanBUL.getAll();
            cbPhongBan.DataSource = phongBan;
            cbPhongBan.ValueMember = "TenPB";
            cbPhongBan.DisplayMember = "MaPB";
        }
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
                    cbPhongBan.SelectedValue = nv.MaPB;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý thông tin nhân viên: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            dgvChuyenPhongBan.DataSource = chuyenPhongBanBUS.GetAll();

            dgvChuyenPhongBan.Columns["MaChuyenPB"].HeaderText = "Mã chuyển phòng ban";
            dgvChuyenPhongBan.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvChuyenPhongBan.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvChuyenPhongBan.Columns["MaPB_Cu"].HeaderText = "Mã phòng ban cũ";
            dgvChuyenPhongBan.Columns["TenPhongBanCu"].HeaderText = "Tên phòng ban cũ";
            dgvChuyenPhongBan.Columns["MaPB_Moi"].HeaderText = "Mã phòng ban mới";
            dgvChuyenPhongBan.Columns["TenPhongBanMoi"].HeaderText = "Tên phòng ban mới";
            dgvChuyenPhongBan.Columns["NgayHieuLuc"].HeaderText = "Ngày hiệu lực";
            dgvChuyenPhongBan.Columns["TenNguoiTao"].HeaderText = "Người tạo";
            dgvChuyenPhongBan.Columns["LyDoChuyen"].HeaderText = "Lý do chuyển";
            dgvChuyenPhongBan.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvChuyenPhongBan.Columns["NgayCapNhatTrangThai"].HeaderText = "Ngày cập nhật trạng thái";
            dgvChuyenPhongBan.Columns["NguoiDuyet"].HeaderText = "Người duyệt";
            dgvChuyenPhongBan.Columns["GhiChuDuyet"].HeaderText = "Ghi chú duyệt";
        }

        private void dgvChuyenPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvChuyenPhongBan.SelectedRows.Count>0)
            {
                DataGridViewRow selected = dgvChuyenPhongBan.SelectedRows[0];

                cboMaNV.SelectedValue = selected.Cells["MaNV"].Value;
            }
        }

        private void menucontrol_ButtonClicked(object sender, DynamicControl.menucontrol2.ButtonType buttonType, EventArgs e)
        {

        }
    }
}
