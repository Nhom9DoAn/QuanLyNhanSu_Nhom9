namespace Main.ModelTrain
{
    partial class PredictForm

    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxExperienceLevel;
        private System.Windows.Forms.ComboBox comboBoxEmploymentType;
        private System.Windows.Forms.ComboBox comboBoxJobTitle;
        private System.Windows.Forms.ComboBox comboBoxCompanySize;
        private System.Windows.Forms.NumericUpDown numericUpDownRemoteRatio;
        private System.Windows.Forms.Button buttonPredict;


        /// <summary>
        /// Required designer variable.
        /// </summary>

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
            this.comboBoxExperienceLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxEmploymentType = new System.Windows.Forms.ComboBox();
            this.comboBoxJobTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxCompanySize = new System.Windows.Forms.ComboBox();
            this.numericUpDownRemoteRatio = new System.Windows.Forms.NumericUpDown();
            this.buttonPredict = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoteRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxExperienceLevel
            // 
            this.comboBoxExperienceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExperienceLevel.FormattingEnabled = true;
            this.comboBoxExperienceLevel.Location = new System.Drawing.Point(12, 12);
            this.comboBoxExperienceLevel.Name = "comboBoxExperienceLevel";
            this.comboBoxExperienceLevel.Size = new System.Drawing.Size(200, 21);
            this.comboBoxExperienceLevel.TabIndex = 0;
            // 
            // comboBoxEmploymentType
            // 
            this.comboBoxEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmploymentType.FormattingEnabled = true;
            this.comboBoxEmploymentType.Location = new System.Drawing.Point(12, 39);
            this.comboBoxEmploymentType.Name = "comboBoxEmploymentType";
            this.comboBoxEmploymentType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEmploymentType.TabIndex = 1;
            // 
            // comboBoxJobTitle
            // 
            this.comboBoxJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJobTitle.FormattingEnabled = true;
            this.comboBoxJobTitle.Location = new System.Drawing.Point(12, 66);
            this.comboBoxJobTitle.Name = "comboBoxJobTitle";
            this.comboBoxJobTitle.Size = new System.Drawing.Size(200, 21);
            this.comboBoxJobTitle.TabIndex = 2;
            // 
            // comboBoxCompanySize
            // 
            this.comboBoxCompanySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompanySize.FormattingEnabled = true;
            this.comboBoxCompanySize.Location = new System.Drawing.Point(12, 93);
            this.comboBoxCompanySize.Name = "comboBoxCompanySize";
            this.comboBoxCompanySize.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCompanySize.TabIndex = 3;
            // 
            // numericUpDownRemoteRatio
            // 
            this.numericUpDownRemoteRatio.Location = new System.Drawing.Point(12, 120);
            this.numericUpDownRemoteRatio.Name = "numericUpDownRemoteRatio";
            this.numericUpDownRemoteRatio.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownRemoteRatio.TabIndex = 4;
            this.numericUpDownRemoteRatio.ValueChanged += new System.EventHandler(this.numericUpDownRemoteRatio_ValueChanged);
            // 
            // buttonPredict
            // 
            this.buttonPredict.Location = new System.Drawing.Point(12, 146);
            this.buttonPredict.Name = "buttonPredict";
            this.buttonPredict.Size = new System.Drawing.Size(200, 23);
            this.buttonPredict.TabIndex = 5;
            this.buttonPredict.Text = "Predict";
            this.buttonPredict.UseVisualStyleBackColor = true;
            this.buttonPredict.Click += new System.EventHandler(this.buttonPredict_Click);
            // 
            // PredictForm
            // 
            this.ClientSize = new System.Drawing.Size(224, 181);
            this.Controls.Add(this.buttonPredict);
            this.Controls.Add(this.numericUpDownRemoteRatio);
            this.Controls.Add(this.comboBoxCompanySize);
            this.Controls.Add(this.comboBoxJobTitle);
            this.Controls.Add(this.comboBoxEmploymentType);
            this.Controls.Add(this.comboBoxExperienceLevel);
            this.Name = "PredictForm";
            this.Text = "Prediction Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoteRatio)).EndInit();
            this.ResumeLayout(false);

        }

    }

        #endregion
    }