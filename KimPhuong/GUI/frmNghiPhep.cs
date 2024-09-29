using KimPhuong.BUL;
using KimPhuong.DAL;
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

namespace KimPhuong.GUI
{
    public partial class frmNghiPhep : UIPage
    {
        NghiPhepDAO nghiPhepDAO;
        NghiPhepBUL nghiPhepBUL;
        bool them, xoa, sua, tim = false;

        private void dgvNghiPhep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void dgvNghiPhep_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvNghiPhep.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgvNghiPhep.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        public frmNghiPhep()
        {
            InitializeComponent();
            nghiPhepBUL = new NghiPhepBUL();
            LoadData();
            dgvNghiPhep.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);

        }

        private void LoadData()
        {
            dgvNghiPhep.DataSource = null;
            nghiPhepBUL = new NghiPhepBUL();
            dgvNghiPhep.DataSource = nghiPhepBUL.getAll();

            dgvNghiPhep.Columns["MaNP"].HeaderText = "Mã Phòng Ban";
            dgvNghiPhep.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dgvNghiPhep.Columns["TuNgay"].HeaderText = "Từ Ngày";
            dgvNghiPhep.Columns["DenNgay"].HeaderText = "Đến Ngày";
            dgvNghiPhep.Columns["LyDo"].HeaderText = "Lý Do";
            dgvNghiPhep.Columns["TinhTrang"].HeaderText = "Tình Trạng";
        }


    }
}
