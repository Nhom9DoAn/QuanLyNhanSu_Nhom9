using Main.BUS;
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
    public partial class frmDangNhap : Form
    {
        DangNhapBUS dangNhapBUS;
        public frmDangNhap()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                txtPassword.PasswordChar = '\0'; 
            }
            else 
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUserName.Text;
            string matKhau = txtPassword.Text;

            if (dangNhapBUS.KiemTraDangNhap(tenDangNhap, matKhau))
            {
                int maNV = dangNhapBUS.LayMaNV(tenDangNhap);

                string tenNhanVien = dangNhapBUS.LayTenNhanVien(maNV);
                string chucVu = dangNhapBUS.LayChucVu(maNV);

                frmTrangChu trangChuForm = new frmTrangChu(tenNhanVien, chucVu);
                trangChuForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }
    }
}
