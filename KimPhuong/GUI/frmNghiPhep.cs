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
        NghiPhepBUL nghiPhepBUL;
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
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.SelectedIndex = -1;
        }

        private void LoadControls()
        { 
        }

        private void dgvNghiPhep_SelectionChanged(object sender, EventArgs e)
        {
            
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
            if (them == true)
            {
                if (!txtMaNP.Text.StartsWith("NP"))
                {
                    txtMaNP.Text = "NP" + txtMaNP.Text;
                    txtMaNP.SelectionStart = txtMaNP.Text.Length;
                }
            }
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
            
        }

        private void LoadData()
        {
           
        }

        private void frmNghiPhep_Load(object sender, EventArgs e)
        {

        }

        private void menucontrol1_ButtonClicked(object sender, DynamicControl.menucontrol.ButtonType buttonType, EventArgs e)
        {
            switch (buttonType)
            {
                case DynamicControl.menucontrol.ButtonType.Add:
                    them = true;
                    txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled = dtpDenNgay.Enabled = dtpTuNgay.Enabled = radChuaDuyet.Checked = true;
                    cboMaNV.Enabled = true;
                    txtSDT.Enabled = false;
                    txtMaNP.Text = txtLyDo.Text = "";
                    txtMaNP.Focus();
                    break;
                case DynamicControl.menucontrol.ButtonType.Edit:
                    sua = true;
                    txtLyDo.Enabled = radChuaDuyet.Enabled = radDaDuyet.Enabled = true;
                    break;
                case DynamicControl.menucontrol.ButtonType.Search:
                    tim = true;
                    cboMaNV.Enabled = true;
                    break;
                case DynamicControl.menucontrol.ButtonType.Delete:
                    if (dgvNghiPhep.SelectedRows.Count > 0)
                    {

                       
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case DynamicControl.menucontrol.ButtonType.Cancel:
                    txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled = dtpDenNgay.Enabled = dtpTuNgay.Enabled = cboMaNV.Enabled = false;
                    them = xoa = sua = tim = false;
                    break;
                case DynamicControl.menucontrol.ButtonType.Save:
                    if (them)
                    {
                       
                    }
                    else if (sua)
                    {
                        
                    }
                    else if (tim)
                    {
                        
                    }
                    break;
                case DynamicControl.menucontrol.ButtonType.Reload:
                    LoadData();
                    txtMaNP.Enabled = txtLyDo.Enabled = txtSDT.Enabled = dtpDenNgay.Enabled = dtpTuNgay.Enabled = false;
                    cboMaNV.Enabled = false;
                    break;

                case DynamicControl.menucontrol.ButtonType.Exit:
                    Application.Exit();
                    break;
            }
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtMaNP.Text) || string.IsNullOrEmpty(txtLyDo.Text)
                || string.IsNullOrEmpty(dtpTuNgay.Text) || string.IsNullOrEmpty(dtpDenNgay.Text)
                || cboMaNV.SelectedValue.ToString() == "Tất cả" || radDaDuyet.Checked == false && radChuaDuyet.Checked == false)
                return false;
            else
                return true;
        }
    }
}
