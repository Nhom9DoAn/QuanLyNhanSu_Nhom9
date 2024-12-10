using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class FormDiemDanh : Form
    {
        public FormDiemDanh()
        {
            InitializeComponent();
        }

        private void FormDiemDanh_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;
            NhanVienDLL nhanVienDll = new NhanVienDLL();
            dgvNhanVien.DataSource = nhanVienDll.GetTavleNhanViens();
            List<PhongBan> phongBans = new PhongBanBLL().GetPhongBans();
            phongBans.Insert(0, new PhongBan { MaPB = 0, TenPB = "-- Chọn phòng ban --" });
            comboPhongBan.DataSource = phongBans;
            comboPhongBan.DisplayMember = "TenPB";
            comboPhongBan.ValueMember = "MaPB";
        }

        private void comboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhongBanDll phongBanDll = new PhongBanDll();
            if (int.TryParse(comboPhongBan.SelectedValue?.ToString(), out int departmentId))
            {
                if (departmentId == 0)
                {
                    NhanVienDLL nhanVienDLL = new NhanVienDLL();
                    List<TableNhanVien> tableNhanVienss = nhanVienDLL.SearchEmployeeByName(uiTextBox1.Text);
                    dgvNhanVien.DataSource = tableNhanVienss;
                    return;
                }
                List<TableNhanVien> tableNhanViens = phongBanDll.GetEmployeeInDepartment(departmentId);
                dgvNhanVien.DataSource = tableNhanViens;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            NhanVienDLL nhanVienDLL = new NhanVienDLL();
            List<TableNhanVien> tableNhanViens = nhanVienDLL.SearchEmployeeByName(uiTextBox1.Text);
            dgvNhanVien.DataSource = tableNhanViens;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void uiGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (uiTextBox3.Text.Length==0)
            {
                MessageBox.Show("Chưa chọn nhân viên");
                return;
            }
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn dòng trong danh sách nhân viên");
                return;
            }
            var maNhanVien = dgvNhanVien.CurrentRow.Cells[0].Value; // Cột đầu tiên

            if (maNhanVien == null || string.IsNullOrEmpty(maNhanVien.ToString()))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ hoặc mã nhân viên trống");
                return;
            }

           NhanVienDLL nhanVienDLL = new NhanVienDLL();
          int a = nhanVienDLL.DiemDanh(int.Parse(maNhanVien.ToString()),uiDatetimePicker1.Value,uiTextBox2.Text,null, DateTime.Now,0);
          if (a==1)
            {
                string time =DateTime.Now.ToString("HH:mm:ss");
                string message = $"Đã điểm danh giờ ra của NV: {uiTextBox3.Text}\nThời gian: {time}";
                MessageBox.Show(message, "Thông báo điểm danh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uiTextBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Đã điểm danh giờ vào cho nhân viên này");
            }


        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của cột thứ 2 (Index = 1) từ hàng được chọn
                var value = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value;

                // Gán giá trị vào TextBox
                uiTextBox3.Text = value != null ? value.ToString() : string.Empty;
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            if (uiTextBox3.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn nhân viên");
                return;
            }


            if (uiTextBox3.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn nhân viên");
                return;
            }
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn dòng trong danh sách nhân viên");
                return;
            }
            var maNhanVien = dgvNhanVien.CurrentRow.Cells[0].Value; // Cột đầu tiên

            if (maNhanVien == null || string.IsNullOrEmpty(maNhanVien.ToString()))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ hoặc mã nhân viên trống");
                return;
            }

            NhanVienDLL nhanVienDLL = new NhanVienDLL();
            int a = nhanVienDLL.DiemDanh(int.Parse(maNhanVien.ToString()), uiDatetimePicker1.Value, uiTextBox2.Text, DateTime.Now, null, 0);
            if (a == 1)
            {
                string time = DateTime.Now.ToString("HH:mm:ss");
                string message = $"Đã điểm danh giờ ra của NV: {uiTextBox3.Text}\nThời gian: {time}";
                MessageBox.Show(message, "Thông báo điểm danh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uiTextBox3.Text = "";
            }
            if (a==2)
            {
                MessageBox.Show("Chưa điểm danh giờ vào cho nhân viên này");
            }
            if (a==0) MessageBox.Show("Đã điểm danh giờ ra cho nhân viên này rồi");
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

            if (uiTextBox3.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn nhân viên");
                return;
            }
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn dòng trong danh sách nhân viên");
                return;
            }
            var maNhanVien = dgvNhanVien.CurrentRow.Cells[0].Value; // Cột đầu tiên

            if (maNhanVien == null || string.IsNullOrEmpty(maNhanVien.ToString()))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ hoặc mã nhân viên trống");
                return;
            }
            NhanVienDLL nhanVienDLL = new NhanVienDLL();
            int a = nhanVienDLL.DiemDanh(int.Parse(maNhanVien.ToString()), DateTime.Now, uiTextBox2.Text, null, uiDatetimePicker1.Value, 1);
            if (a == 1)
            {
                MessageBox.Show(" Điểm danh phép cho nhân viên");
                uiTextBox3.Text = "";
            }
            else MessageBox.Show("Đã điểm danh phép cho nhân viên này rồi");
        }

        private void uiDatetimePicker1_ValueChanged(object sender, DateTime value)
        {

        }
    }
}
