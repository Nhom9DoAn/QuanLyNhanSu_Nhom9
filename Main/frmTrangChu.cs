using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimPhuong;
using KimPhuong.GUI;
using Sunny.UI;
using GUI;
namespace Main
{
    public partial class frmTrangChu : UIHeaderAsideMainFrame
    {
        public frmTrangChu(string tenNhanVien, string chucVu)
        {
            InitializeComponent();
            lblTenDangNhap.Text = tenNhanVien;
            if (chucVu == "Giám đốc")
            {
                int pageIndex = 1000;
                TreeNode root = Aside.CreateNode("QUẢN LÝ PHÒNG BAN", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmQuanLyPhongBan(), ++pageIndex));

                pageIndex = 2000;
                root = Aside.CreateNode("QUẢN LÝ NHÂN SỰ", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmQuanLyNghiPhep(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frm_CongTac(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frm_HopDongLaoDong(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frm_ThuongPhat(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frmHocVanBangCap(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frmLichSuPhongBan(), ++pageIndex));

            }
            else
            {
                MessageBox.Show("Không có quyền truy cập");
            }
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
