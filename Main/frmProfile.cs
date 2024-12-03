using Guna.UI2.WinForms;
using Main.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;

namespace Main
{
    public partial class frmProfile : Form
    {
        static string matkhauhientai, tendangnhapnv;
        public frmProfile(string tennv, string chucvu, string phongban, string tendangnhap, string matkhau)
        {
            InitializeComponent();
            txtChucVu.Text = chucvu;
            txtHoTen.Text = tennv;
            txtMatKhau.Text = matkhau;
            txtPhongBan.Text = phongban;
            txtTenDangNhap.Text = tendangnhap;
            matkhauhientai = matkhau;
            tendangnhapnv = tendangnhap;
        }

        private void btnXemMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (btnXemMatKhau.Checked)
            {
                txtMatKhauHienTai.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauHienTai.PasswordChar = '*';
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhauHienTai.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại để đổi mật khẩu");
                txtMatKhauHienTai.Focus();
                return;
            }
            if (txtMatKhauHienTai.Text == matkhauhientai)
            {
                frmDoiMatKhau frm = new frmDoiMatKhau(tendangnhapnv);
                frm.ShowDialog();
                this.Hide();
            }


        }
    }
}
