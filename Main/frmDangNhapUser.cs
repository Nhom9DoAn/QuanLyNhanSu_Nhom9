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
        }

        private void dangNhapControl1_ButtonClicked(object sender, DynamicControl.DangNhapControl.ButtonType buttonType, EventArgs e)
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
}
