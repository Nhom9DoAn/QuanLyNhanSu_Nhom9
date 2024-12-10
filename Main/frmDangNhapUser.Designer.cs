namespace Main
{
    partial class frmDangNhapUser
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
            this.loginControl = new DynamicControl.DangNhapControl();
            this.SuspendLayout();
            // 
            // loginControl
            // 
            this.loginControl.BackColor = System.Drawing.Color.DimGray;
            this.loginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl.Location = new System.Drawing.Point(0, 0);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(1040, 323);
            this.loginControl.TabIndex = 0;
            this.loginControl.ButtonClicked += new DynamicControl.DangNhapControl.ButtonClickedHandler(this.dangNhapControl1_ButtonClicked);
            // 
            // frmDangNhapUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1040, 323);
            this.Controls.Add(this.loginControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhapUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);

        }

        #endregion

        private DynamicControl.DangNhapControl loginControl;
    }
}