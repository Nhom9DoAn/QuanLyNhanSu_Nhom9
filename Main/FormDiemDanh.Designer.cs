namespace Main
{
    partial class FormDiemDanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboPhongBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.dgvNhanVien = new Sunny.UI.UIDataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiTextBox3 = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPhongBan
            // 
            this.comboPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.comboPhongBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPhongBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboPhongBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboPhongBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPhongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboPhongBan.ItemHeight = 30;
            this.comboPhongBan.Location = new System.Drawing.Point(149, 118);
            this.comboPhongBan.Name = "comboPhongBan";
            this.comboPhongBan.Size = new System.Drawing.Size(151, 36);
            this.comboPhongBan.TabIndex = 24;
            this.comboPhongBan.SelectedIndexChanged += new System.EventHandler(this.comboPhongBan_SelectedIndexChanged);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(149, 48);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 23;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton2.Location = new System.Drawing.Point(363, 118);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 20;
            this.uiButton2.Text = "Tìm";
            this.uiButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // dgvNhanVien
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvNhanVien.ColumnHeadersHeight = 32;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(4, 175);
            this.dgvNhanVien.Name = "dgvNhanVien";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvNhanVien.SelectedIndex = -1;
            this.dgvNhanVien.Size = new System.Drawing.Size(474, 391);
            this.dgvNhanVien.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.TabIndex = 19;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã NV";
            this.maNV.Name = "maNV";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Hoten";
            this.Column1.HeaderText = "Tên NV";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenPB";
            this.Column2.HeaderText = "Tên PB";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.uiGroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.uiGroupBox1.Controls.Add(this.comboPhongBan);
            this.uiGroupBox1.Controls.Add(this.dgvNhanVien);
            this.uiGroupBox1.Controls.Add(this.uiTextBox1);
            this.uiGroupBox1.Controls.Add(this.uiButton2);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(23, 14);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(478, 570);
            this.uiGroupBox1.TabIndex = 25;
            this.uiGroupBox1.Text = "Tìm nhân viên";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiTextBox3);
            this.uiGroupBox2.Controls.Add(this.uiButton4);
            this.uiGroupBox2.Controls.Add(this.uiButton3);
            this.uiGroupBox2.Controls.Add(this.uiButton1);
            this.uiGroupBox2.Controls.Add(this.uiTextBox2);
            this.uiGroupBox2.Controls.Add(this.guna2HtmlLabel5);
            this.uiGroupBox2.Controls.Add(this.guna2HtmlLabel4);
            this.uiGroupBox2.Controls.Add(this.uiDatetimePicker1);
            this.uiGroupBox2.Controls.Add(this.guna2HtmlLabel1);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(508, 14);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(536, 570);
            this.uiGroupBox2.TabIndex = 26;
            this.uiGroupBox2.Text = "Điểm danh";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiGroupBox2.Click += new System.EventHandler(this.uiGroupBox2_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(117, 22);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Ngày điểm danh";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(13, 48);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(102, 22);
            this.guna2HtmlLabel2.TabIndex = 25;
            this.guna2HtmlLabel2.Text = "Tên nhân viên";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(13, 131);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(80, 22);
            this.guna2HtmlLabel3.TabIndex = 26;
            this.guna2HtmlLabel3.Text = "Phòng ban";
            // 
            // uiDatetimePicker1
            // 
            this.uiDatetimePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatetimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDatetimePicker1.Location = new System.Drawing.Point(162, 29);
            this.uiDatetimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker1.MaxLength = 19;
            this.uiDatetimePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker1.Name = "uiDatetimePicker1";
            this.uiDatetimePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePicker1.Size = new System.Drawing.Size(210, 29);
            this.uiDatetimePicker1.SymbolDropDown = 61555;
            this.uiDatetimePicker1.SymbolNormal = 61555;
            this.uiDatetimePicker1.SymbolSize = 24;
            this.uiDatetimePicker1.TabIndex = 1;
            this.uiDatetimePicker1.Text = "uiDatetimePicker1";
            this.uiDatetimePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker1.Value = new System.DateTime(2024, 12, 9, 19, 18, 23, 777);
            this.uiDatetimePicker1.Watermark = "";
            this.uiDatetimePicker1.ValueChanged += new Sunny.UI.UIDatetimePicker.OnDateTimeChanged(this.uiDatetimePicker1_ValueChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(15, 100);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(102, 22);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Tên nhân viên";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(15, 175);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(58, 22);
            this.guna2HtmlLabel5.TabIndex = 6;
            this.guna2HtmlLabel5.Text = "Ghi chú";
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBox2.Location = new System.Drawing.Point(162, 167);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Multiline = true;
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(338, 105);
            this.uiTextBox2.TabIndex = 7;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton1.Location = new System.Drawing.Point(383, 309);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(134, 45);
            this.uiButton1.TabIndex = 8;
            this.uiButton1.Text = "Vắng có phép";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton3.Location = new System.Drawing.Point(17, 309);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(120, 45);
            this.uiButton3.TabIndex = 9;
            this.uiButton3.Text = "Điểm danh vào";
            this.uiButton3.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton4.Location = new System.Drawing.Point(200, 309);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(122, 45);
            this.uiButton4.TabIndex = 10;
            this.uiButton4.Text = "Điểm danh ra";
            this.uiButton4.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // uiTextBox3
            // 
            this.uiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBox3.Location = new System.Drawing.Point(162, 100);
            this.uiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox3.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox3.Name = "uiTextBox3";
            this.uiTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox3.ShowText = false;
            this.uiTextBox3.Size = new System.Drawing.Size(210, 29);
            this.uiTextBox3.TabIndex = 11;
            this.uiTextBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox3.Watermark = "";
            // 
            // FormDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 608);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "FormDiemDanh";
            this.Text = "FormDiemDanh";
            this.Load += new System.EventHandler(this.FormDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboPhongBan;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIDataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Sunny.UI.UITextBox uiTextBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox uiTextBox3;
    }
}