using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicControl
{
    public partial class DangNhapControl : UserControl
    {
        public DangNhapControl()
        {
            InitializeComponent();
        }

        public Guna.UI2.WinForms.Guna2TextBox txtUsername { get { return this.txtUserName; } } 
        public Guna.UI2.WinForms.Guna2TextBox txtPass { get { return this.txtpass; } }

        public enum ButtonType
        {
            XemMatKhau, DangNhap
        }

        public delegate void ButtonClickedHandler(object sender, ButtonType buttonType, EventArgs e);
        public event ButtonClickedHandler ButtonClicked;

        protected virtual void OnButtonClicked(object sender, ButtonType buttonType, EventArgs e)
        {
            ButtonClicked?.Invoke(sender, buttonType, e);
        }

        private void btnHienMK_CheckedChanged(object sender, EventArgs e)
        {
            OnButtonClicked(sender, ButtonType.XemMatKhau, e);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            OnButtonClicked(sender, ButtonType.DangNhap, e);
        }
    }
}
