namespace KimPhuong.GUI
{
    partial class frmNghiPhep
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
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.masktxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvNghiPhep = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpNghiPhep = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaNP = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.radChuaDuyet = new System.Windows.Forms.RadioButton();
            this.radDaDuyet = new System.Windows.Forms.RadioButton();
            this.txtMaNP = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.tìmTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmTheoMãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTim = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLoc = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.grpNhanVien.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiPhep)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpNghiPhep.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.tableLayoutPanel4);
            this.grpNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNhanVien.Font = new System.Drawing.Font("Arial", 13F);
            this.grpNhanVien.Location = new System.Drawing.Point(811, 8);
            this.grpNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.grpNhanVien.Size = new System.Drawing.Size(799, 305);
            this.grpNhanVien.TabIndex = 1;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "Thông tin nhân viên";
            this.grpNhanVien.Enter += new System.EventHandler(this.grpNhanVien_Enter);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.tableLayoutPanel4.Controls.Add(this.lblMaNV, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTenNV, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblNgaySinh, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblSDT, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblChucVu, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.cboMaNV, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.cboChucVu, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.dtpNgaySinh, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtTenNV, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.masktxtSDT, 2, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 34);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.3968254F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.3968254F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(791, 267);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaNV.Location = new System.Drawing.Point(27, 1);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(241, 31);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã Nhân Viên";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaNV.Click += new System.EventHandler(this.lblMaNV_Click);
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenNV.Location = new System.Drawing.Point(27, 53);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(241, 31);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "Tên Nhân Viên";
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTenNV.Click += new System.EventHandler(this.lblTenNV_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNgaySinh.Location = new System.Drawing.Point(27, 105);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(241, 31);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNgaySinh.Click += new System.EventHandler(this.lblNgaySinh_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSDT.Location = new System.Drawing.Point(27, 157);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(241, 31);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Số Điện Thoại";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSDT.Click += new System.EventHandler(this.lblSDT_Click);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChucVu.Location = new System.Drawing.Point(27, 209);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(241, 31);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Chức Vụ";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblChucVu.Click += new System.EventHandler(this.lblChucVu_Click);
            // 
            // cboMaNV
            // 
            this.cboMaNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(274, 3);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(488, 39);
            this.cboMaNV.TabIndex = 5;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // cboChucVu
            // 
            this.cboChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(274, 211);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(488, 39);
            this.cboChucVu.TabIndex = 6;
            this.cboChucVu.SelectedIndexChanged += new System.EventHandler(this.cboChucVu_SelectedIndexChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(274, 107);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(488, 37);
            this.dtpNgaySinh.TabIndex = 7;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenNV.Location = new System.Drawing.Point(274, 55);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(488, 37);
            this.txtTenNV.TabIndex = 8;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // masktxtSDT
            // 
            this.masktxtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masktxtSDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.masktxtSDT.Location = new System.Drawing.Point(274, 159);
            this.masktxtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.masktxtSDT.Mask = "(999) 000-0000";
            this.masktxtSDT.Name = "masktxtSDT";
            this.masktxtSDT.Size = new System.Drawing.Size(488, 37);
            this.masktxtSDT.TabIndex = 9;
            this.masktxtSDT.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.masktxtSDT_MaskInputRejected);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvNghiPhep, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1622, 650);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dgvNghiPhep
            // 
            this.dgvNghiPhep.AllowUserToAddRows = false;
            this.dgvNghiPhep.AllowUserToDeleteRows = false;
            this.dgvNghiPhep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNghiPhep.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNghiPhep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNghiPhep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNghiPhep.Location = new System.Drawing.Point(4, 4);
            this.dgvNghiPhep.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNghiPhep.Name = "dgvNghiPhep";
            this.dgvNghiPhep.ReadOnly = true;
            this.dgvNghiPhep.RowHeadersWidth = 62;
            this.dgvNghiPhep.RowTemplate.Height = 28;
            this.dgvNghiPhep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNghiPhep.Size = new System.Drawing.Size(1614, 317);
            this.dgvNghiPhep.TabIndex = 0;
            this.dgvNghiPhep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNghiPhep_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.grpNghiPhep, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.grpNhanVien, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 329);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.555424F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.44457F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1614, 317);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // grpNghiPhep
            // 
            this.grpNghiPhep.Controls.Add(this.tableLayoutPanel3);
            this.grpNghiPhep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNghiPhep.Font = new System.Drawing.Font("Arial", 13F);
            this.grpNghiPhep.Location = new System.Drawing.Point(4, 8);
            this.grpNghiPhep.Margin = new System.Windows.Forms.Padding(4);
            this.grpNghiPhep.Name = "grpNghiPhep";
            this.grpNghiPhep.Padding = new System.Windows.Forms.Padding(4);
            this.grpNghiPhep.Size = new System.Drawing.Size(799, 305);
            this.grpNghiPhep.TabIndex = 0;
            this.grpNghiPhep.TabStop = false;
            this.grpNghiPhep.Text = "Thông tin nghỉ phép";
            this.grpNghiPhep.Enter += new System.EventHandler(this.grpNghiPhep_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.tableLayoutPanel3.Controls.Add(this.lblMaNP, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblTuNgay, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblDenNgay, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblLyDo, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblTinhTrang, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.dtpTuNgay, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtpDenNgay, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtMaNP, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtLyDo, 2, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 34);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.3968254F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.3968254F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(791, 267);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // lblMaNP
            // 
            this.lblMaNP.AutoSize = true;
            this.lblMaNP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaNP.Location = new System.Drawing.Point(27, 1);
            this.lblMaNP.Name = "lblMaNP";
            this.lblMaNP.Size = new System.Drawing.Size(241, 31);
            this.lblMaNP.TabIndex = 0;
            this.lblMaNP.Text = "Mã Nghỉ Phép";
            this.lblMaNP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaNP.Click += new System.EventHandler(this.lblMaNP_Click);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTuNgay.Location = new System.Drawing.Point(27, 53);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(241, 31);
            this.lblTuNgay.TabIndex = 1;
            this.lblTuNgay.Text = "Từ Ngày";
            this.lblTuNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTuNgay.Click += new System.EventHandler(this.lblTuNgay_Click);
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDenNgay.Location = new System.Drawing.Point(27, 105);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(241, 31);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến Ngày";
            this.lblDenNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDenNgay.Click += new System.EventHandler(this.lblDenNgay_Click);
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLyDo.Location = new System.Drawing.Point(27, 157);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(241, 31);
            this.lblLyDo.TabIndex = 3;
            this.lblLyDo.Text = "Lý Do";
            this.lblLyDo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLyDo.Click += new System.EventHandler(this.lblLyDo_Click);
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTinhTrang.Location = new System.Drawing.Point(27, 209);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(241, 31);
            this.lblTinhTrang.TabIndex = 4;
            this.lblTinhTrang.Text = "Tình Trạng";
            this.lblTinhTrang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTinhTrang.Click += new System.EventHandler(this.lblTinhTrang_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(274, 55);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(488, 37);
            this.dtpTuNgay.TabIndex = 5;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(274, 107);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(488, 37);
            this.dtpDenNgay.TabIndex = 6;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.radChuaDuyet, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.radDaDuyet, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(274, 211);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(488, 48);
            this.tableLayoutPanel5.TabIndex = 7;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // radChuaDuyet
            // 
            this.radChuaDuyet.AutoSize = true;
            this.radChuaDuyet.Dock = System.Windows.Forms.DockStyle.Top;
            this.radChuaDuyet.Location = new System.Drawing.Point(3, 2);
            this.radChuaDuyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radChuaDuyet.Name = "radChuaDuyet";
            this.radChuaDuyet.Size = new System.Drawing.Size(238, 35);
            this.radChuaDuyet.TabIndex = 0;
            this.radChuaDuyet.TabStop = true;
            this.radChuaDuyet.Text = "Chưa duyệt";
            this.radChuaDuyet.UseVisualStyleBackColor = true;
            this.radChuaDuyet.CheckedChanged += new System.EventHandler(this.radChuaDuyet_CheckedChanged);
            // 
            // radDaDuyet
            // 
            this.radDaDuyet.AutoSize = true;
            this.radDaDuyet.Dock = System.Windows.Forms.DockStyle.Top;
            this.radDaDuyet.Location = new System.Drawing.Point(247, 2);
            this.radDaDuyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDaDuyet.Name = "radDaDuyet";
            this.radDaDuyet.Size = new System.Drawing.Size(238, 35);
            this.radDaDuyet.TabIndex = 1;
            this.radDaDuyet.TabStop = true;
            this.radDaDuyet.Text = "Đã duyệt";
            this.radDaDuyet.UseVisualStyleBackColor = true;
            this.radDaDuyet.CheckedChanged += new System.EventHandler(this.radDaDuyet_CheckedChanged);
            // 
            // txtMaNP
            // 
            this.txtMaNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaNP.Location = new System.Drawing.Point(274, 3);
            this.txtMaNP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNP.Name = "txtMaNP";
            this.txtMaNP.Size = new System.Drawing.Size(488, 37);
            this.txtMaNP.TabIndex = 8;
            this.txtMaNP.TextChanged += new System.EventHandler(this.txtMaNP_TextChanged);
            // 
            // txtLyDo
            // 
            this.txtLyDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLyDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLyDo.Location = new System.Drawing.Point(274, 159);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(488, 37);
            this.txtLyDo.TabIndex = 9;
            this.txtLyDo.TextChanged += new System.EventHandler(this.txtLyDo_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnHuy.Size = new System.Drawing.Size(53, 29);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tìmTheoNgàyToolStripMenuItem
            // 
            this.tìmTheoNgàyToolStripMenuItem.Name = "tìmTheoNgàyToolStripMenuItem";
            this.tìmTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.tìmTheoNgàyToolStripMenuItem.Text = "Tìm Theo Ngày";
            this.tìmTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.tìmTheoNgàyToolStripMenuItem_Click);
            // 
            // tìmTheoMãToolStripMenuItem
            // 
            this.tìmTheoMãToolStripMenuItem.Name = "tìmTheoMãToolStripMenuItem";
            this.tìmTheoMãToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.tìmTheoMãToolStripMenuItem.Text = "Tìm Theo Mã Nghỉ Phép";
            this.tìmTheoMãToolStripMenuItem.Click += new System.EventHandler(this.tìmTheoMãToolStripMenuItem_Click);
            // 
            // btnTim
            // 
            this.btnTim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmTheoMãToolStripMenuItem,
            this.tìmTheoNgàyToolStripMenuItem});
            this.btnTim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnTim.Size = new System.Drawing.Size(64, 29);
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(43, 29);
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnRefresh.Size = new System.Drawing.Size(79, 29);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnSua.Size = new System.Drawing.Size(51, 29);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnXoa.Size = new System.Drawing.Size(52, 29);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnThem.Size = new System.Drawing.Size(65, 29);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnRefresh,
            this.btnLoc,
            this.btnTim,
            this.toolStripSeparator1,
            this.btnLuu,
            this.btnHuy});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(1622, 40);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "Menu";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnLuu.Size = new System.Drawing.Size(50, 29);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmNghiPhep
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1622, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmNghiPhep";
            this.Text = "frmNghiPhep";
            this.grpNhanVien.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiPhep)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpNghiPhep.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.MaskedTextBox masktxtSDT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvNghiPhep;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpNghiPhep;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblMaNP;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton radChuaDuyet;
        private System.Windows.Forms.RadioButton radDaDuyet;
        private System.Windows.Forms.TextBox txtMaNP;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoMãToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnTim;
        private System.Windows.Forms.ToolStripButton btnLoc;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLuu;
    }
}