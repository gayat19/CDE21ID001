
namespace FirstWinApplication
{
    partial class frmAddCustomer
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
            this.components = new System.ComponentModel.Container();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.pbShowData = new System.Windows.Forms.ProgressBar();
            this.timProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(235, 51);
            this.lblFName.MaximumSize = new System.Drawing.Size(0, 200);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(97, 25);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(383, 51);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(258, 31);
            this.txtFName.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(293, 527);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 34);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Customer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(383, 140);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(258, 31);
            this.txtLName.TabIndex = 4;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(235, 140);
            this.lblLName.MaximumSize = new System.Drawing.Size(0, 200);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(95, 25);
            this.lblLName.TabIndex = 3;
            this.lblLName.Text = "Last Name";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Agra",
            "Bangalore",
            "Chennai",
            "Delhi"});
            this.cmbCity.Location = new System.Drawing.Point(383, 208);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(182, 33);
            this.cmbCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(235, 216);
            this.lblCity.MaximumSize = new System.Drawing.Size(0, 200);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 25);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(514, 288);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(93, 29);
            this.rdbFemale.TabIndex = 8;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(367, 288);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(75, 29);
            this.rdbMale.TabIndex = 7;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(235, 288);
            this.lblGender.MaximumSize = new System.Drawing.Size(0, 200);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 25);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gender";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(750, 433);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(49, 25);
            this.lblDisplay.TabIndex = 10;
            this.lblDisplay.Text = "Data";
            // 
            // pbShowData
            // 
            this.pbShowData.Location = new System.Drawing.Point(235, 388);
            this.pbShowData.Name = "pbShowData";
            this.pbShowData.Size = new System.Drawing.Size(395, 34);
            this.pbShowData.TabIndex = 11;
            // 
            // timProgress
            // 
            this.timProgress.Interval = 1000;
            this.timProgress.Tick += new System.EventHandler(this.timProgress_Tick);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 724);
            this.Controls.Add(this.pbShowData);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFName);
            this.Name = "frmAddCustomer";
            this.Text = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ProgressBar pbShowData;
        private System.Windows.Forms.Timer timProgress;
    }
}