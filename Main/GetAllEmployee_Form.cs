using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Main
{
    public partial class GetAllEmployee_Form : Form
    {
        public GetAllEmployee_Form()
        {
            InitializeComponent();
        }

        private void GetAllEmployee_Form_Load(object sender, EventArgs e)
        {
            NhanVienDLL nhanVienDll = new NhanVienDLL();
            dgvNhanVien.DataSource = nhanVienDll.GetNhanViens();
        }
    }
}
