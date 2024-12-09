using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimPhuong.BUL;
using Sunny.UI;
namespace KimPhuong.GUI
{
    public partial class frmThongKe : UIPage
    {
        PhongBanBUL phongban;
        HocVanBangCapBUS hocVanBangCapBUS;
        public frmThongKe()
        {
            InitializeComponent();
            phongban = new PhongBanBUL();
            hocVanBangCapBUS = new HocVanBangCapBUS();
            loadDoughnut();
            LoadPhongBan();
            cbPhongBan.SelectedIndexChanged += cbPhongBan_SelectedIndexChanged;
        }

        private void LoadPhongBan()
        {
            var phongBans = phongban.getAll();
            if (phongBans != null && phongBans.Any())
            {
                cbPhongBan.DataSource = phongBans;
                cbPhongBan.DisplayMember = "TenPB";
                cbPhongBan.ValueMember = "MaPB";
            }
            else
            {
                MessageBox.Show("Không có phòng ban nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LoadPieChart(int maPhongBan)
        {
            var thongKe = phongban.ThongKeGioiTinhTheoPhong(maPhongBan);
            if (thongKe == null)
            {
                MessageBox.Show("Không có dữ liệu thống kê cho phòng ban này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var option = new UIPieOption();
            option.Title.Text = $"Thống Kê Giới Tính Phòng Ban: {thongKe.TenPhongBan}";
            option.Title.Top = UITopAlignment.Top;
            option.Title.Left = UILeftAlignment.Center;
            option.ToolTip.Visible = true;

            var series = new UIPieSeries();
            series.Name = "Giới Tính";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.Label.Show = true;

            series.AddData("Nam", thongKe.SoNam, Color.LightBlue);
            series.AddData("Nữ", thongKe.SoNu, Color.Pink);

            option.Legend = new UILegend
            {
                Orient = UIOrient.Vertical,
                Top = UITopAlignment.Bottom,
                Left = UILeftAlignment.Left
            };

            option.Legend.AddData("Nam", Color.LightBlue);
            option.Legend.AddData("Nữ", Color.Pink);

            option.Series.Clear();
            option.Series.Add(series);

            PieChart.SetOption(option);
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhongBan.SelectedValue is int maPhongBan)
            {
                LoadPieChart(maPhongBan);
            }
        }

        private void loadDoughnut()
        {
            
            var hv = hocVanBangCapBUS.ThongKeTheoBangCap();

            var option = new UIDoughnutOption();
            option.Title.Text = "Thống Kê Bằng Cấp";
            option.Title.Top = UITopAlignment.Top;
            option.Title.Left = UILeftAlignment.Center;
            option.ToolTip.Visible = true;

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Bottom;
            option.Legend.Left = UILeftAlignment.Left;

            var series = new UIDoughnutSeries();
            series.Name = "Thống Kê";
            series.Center = new UICenter(50, 55); 
           
            series.Label.Show = true;

            foreach (var item in hv)
            {
                string bangCap = item.BangCap.ToString(); 
                int soLuong = int.Parse(item.SoLuong.ToString());
                series.AddData(bangCap + ": " + soLuong.ToString(), soLuong);
                option.Legend.AddData(bangCap);
            }
            option.Series.Clear();
            option.Series.Add(series);
            DoughnutChart.SetOption(option);
        }

    }
}
