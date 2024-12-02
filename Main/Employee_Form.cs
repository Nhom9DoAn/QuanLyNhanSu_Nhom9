using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Main.Phap_Form
{
    public partial class Employee_Form : Form
    {
        public Employee_Form()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            List<PhongBan> phongBans = new PhongBanBLL().GetPhongBans();
            comboPhongBan.DataSource = phongBans;
            comboPhongBan.DisplayMember = "TenPB";
            comboPhongBan.ValueMember = "MaPB";
            comboPhongBan.SelectedIndex = 0;
            comboGT.Items.Add("Nam");
            comboGT.Items.Add("Nữ");
            comboGT.SelectedIndex = 0;
            List<NhanVien> nhanViens = new NhanVienBUL().GetNhanViens();
            comboBoxNVQL.DataSource = nhanViens;
            comboBoxNVQL.DisplayMember = "HoTen";
            comboBoxNVQL.ValueMember = "MaNV";
            comboBoxNVQL.SelectedIndex = 0;
            comboBoxTthn.Items.Add("Độc thân");
            comboBoxTthn.Items.Add("Đã kết hôn");
            comboBoxTthn.SelectedIndex = 0;
            comboBoxDT.Items.Add("Kinh");
            comboBoxDT.SelectedIndex = 0;

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
