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
    public partial class frmDoiMatKhau : Form
    {
        DangNhapBUS dangNhapBUS;
        static string tendnnv;
        public frmDoiMatKhau(string tendn)
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            tendnnv = tendn;
        }

        private void btnXemMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (btnXemMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtNhapLaiMatKhau.PasswordChar = '*';
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtNhapLaiMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                bool kq = dangNhapBUS.doiMatKhau(tendnnv, txtMatKhau.Text);
                if (kq)
                {
                    MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK);
                    foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                    {
                        if (form.Name != "frmDangNhapUser")
                        {
                            form.Close();
                        }
                    }

                    frmDangNhapUser dn = new frmDangNhapUser();
                    dn.Show();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Có vấn đề khi đổi mật khẩu", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void frmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
