namespace PayrollMSsample
{
    partial class HR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR));
            this.btnmngadminsdetail = new System.Windows.Forms.Button();
            this.btnviewhrdetails = new System.Windows.Forms.Button();
            this.btnviewhrsdetail = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnmngeemsalarydetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmngadminsdetail
            // 
            this.btnmngadminsdetail.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmngadminsdetail.Location = new System.Drawing.Point(339, 458);
            this.btnmngadminsdetail.Name = "btnmngadminsdetail";
            this.btnmngadminsdetail.Size = new System.Drawing.Size(329, 137);
            this.btnmngadminsdetail.TabIndex = 85;
            this.btnmngadminsdetail.Text = "Manage Admin Salary details";
            this.btnmngadminsdetail.UseVisualStyleBackColor = true;
            this.btnmngadminsdetail.Click += new System.EventHandler(this.btnmngadminsdetail_Click);
            // 
            // btnviewhrdetails
            // 
            this.btnviewhrdetails.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewhrdetails.Location = new System.Drawing.Point(703, 273);
            this.btnviewhrdetails.Name = "btnviewhrdetails";
            this.btnviewhrdetails.Size = new System.Drawing.Size(242, 131);
            this.btnviewhrdetails.TabIndex = 84;
            this.btnviewhrdetails.Text = "View HR details";
            this.btnviewhrdetails.UseVisualStyleBackColor = true;
            this.btnviewhrdetails.Click += new System.EventHandler(this.btnviewhrdetails_Click);
            // 
            // btnviewhrsdetail
            // 
            this.btnviewhrsdetail.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewhrsdetail.Location = new System.Drawing.Point(413, 267);
            this.btnviewhrsdetail.Name = "btnviewhrsdetail";
            this.btnviewhrsdetail.Size = new System.Drawing.Size(255, 137);
            this.btnviewhrsdetail.TabIndex = 83;
            this.btnviewhrsdetail.Text = "View HR salary details";
            this.btnviewhrsdetail.UseVisualStyleBackColor = true;
            this.btnviewhrsdetail.Click += new System.EventHandler(this.btnviewhrsdetail_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(853, 667);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(119, 53);
            this.btnexit.TabIndex = 82;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnmngeemsalarydetail
            // 
            this.btnmngeemsalarydetail.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmngeemsalarydetail.Location = new System.Drawing.Point(34, 267);
            this.btnmngeemsalarydetail.Name = "btnmngeemsalarydetail";
            this.btnmngeemsalarydetail.Size = new System.Drawing.Size(329, 137);
            this.btnmngeemsalarydetail.TabIndex = 81;
            this.btnmngeemsalarydetail.Text = "Manage Employee Salary details";
            this.btnmngeemsalarydetail.UseVisualStyleBackColor = true;
            this.btnmngeemsalarydetail.Click += new System.EventHandler(this.btnmngeemsalarydetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 55);
            this.label1.TabIndex = 79;
            this.label1.Text = "Welcome HR page";
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 751);
            this.Controls.Add(this.btnmngadminsdetail);
            this.Controls.Add(this.btnviewhrdetails);
            this.Controls.Add(this.btnviewhrsdetail);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnmngeemsalarydetail);
            this.Controls.Add(this.label1);
            this.Name = "HR";
            this.Text = "HR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmngadminsdetail;
        private System.Windows.Forms.Button btnviewhrdetails;
        private System.Windows.Forms.Button btnviewhrsdetail;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnmngeemsalarydetail;
        private System.Windows.Forms.Label label1;
    }
}