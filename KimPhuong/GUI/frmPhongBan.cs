using KimPhuong.BUL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimPhuong
{
    public partial class frmPhongBan : UIPage
    {
        PhongBanBUL phongBanBUL;
        public frmPhongBan()
        {
            InitializeComponent();
            phongBanBUL = new PhongBanBUL();
            LoadData();
        }
        private void LoadData()
        {
            dgvPhongBan.DataSource = null;
            phongBanBUL = new PhongBanBUL();
            dgvPhongBan.DataSource = phongBanBUL.getAll();

            dgvPhongBan.Columns["MaPB"].HeaderText = "Mã Phòng Ban";
            dgvPhongBan.Columns["TenPB"].HeaderText = "Tên Phòng Ban";
            dgvPhongBan.Columns["DiaChi"].HeaderText = "Địa Chỉ Phòng Ban";
            dgvPhongBan.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại Phòng Ban";
        }
    }
}
