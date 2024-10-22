
namespace GUI
{
    partial class frm_CongTac
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
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnLoc = new System.Windows.Forms.ToolStripButton();
            this.btnTim = new System.Windows.Forms.ToolStripDropDownButton();
            this.tìmTheoMãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.lblSDTNV = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpCongTac = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaCTTTP = new System.Windows.Forms.Label();
            this.lblDVCT = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtDonViCongTac = new System.Windows.Forms.TextBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dtpNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.masktxtSDTNV = new System.Windows.Forms.MaskedTextBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.dgvCongTac = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpCongTac.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpNhanVien.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongTac)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaNV.Location = new System.Drawing.Point(11, 0);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(106, 48);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenNV.Location = new System.Drawing.Point(11, 48);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(106, 48);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgaySinh.Location = new System.Drawing.Point(11, 96);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(106, 48);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChucVu.Location = new System.Drawing.Point(11, 192);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(106, 52);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Chức Vụ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.toolStrip, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(830, 32);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
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
            this.toolStrip.Size = new System.Drawing.Size(830, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "Menu";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnThem
            // 
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnThem.Size = new System.Drawing.Size(55, 24);
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnXoa.Size = new System.Drawing.Size(44, 24);
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnSua.Size = new System.Drawing.Size(43, 24);
            this.btnSua.Text = "Sửa";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnRefresh.Size = new System.Drawing.Size(67, 24);
            this.btnRefresh.Text = "Refresh";
            // 
            // btnLoc
            // 
            this.btnLoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(36, 24);
            this.btnLoc.Text = "Lọc";
            // 
            // btnTim
            // 
            this.btnTim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmTheoMãToolStripMenuItem,
            this.tìmTheoNgàyToolStripMenuItem});
            this.btnTim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnTim.Size = new System.Drawing.Size(53, 24);
            this.btnTim.Text = "Tìm";
            // 
            // tìmTheoMãToolStripMenuItem
            // 
            this.tìmTheoMãToolStripMenuItem.Name = "tìmTheoMãToolStripMenuItem";
            this.tìmTheoMãToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.tìmTheoMãToolStripMenuItem.Text = "Tìm Theo Đơn Vị Công Tác";
            // 
            // tìmTheoNgàyToolStripMenuItem
            // 
            this.tìmTheoNgàyToolStripMenuItem.Name = "tìmTheoNgàyToolStripMenuItem";
            this.tìmTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.tìmTheoNgàyToolStripMenuItem.Text = "Tìm Theo Ngày";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnLuu.Size = new System.Drawing.Size(42, 24);
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnHuy.Size = new System.Drawing.Size(44, 24);
            this.btnHuy.Text = "Hủy";
            // 
            // lblSDTNV
            // 
            this.lblSDTNV.AutoSize = true;
            this.lblSDTNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSDTNV.Location = new System.Drawing.Point(11, 144);
            this.lblSDTNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDTNV.Name = "lblSDTNV";
            this.lblSDTNV.Size = new System.Drawing.Size(106, 48);
            this.lblSDTNV.TabIndex = 3;
            this.lblSDTNV.Text = "Số Điện Thoại";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvCongTac, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.23053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.13084F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 592);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.grpCongTac, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpNhanVien, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 323);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(828, 267);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // grpCongTac
            // 
            this.grpCongTac.Controls.Add(this.tableLayoutPanel3);
            this.grpCongTac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCongTac.Location = new System.Drawing.Point(4, 2);
            this.grpCongTac.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpCongTac.Name = "grpCongTac";
            this.grpCongTac.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpCongTac.Size = new System.Drawing.Size(406, 263);
            this.grpCongTac.TabIndex = 0;
            this.grpCongTac.TabStop = false;
            this.grpCongTac.Text = "Thông tin công tác";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.84615F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.30769F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
            this.tableLayoutPanel3.Controls.Add(this.lblMaCTTTP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDVCT, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblNgayBD, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtMaCT, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNgayKT, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.dtpNgayKetThuc, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtDonViCongTac, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpNgayBatDau, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 17);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66742F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66616F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66616F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66616F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(398, 244);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblMaCTTTP
            // 
            this.lblMaCTTTP.AutoSize = true;
            this.lblMaCTTTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaCTTTP.Location = new System.Drawing.Point(11, 0);
            this.lblMaCTTTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaCTTTP.Name = "lblMaCTTTP";
            this.lblMaCTTTP.Size = new System.Drawing.Size(106, 61);
            this.lblMaCTTTP.TabIndex = 0;
            this.lblMaCTTTP.Text = "Mã Công Tác";
            this.lblMaCTTTP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDVCT
            // 
            this.lblDVCT.AutoSize = true;
            this.lblDVCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDVCT.Location = new System.Drawing.Point(11, 61);
            this.lblDVCT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDVCT.Name = "lblDVCT";
            this.lblDVCT.Size = new System.Drawing.Size(106, 60);
            this.lblDVCT.TabIndex = 1;
            this.lblDVCT.Text = "Đơn Vị Công Tác";
            this.lblDVCT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayBD.Location = new System.Drawing.Point(11, 121);
            this.lblNgayBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(106, 60);
            this.lblNgayBD.TabIndex = 2;
            this.lblNgayBD.Text = "Ngày Bắt Đầu";
            this.lblNgayBD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaCT.Location = new System.Drawing.Point(125, 2);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(259, 22);
            this.txtMaCT.TabIndex = 5;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayKT.Location = new System.Drawing.Point(11, 181);
            this.lblNgayKT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(106, 63);
            this.lblNgayKT.TabIndex = 8;
            this.lblNgayKT.Text = "Ngày Kết Thúc";
            this.lblNgayKT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(125, 183);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(259, 22);
            this.dtpNgayKetThuc.TabIndex = 11;
            // 
            // txtDonViCongTac
            // 
            this.txtDonViCongTac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonViCongTac.Location = new System.Drawing.Point(124, 63);
            this.txtDonViCongTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonViCongTac.Name = "txtDonViCongTac";
            this.txtDonViCongTac.Size = new System.Drawing.Size(261, 22);
            this.txtDonViCongTac.TabIndex = 17;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(124, 123);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(261, 22);
            this.dtpNgayBatDau.TabIndex = 18;
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.tableLayoutPanel4);
            this.grpNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNhanVien.Location = new System.Drawing.Point(418, 2);
            this.grpNhanVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpNhanVien.Size = new System.Drawing.Size(406, 263);
            this.grpNhanVien.TabIndex = 1;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "Thông tin nhân viên";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.84615F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.30769F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
            this.tableLayoutPanel4.Controls.Add(this.lblMaNV, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTenNV, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblNgaySinh, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblSDTNV, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblChucVu, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.cboMaNV, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtTenNV, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.dtpNgaySinhNV, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.masktxtSDTNV, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.cboChucVu, 2, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 17);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(398, 244);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // cboMaNV
            // 
            this.cboMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(125, 2);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(259, 24);
            this.cboMaNV.TabIndex = 5;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNV.Location = new System.Drawing.Point(125, 50);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(259, 22);
            this.txtTenNV.TabIndex = 6;
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(125, 98);
            this.dtpNgaySinhNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(259, 22);
            this.dtpNgaySinhNV.TabIndex = 7;
            // 
            // masktxtSDTNV
            // 
            this.masktxtSDTNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masktxtSDTNV.Location = new System.Drawing.Point(125, 146);
            this.masktxtSDTNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.masktxtSDTNV.Mask = "(999) 000-0000";
            this.masktxtSDTNV.Name = "masktxtSDTNV";
            this.masktxtSDTNV.Size = new System.Drawing.Size(259, 22);
            this.masktxtSDTNV.TabIndex = 8;
            // 
            // cboChucVu
            // 
            this.cboChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(125, 194);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(259, 24);
            this.cboChucVu.TabIndex = 9;
            // 
            // dgvCongTac
            // 
            this.dgvCongTac.AllowUserToAddRows = false;
            this.dgvCongTac.AllowUserToDeleteRows = false;
            this.dgvCongTac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongTac.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongTac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongTac.Location = new System.Drawing.Point(3, 38);
            this.dgvCongTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCongTac.Name = "dgvCongTac";
            this.dgvCongTac.ReadOnly = true;
            this.dgvCongTac.RowHeadersWidth = 62;
            this.dgvCongTac.RowTemplate.Height = 28;
            this.dgvCongTac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongTac.Size = new System.Drawing.Size(830, 281);
            this.dgvCongTac.TabIndex = 2;
            // 
            // frm_CongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_CongTac";
            this.Text = "Quản lý công tác";
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpCongTac.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.grpNhanVien.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongTac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnLoc;
        private System.Windows.Forms.ToolStripDropDownButton btnTim;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoMãToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.Label lblSDTNV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpCongTac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblMaCTTTP;
        private System.Windows.Forms.Label lblDVCT;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.TextBox txtDonViCongTac;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhNV;
        private System.Windows.Forms.MaskedTextBox masktxtSDTNV;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.DataGridView dgvCongTac;
    }
}