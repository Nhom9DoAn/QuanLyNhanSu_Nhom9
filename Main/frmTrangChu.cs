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
namespace Main
{
    public partial class frmTrangChu : UIHeaderAsideMainFrame
    {
        public frmTrangChu()
        {
            InitializeComponent();
            int pageIndex = 1000;
            TreeNode root = Aside.CreateNode("QUẢN LÝ PHÒNG BAN", 61451, 24, pageIndex);
            Aside.CreateChildNode(root, AddPage(new frmPhongBan(), ++pageIndex));
            
            pageIndex = 2000;
            root = Aside.CreateNode("QUẢN LÝ NHÂN SỰ", 61451, 24, pageIndex);
            Aside.CreateChildNode(root, AddPage(new frmNghiPhep(), ++pageIndex));
            Aside.CreateChildNode(root, AddPage(new frmHocVan(), ++pageIndex));
        }
    }
}
