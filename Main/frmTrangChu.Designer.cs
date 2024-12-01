namespace Main
{
    partial class frmTrangChu
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
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.lblTenDangNhap = new Sunny.UI.UILabel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Location = new System.Drawing.Point(0, 106);
            this.Aside.Size = new System.Drawing.Size(388, 729);
            this.Aside.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Aside_NodeMouseClick);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.lblTenDangNhap);
            this.Header.Controls.Add(this.uiAvatar1);
            this.Header.Size = new System.Drawing.Size(2236, 71);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(2173, 5);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTenDangNhap.Location = new System.Drawing.Point(1982, 22);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(185, 28);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "uiLabel1";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2236, 835);
            this.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrangChu";
            this.Text = "Trang chủ";
            this.TitleFont = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChu_FormClosing);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblTenDangNhap;
        private Sunny.UI.UIAvatar uiAvatar1;
    }
}

