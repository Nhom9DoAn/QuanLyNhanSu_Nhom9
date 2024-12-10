namespace KimPhuong.GUI
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PieChart = new Sunny.UI.UIPieChart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPhongBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DoughnutChart = new Sunny.UI.UIDoughnutChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DoughnutChart, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PieChart, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.91892F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.08108F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // PieChart
            // 
            this.PieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PieChart.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PieChart.Location = new System.Drawing.Point(3, 87);
            this.PieChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.PieChart.Name = "PieChart";
            this.PieChart.Size = new System.Drawing.Size(388, 354);
            this.PieChart.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PieChart.TabIndex = 0;
            this.PieChart.Text = "uiPieChart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.19588F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.80412F));
            this.tableLayoutPanel3.Controls.Add(this.cbPhongBan, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.guna2HtmlLabel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 78);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.cbPhongBan.BorderRadius = 15;
            this.cbPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPhongBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPhongBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPhongBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPhongBan.ItemHeight = 30;
            this.cbPhongBan.Location = new System.Drawing.Point(190, 3);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(195, 36);
            this.cbPhongBan.TabIndex = 0;
            this.cbPhongBan.SelectedIndexChanged += new System.EventHandler(this.cbPhongBan_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(181, 29);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Chọn phòng ban:";
            // 
            // DoughnutChart
            // 
            this.DoughnutChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoughnutChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DoughnutChart.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DoughnutChart.Location = new System.Drawing.Point(403, 3);
            this.DoughnutChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.DoughnutChart.Name = "DoughnutChart";
            this.DoughnutChart.Size = new System.Drawing.Size(394, 444);
            this.DoughnutChart.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DoughnutChart.TabIndex = 1;
            this.DoughnutChart.Text = "uiDoughnutChart1";
            // 
            // frmThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UIPieChart PieChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbPhongBan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Sunny.UI.UIDoughnutChart DoughnutChart;
    }
}