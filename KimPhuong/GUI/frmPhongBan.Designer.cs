namespace KimPhuong
{
    partial class frmPhongBan
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
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblTongNV = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTongNV = new System.Windows.Forms.TextBox();
            this.txtMaPhongBan = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenPhongBan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.menucontrol1 = new DynamicControl.menucontrol();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaPB.Font = new System.Drawing.Font("Arial", 13F);
            this.lblMaPB.Location = new System.Drawing.Point(500, 0);
            this.lblMaPB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(275, 31);
            this.lblMaPB.TabIndex = 0;
            this.lblMaPB.Text = "Mã Phòng Ban";
            this.lblMaPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenPB.Font = new System.Drawing.Font("Arial", 13F);
            this.lblTenPB.Location = new System.Drawing.Point(500, 46);
            this.lblTenPB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(275, 31);
            this.lblTenPB.TabIndex = 1;
            this.lblTenPB.Text = "Tên Phòng Ban";
            this.lblTenPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiaChi.Font = new System.Drawing.Font("Arial", 13F);
            this.lblDiaChi.Location = new System.Drawing.Point(500, 92);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(275, 31);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa Chỉ";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Arial", 13F);
            this.lblSoDienThoai.Location = new System.Drawing.Point(500, 138);
            this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(275, 31);
            this.lblSoDienThoai.TabIndex = 3;
            this.lblSoDienThoai.Text = "Số Điện Thoại";
            this.lblSoDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongNV
            // 
            this.lblTongNV.AutoSize = true;
            this.lblTongNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTongNV.Font = new System.Drawing.Font("Arial", 13F);
            this.lblTongNV.Location = new System.Drawing.Point(1572, 184);
            this.lblTongNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongNV.Name = "lblTongNV";
            this.lblTongNV.Size = new System.Drawing.Size(240, 31);
            this.lblTongNV.TabIndex = 4;
            this.lblTongNV.Text = "Số nhân viên";
            this.lblTongNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(783, 95);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(781, 37);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtTongNV
            // 
            this.txtTongNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTongNV.Enabled = false;
            this.txtTongNV.Location = new System.Drawing.Point(1820, 187);
            this.txtTongNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTongNV.Name = "txtTongNV";
            this.txtTongNV.Size = new System.Drawing.Size(241, 37);
            this.txtTongNV.TabIndex = 9;
            // 
            // txtMaPhongBan
            // 
            this.txtMaPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaPhongBan.Enabled = false;
            this.txtMaPhongBan.Location = new System.Drawing.Point(783, 3);
            this.txtMaPhongBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(781, 37);
            this.txtMaPhongBan.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.01682F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.01682F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.70919F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.22351F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.01682F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.01682F));
            this.tableLayoutPanel2.Controls.Add(this.lblMaPB, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTenPB, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDiaChi, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSoDienThoai, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTongNV, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtDiaChi, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTongNV, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtMaPhongBan, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTenPhongBan, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSDT, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 443);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2065, 230);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenPhongBan.Enabled = false;
            this.txtTenPhongBan.Location = new System.Drawing.Point(783, 49);
            this.txtTenPhongBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(781, 37);
            this.txtTenPhongBan.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(782, 141);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(783, 37);
            this.txtSDT.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPhongBan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.menucontrol1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2073, 676);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhongBan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongBan.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPhongBan.Location = new System.Drawing.Point(4, 89);
            this.dgvPhongBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPhongBan.MultiSelect = false;
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.RowHeadersWidth = 62;
            this.dgvPhongBan.RowTemplate.Height = 28;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(2065, 348);
            this.dgvPhongBan.TabIndex = 3;
            // 
            // menucontrol1
            // 
            this.menucontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menucontrol1.Location = new System.Drawing.Point(3, 3);
            this.menucontrol1.Name = "menucontrol1";
            this.menucontrol1.Size = new System.Drawing.Size(2067, 80);
            this.menucontrol1.TabIndex = 13;
            this.menucontrol1.ButtonClicked += new DynamicControl.menucontrol.ButtonClickedHandler(this.menucontrol1_ButtonClicked);
            // 
            // frmPhongBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(2073, 676);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhongBan";
            this.Text = "QUẢN LÝ PHÒNG BAN";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblTongNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTongNV;
        private System.Windows.Forms.TextBox txtMaPhongBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DynamicControl.menucontrol menucontrol1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dgvPhongBan;
    }
}

