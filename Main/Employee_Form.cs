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
using Sunny.UI;

namespace Main.Phap_Form
{

    public partial class Employee_Form : Form
    {
        public int maNV { get; set; }
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
            if (maNV!=0)
            {
                uiTextBox1.Text = maNV.ToString();
                guna2Button1.Text = "Cập nhật";

                NhanVien nv = new NhanVienDLL().GetEmployeeByID(maNV);
                uiTextBox3.Text = nv.HoTen;
                comboPhongBan.SelectedValue = nv.MaPB;
                comboGT.SelectedItem = nv.GioiTinh;
                uiTextBox5.Text = nv.Email;
                if (nv.NgaySinh.HasValue)
                {
                    guna2DateTimePicker1.Value = nv.NgaySinh.Value;
                }
                else
                {
                    guna2DateTimePicker1.Value = DateTime.Now;  // Hoặc giá trị mặc định khác
                }

                if (nv.NgayVaoLam.HasValue)
                {
                    guna2DateTimePicker2.Value = nv.NgayVaoLam.Value;
                }
                else
                {
                    guna2DateTimePicker2.Value = DateTime.Now;  // Hoặc giá trị mặc định khác
                }

                comboBoxNVQL.SelectedValue = nv.NguoiQuanLy;
                comboBoxTthn.SelectedItem = nv.TinhTrangHonNhan;
                comboBoxDT.SelectedItem = nv.DanToc;
                uiTextBox2.Text = nv.DienThoai;
                uiTextBox4.Text = nv.CCCD;
                uiTextBox6.Text = nv.DiaChi;
                uiTextBox7.Text = nv.LuongCB.ToString();

            }    

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (maNV != 0)
            {
                NhanVienDLL nhanVienDLL = new NhanVienDLL();
                NhanVien nv = new NhanVien
                {
                    MaNV = maNV,
                    HoTen = uiTextBox3.Text,
                    MaPB = int.Parse(comboPhongBan.SelectedValue.ToString()),
                    GioiTinh = comboGT.SelectedItem.ToString(),
                    Email = uiTextBox5.Text,
                    NgaySinh = guna2DateTimePicker1.Value,
                    NgayVaoLam = guna2DateTimePicker2.Value,
                    NguoiQuanLy = int.Parse(comboBoxNVQL.SelectedValue.ToString()),
                    TinhTrangHonNhan = comboBoxTthn.SelectedItem.ToString(),
                    DanToc = comboBoxDT.SelectedItem.ToString(),
                    DienThoai = uiTextBox2.Text,
                    CCCD = uiTextBox4.Text,
                    DiaChi = uiTextBox6.Text,
                    LuongCB = int.Parse(uiTextBox7.Text.ToString())
                };
                nhanVienDLL.UpdateEmployee(nv);
                MessageBox.Show("Cập nhật nhân viên thành công");
                this.Close();
                return;
                
            }

                string tenNV = uiTextBox3.Text;
                int idPB = int.Parse(comboPhongBan.SelectedValue.ToString());
                string gioitinh = comboGT.SelectedItem.ToString();
                string gmail = uiTextBox5.Text;
                DateTime ngaySinh = guna2DateTimePicker1.Value;
                DateTime ngayVao = guna2DateTimePicker2.Value;
                int nguoiQL = int.Parse(comboBoxNVQL.SelectedValue.ToString());
                string tinhTrangHN = comboBoxTthn.SelectedItem.ToString();
                string dantoc = comboBoxDT.SelectedItem.ToString();
                string dienthoai = uiTextBox2.Text;
                string cccd = uiTextBox4.Text;
                string diachi = uiTextBox6.Text;
                int luongCB = int.Parse(uiTextBox7.Text.ToString());
                if (luongCB <= 0)
                {
                    MessageBox.Show("Lương cơ bản không hợp lệ");
                    return;
                }

                if (tenNV.Length == 0)
                {
                    MessageBox.Show("Cần nhập đủ thông tin");
                    uiTextBox3.Focus();
                    return;
                }
                if (DateTime.Now.Year - ngaySinh.Year < 18)
                {
                    MessageBox.Show("Nhân viên chưa đủ 18 tuổi");
                    return;
                }
                if (DateTime.Now.Year - ngayVao.Year < 0)
                {
                    MessageBox.Show("Ngày vào làm không hợp lệ");
                    return;
                }
                try
                {

                    NhanVien nv = new NhanVien
                    {
                        HoTen = tenNV,
                        MaPB = idPB,
                        GioiTinh = gioitinh,
                        Email = gmail,
                        NgaySinh = ngaySinh,
                        NgayVaoLam = ngayVao,
                        NguoiQuanLy = nguoiQL,
                        TinhTrangHonNhan = tinhTrangHN,
                        DanToc = dantoc,
                        DienThoai = dienthoai,
                        CCCD = cccd,
                        DiaChi = diachi,
                        LuongCB = luongCB
                    };
                    new NhanVienDLL().AddEmployee(nv);
                    MessageBox.Show("Thêm nhân viên thành công");
                this.Close();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }

        private void uiTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }
    }
}
