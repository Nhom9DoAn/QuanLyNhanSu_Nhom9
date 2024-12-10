
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
            this.menucontrol1 = new DynamicControl.menucontrol();
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
            this.lblMaNV.Location = new System.Drawing.Point(15, 0);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(167, 86);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenNV.Location = new System.Drawing.Point(15, 86);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(167, 86);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 172);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(167, 86);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChucVu.Location = new System.Drawing.Point(15, 344);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(167, 87);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Chức Vụ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.menucontrol1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1249, 71);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // menucontrol1
            // 
            this.menucontrol1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menucontrol1.Location = new System.Drawing.Point(4, 4);
            this.menucontrol1.Margin = new System.Windows.Forms.Padding(4);
            this.menucontrol1.Name = "menucontrol1";
            this.menucontrol1.Size = new System.Drawing.Size(1241, 53);
            this.menucontrol1.TabIndex = 0;
            // 
            // lblSDTNV
            // 
            this.lblSDTNV.AutoSize = true;
            this.lblSDTNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSDTNV.Location = new System.Drawing.Point(15, 258);
            this.lblSDTNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDTNV.Name = "lblSDTNV";
            this.lblSDTNV.Size = new System.Drawing.Size(167, 86);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.411067F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.93676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 1012);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 552);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1247, 458);
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
            this.grpCongTac.Size = new System.Drawing.Size(615, 454);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 21);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66742F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66616F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66616F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66616F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(607, 431);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblMaCTTTP
            // 
            this.lblMaCTTTP.AutoSize = true;
            this.lblMaCTTTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaCTTTP.Location = new System.Drawing.Point(15, 0);
            this.lblMaCTTTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaCTTTP.Name = "lblMaCTTTP";
            this.lblMaCTTTP.Size = new System.Drawing.Size(167, 107);
            this.lblMaCTTTP.TabIndex = 0;
            this.lblMaCTTTP.Text = "Mã Công Tác";
            this.lblMaCTTTP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDVCT
            // 
            this.lblDVCT.AutoSize = true;
            this.lblDVCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDVCT.Location = new System.Drawing.Point(15, 107);
            this.lblDVCT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDVCT.Name = "lblDVCT";
            this.lblDVCT.Size = new System.Drawing.Size(167, 107);
            this.lblDVCT.TabIndex = 1;
            this.lblDVCT.Text = "Đơn Vị Công Tác";
            this.lblDVCT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayBD.Location = new System.Drawing.Point(15, 214);
            this.lblNgayBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(167, 107);
            this.lblNgayBD.TabIndex = 2;
            this.lblNgayBD.Text = "Ngày Bắt Đầu";
            this.lblNgayBD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaCT.Location = new System.Drawing.Point(190, 2);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(400, 26);
            this.txtMaCT.TabIndex = 5;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayKT.Location = new System.Drawing.Point(15, 321);
            this.lblNgayKT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(167, 110);
            this.lblNgayKT.TabIndex = 8;
            this.lblNgayKT.Text = "Ngày Kết Thúc";
            this.lblNgayKT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(190, 323);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(400, 26);
            this.dtpNgayKetThuc.TabIndex = 11;
            // 
            // txtDonViCongTac
            // 
            this.txtDonViCongTac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonViCongTac.Location = new System.Drawing.Point(189, 109);
            this.txtDonViCongTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonViCongTac.Name = "txtDonViCongTac";
            this.txtDonViCongTac.Size = new System.Drawing.Size(402, 26);
            this.txtDonViCongTac.TabIndex = 17;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(189, 216);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(402, 26);
            this.dtpNgayBatDau.TabIndex = 18;
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.tableLayoutPanel4);
            this.grpNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNhanVien.Location = new System.Drawing.Point(627, 2);
            this.grpNhanVien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpNhanVien.Size = new System.Drawing.Size(616, 454);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 21);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(608, 431);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // cboMaNV
            // 
            this.cboMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(190, 2);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(401, 24);
            this.cboMaNV.TabIndex = 5;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNV.Location = new System.Drawing.Point(190, 88);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(401, 26);
            this.txtTenNV.TabIndex = 6;
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(190, 174);
            this.dtpNgaySinhNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(401, 26);
            this.dtpNgaySinhNV.TabIndex = 7;
            // 
            // masktxtSDTNV
            // 
            this.masktxtSDTNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masktxtSDTNV.Location = new System.Drawing.Point(190, 260);
            this.masktxtSDTNV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.masktxtSDTNV.Mask = "(999) 000-0000";
            this.masktxtSDTNV.Name = "masktxtSDTNV";
            this.masktxtSDTNV.Size = new System.Drawing.Size(401, 26);
            this.masktxtSDTNV.TabIndex = 8;
            // 
            // cboChucVu
            // 
            this.cboChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(190, 346);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(401, 24);
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
            this.dgvCongTac.Location = new System.Drawing.Point(3, 77);
            this.dgvCongTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCongTac.Name = "dgvCongTac";
            this.dgvCongTac.ReadOnly = true;
            this.dgvCongTac.RowHeadersWidth = 62;
            this.dgvCongTac.RowTemplate.Height = 28;
            this.dgvCongTac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongTac.Size = new System.Drawing.Size(1249, 471);
            this.dgvCongTac.TabIndex = 2;
            // 
            // frm_CongTac
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1255, 1012);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_CongTac";
            this.Text = "Quản lý công tác";
            this.tableLayoutPanel5.ResumeLayout(false);
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
        private DynamicControl.menucontrol menucontrol1;
    }
}