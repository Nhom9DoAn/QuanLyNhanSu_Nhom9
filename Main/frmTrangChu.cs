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
                TreeNode root = Aside.CreateNode("PHÒNG BAN", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmQuanLyPhongBan(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frmChuyenPhongBan(tenNhanVien), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frmLichSuPhongBan(), ++pageIndex));

                pageIndex = 2000;
                root = Aside.CreateNode("NHÂN SỰ", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmQuanLyNghiPhep(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frm_CongTac(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frm_HopDongLaoDong(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frm_ThuongPhat(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frmHocVanBangCap(), ++pageIndex));

                pageIndex = 3000;
                root = Aside.CreateNode("PHÁT TRIỂN", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmKhoaDaoTao(), ++pageIndex));
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

        private void Aside_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }
}
