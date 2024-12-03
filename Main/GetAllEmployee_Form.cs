using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Main.Phap_Form;

namespace Main
{
    public partial class GetAllEmployee_Form : Form
    {
        public GetAllEmployee_Form()
        {
            InitializeComponent();
        }

        private void GetAllEmployee_Form_Load(object sender, EventArgs e)
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Employee_Form em = new Employee_Form();
            em.Show();
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

        private void dgvNhanVien_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Lấy chỉ số dòng được nhấp vào
                var hitTest = dgvNhanVien.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    // Chọn dòng đó
                    dgvNhanVien.ClearSelection();
                    dgvNhanVien.Rows[hitTest.RowIndex].Selected = true;

                    // Hiển thị ContextMenuStrip tại vị trí chuột
                    guna2ContextMenuStrip1.Show(dgvNhanVien, e.Location);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedRow = dgvNhanVien.SelectedRows[0];
                string maNhanVien = selectedRow.Cells["MaNV"].Value.ToString();
                NhanVienDLL nhanVienDLL = new NhanVienDLL();
                nhanVienDLL.DeleteEmployee(int.Parse(maNhanVien));
                List<TableNhanVien> tableNhanVienss = nhanVienDLL.SearchEmployeeByName(uiTextBox1.Text);
                dgvNhanVien.DataSource = tableNhanVienss;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           Employee_Form employee_Form = new Employee_Form();
          employee_Form.maNV = int.Parse(dgvNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString());
            employee_Form.Show();
        }
    }
}
