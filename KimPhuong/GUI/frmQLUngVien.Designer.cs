
namespace KimPhuong.GUI
{
    partial class frmQLUngVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_QLUngVien = new Sunny.UI.UIDataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_SDTUV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_TrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_HoTenUV = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_EmailUV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_ViTriUT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_NgayUT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_UploadFileCV = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_FilePath = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menu_QLUngVien = new DynamicControl.menucontrol2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLUngVien)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_QLUngVien
            // 
            this.dgv_QLUngVien.AllowUserToAddRows = false;
            this.dgv_QLUngVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_QLUngVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_QLUngVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QLUngVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_QLUngVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_QLUngVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_QLUngVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_QLUngVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_QLUngVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_QLUngVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_QLUngVien.EnableHeadersVisualStyles = false;
            this.dgv_QLUngVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv_QLUngVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_QLUngVien.Location = new System.Drawing.Point(3, 3);
            this.dgv_QLUngVien.Name = "dgv_QLUngVien";
            this.dgv_QLUngVien.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_QLUngVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_QLUngVien.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv_QLUngVien.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_QLUngVien.RowTemplate.Height = 28;
            this.dgv_QLUngVien.SelectedIndex = -1;
            this.dgv_QLUngVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QLUngVien.Size = new System.Drawing.Size(1499, 295);
            this.dgv_QLUngVien.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_QLUngVien.TabIndex = 5;
            this.dgv_QLUngVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLUngVien_CellContentClick);
            this.dgv_QLUngVien.SelectionChanged += new System.EventHandler(this.dgv_QLUngVien_SelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.menu_QLUngVien, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 352);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1508, 58);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // txt_SDTUV
            // 
            this.txt_SDTUV.BorderRadius = 15;
            this.txt_SDTUV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDTUV.DefaultText = "";
            this.txt_SDTUV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SDTUV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SDTUV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SDTUV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SDTUV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SDTUV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDTUV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SDTUV.Location = new System.Drawing.Point(184, 148);
            this.txt_SDTUV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SDTUV.Name = "txt_SDTUV";
            this.txt_SDTUV.PasswordChar = '\0';
            this.txt_SDTUV.PlaceholderText = "";
            this.txt_SDTUV.SelectedText = "";
            this.txt_SDTUV.Size = new System.Drawing.Size(374, 48);
            this.txt_SDTUV.TabIndex = 12;
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cb_TrangThai.BorderRadius = 15;
            this.cb_TrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_TrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_TrangThai.ItemHeight = 30;
            this.cb_TrangThai.Items.AddRange(new object[] {
            "Chờ phỏng vấn",
            "Đã phỏng vấn",
            "Đậu phỏng vấn"});
            this.cb_TrangThai.Location = new System.Drawing.Point(989, 75);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(374, 36);
            this.cb_TrangThai.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dgv_QLUngVien, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 416);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1505, 301);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // txt_HoTenUV
            // 
            this.txt_HoTenUV.BorderRadius = 15;
            this.txt_HoTenUV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTenUV.DefaultText = "";
            this.txt_HoTenUV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_HoTenUV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_HoTenUV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HoTenUV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HoTenUV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HoTenUV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HoTenUV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HoTenUV.Location = new System.Drawing.Point(184, 4);
            this.txt_HoTenUV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTenUV.Name = "txt_HoTenUV";
            this.txt_HoTenUV.PasswordChar = '\0';
            this.txt_HoTenUV.PlaceholderText = "";
            this.txt_HoTenUV.SelectedText = "";
            this.txt_HoTenUV.Size = new System.Drawing.Size(374, 48);
            this.txt_HoTenUV.TabIndex = 2;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(3, 147);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(129, 26);
            this.guna2HtmlLabel8.TabIndex = 6;
            this.guna2HtmlLabel8.Text = "Số điện thoại";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(3, 75);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(56, 26);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Email";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(3, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(65, 26);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Họ tên";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(754, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(153, 26);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Vị trí ứng tuyển";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(754, 75);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(203, 26);
            this.guna2HtmlLabel5.TabIndex = 3;
            this.guna2HtmlLabel5.Text = "Trạng thái ứng tuyển";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(754, 147);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(154, 26);
            this.guna2HtmlLabel7.TabIndex = 5;
            this.guna2HtmlLabel7.Text = "Ngày ứng tuyển";
            // 
            // txt_EmailUV
            // 
            this.txt_EmailUV.BorderRadius = 15;
            this.txt_EmailUV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmailUV.DefaultText = "";
            this.txt_EmailUV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EmailUV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EmailUV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmailUV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmailUV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmailUV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_EmailUV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmailUV.Location = new System.Drawing.Point(184, 76);
            this.txt_EmailUV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_EmailUV.Name = "txt_EmailUV";
            this.txt_EmailUV.PasswordChar = '\0';
            this.txt_EmailUV.PlaceholderText = "";
            this.txt_EmailUV.SelectedText = "";
            this.txt_EmailUV.Size = new System.Drawing.Size(374, 48);
            this.txt_EmailUV.TabIndex = 7;
            // 
            // cb_ViTriUT
            // 
            this.cb_ViTriUT.BackColor = System.Drawing.Color.Transparent;
            this.cb_ViTriUT.BorderRadius = 15;
            this.cb_ViTriUT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ViTriUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ViTriUT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ViTriUT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ViTriUT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_ViTriUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_ViTriUT.ItemHeight = 30;
            this.cb_ViTriUT.Location = new System.Drawing.Point(989, 3);
            this.cb_ViTriUT.Name = "cb_ViTriUT";
            this.cb_ViTriUT.Size = new System.Drawing.Size(374, 36);
            this.cb_ViTriUT.TabIndex = 8;
            // 
            // dtp_NgayUT
            // 
            this.dtp_NgayUT.BorderRadius = 15;
            this.dtp_NgayUT.Checked = true;
            this.dtp_NgayUT.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayUT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtp_NgayUT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtp_NgayUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayUT.Location = new System.Drawing.Point(989, 147);
            this.dtp_NgayUT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayUT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayUT.Name = "dtp_NgayUT";
            this.dtp_NgayUT.Size = new System.Drawing.Size(374, 51);
            this.dtp_NgayUT.TabIndex = 10;
            this.dtp_NgayUT.Value = new System.DateTime(2024, 12, 1, 21, 49, 39, 776);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.06897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.86472F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.64987F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.54907F));
            this.tableLayoutPanel1.Controls.Add(this.cb_TrangThai, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_HoTenUV, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_EmailUV, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_ViTriUT, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_NgayUT, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_SDTUV, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.guna2HtmlLabel8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_UploadFileCV, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_FilePath, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1508, 288);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(3, 219);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(104, 26);
            this.guna2HtmlLabel6.TabIndex = 4;
            this.guna2HtmlLabel6.Text = "Upload CV";
            // 
            // btn_UploadFileCV
            // 
            this.btn_UploadFileCV.BorderRadius = 15;
            this.btn_UploadFileCV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_UploadFileCV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_UploadFileCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_UploadFileCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_UploadFileCV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_UploadFileCV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UploadFileCV.ForeColor = System.Drawing.Color.White;
            this.btn_UploadFileCV.Location = new System.Drawing.Point(184, 219);
            this.btn_UploadFileCV.Name = "btn_UploadFileCV";
            this.btn_UploadFileCV.Size = new System.Drawing.Size(180, 45);
            this.btn_UploadFileCV.TabIndex = 13;
            this.btn_UploadFileCV.Text = "Tải CV";
            this.btn_UploadFileCV.Click += new System.EventHandler(this.btn_UploadFileCV_Click);
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FilePath.Location = new System.Drawing.Point(989, 219);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(88, 18);
            this.lbl_FilePath.TabIndex = 14;
            this.lbl_FilePath.Text = "Đường dẫn file";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(599, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(319, 40);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "QUẢN LÝ ỨNG VIÊN";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menu_QLUngVien
            // 
            this.menu_QLUngVien.Location = new System.Drawing.Point(3, 2);
            this.menu_QLUngVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu_QLUngVien.Name = "menu_QLUngVien";
            this.menu_QLUngVien.Size = new System.Drawing.Size(1502, 54);
            this.menu_QLUngVien.TabIndex = 0;
            this.menu_QLUngVien.ButtonClicked += new DynamicControl.menucontrol2.ButtonClickedHandler(this.menu_QLUngVien_ButtonClicked);
            // 
            // frmQLUngVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1532, 729);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "frmQLUngVien";
            this.Text = "Quản lý ứng viên";
            this.Load += new System.EventHandler(this.frmQLUngVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLUngVien)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIDataGridView dgv_QLUngVien;
        private DynamicControl.menucontrol2 menu_QLUngVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_SDTUV;
        private Guna.UI2.WinForms.Guna2ComboBox cb_TrangThai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_HoTenUV;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txt_EmailUV;
        private Guna.UI2.WinForms.Guna2ComboBox cb_ViTriUT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_NgayUT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_UploadFileCV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_FilePath;
    }
}