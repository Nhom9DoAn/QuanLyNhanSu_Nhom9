using DynamicControl;
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
    public partial class frmDangNhapUser : Form
    {
        public static int maNV;
        DangNhapBUS dangNhapBUS;
        public frmDangNhapUser()
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
                DynamicControl.DangNhapControl.ButtonType buttonType = DynamicControl.DangNhapControl.ButtonType.DangNhap;
                EventArgs args = new EventArgs();

                dangNhapControl1_ButtonClicked(sender, buttonType, args);
            }
        }

        private async void dangNhapControl1_ButtonClicked(object sender, DynamicControl.DangNhapControl.ButtonType buttonType, EventArgs e)
        {
            if (buttonType == DynamicControl.DangNhapControl.ButtonType.XemMatKhau)
            {
                if (loginControl.txtPass.PasswordChar == '*')
                {
                    loginControl.txtPass.PasswordChar = '\0';
                }
                else
                {
                    loginControl.txtUsername.PasswordChar = '*';
                }
            }
            else if (buttonType == DynamicControl.DangNhapControl.ButtonType.DangNhap)
            {
                string username = loginControl.txtUsername.Text;
                string password = loginControl.txtPass.Text;

                if (dangNhapBUS.KiemTraDangNhap(username, password))
                {
                    maNV = dangNhapBUS.LayMaNV(username);
                    string tenNhanVien = dangNhapBUS.LayTenNhanVien(maNV);
                    string chucVu = dangNhapBUS.LayChucVu(maNV);
                    frmLoading loadingForm = new frmLoading();
                    loadingForm.Show();
                    await Task.Delay(2000);
                    frmTrangChu trangChuForm = new frmTrangChu(maNV,tenNhanVien, chucVu);
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
}
