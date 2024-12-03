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


            this.KeyDown += frm_Login_KeyDown;
            this.KeyPreview = true;
        }
        private void frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1_Click(sender, e);
            }
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
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUserName.Text;
            string matKhau = txtPassword.Text;

            if (dangNhapBUS.KiemTraDangNhap(tenDangNhap, matKhau))
            {
                int maNV = dangNhapBUS.LayMaNV(tenDangNhap);

                string tenNhanVien = dangNhapBUS.LayTenNhanVien(maNV);
                string chucVu = dangNhapBUS.LayChucVu(maNV);

                frmLoading loadingForm = new frmLoading();
                loadingForm.Show();
                await Task.Delay(2000);
                //frmTrangChu trangChuForm = new frmTrangChu(tenNhanVien, chucVu);
                frmTrangChu trangChuForm = new frmTrangChu(maNV, tenNhanVien, chucVu);
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
