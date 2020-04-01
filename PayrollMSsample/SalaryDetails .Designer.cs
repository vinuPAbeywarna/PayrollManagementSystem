namespace PayrollMSsample
{
    partial class SalaryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryDetails));
            this.btnadminslrydetails = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnhrsalarydetails = new System.Windows.Forms.Button();
            this.btnemsalarydetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadminslrydetails
            // 
            this.btnadminslrydetails.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminslrydetails.Location = new System.Drawing.Point(720, 274);
            this.btnadminslrydetails.Name = "btnadminslrydetails";
            this.btnadminslrydetails.Size = new System.Drawing.Size(242, 124);
            this.btnadminslrydetails.TabIndex = 61;
            this.btnadminslrydetails.Text = "Admin salary details";
            this.btnadminslrydetails.UseVisualStyleBackColor = true;
            this.btnadminslrydetails.Click += new System.EventHandler(this.btnadminslrydetails_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(800, 657);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(119, 47);
            this.btnback.TabIndex = 60;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnhrsalarydetails
            // 
            this.btnhrsalarydetails.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhrsalarydetails.Location = new System.Drawing.Point(390, 274);
            this.btnhrsalarydetails.Name = "btnhrsalarydetails";
            this.btnhrsalarydetails.Size = new System.Drawing.Size(242, 124);
            this.btnhrsalarydetails.TabIndex = 59;
            this.btnhrsalarydetails.Text = "HR salary details";
            this.btnhrsalarydetails.UseVisualStyleBackColor = true;
            this.btnhrsalarydetails.Click += new System.EventHandler(this.btnhrsalarydetails_Click);
            // 
            // btnemsalarydetails
            // 
            this.btnemsalarydetails.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemsalarydetails.Location = new System.Drawing.Point(37, 274);
            this.btnemsalarydetails.Name = "btnemsalarydetails";
            this.btnemsalarydetails.Size = new System.Drawing.Size(242, 124);
            this.btnemsalarydetails.TabIndex = 58;
            this.btnemsalarydetails.Text = "Employee Salary details";
            this.btnemsalarydetails.UseVisualStyleBackColor = true;
            this.btnemsalarydetails.Click += new System.EventHandler(this.btnemsalarydetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 55);
            this.label1.TabIndex = 57;
            this.label1.Text = "Salary Details";
            // 
            // SalaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 751);
            this.Controls.Add(this.btnadminslrydetails);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnhrsalarydetails);
            this.Controls.Add(this.btnemsalarydetails);
            this.Controls.Add(this.label1);
            this.Name = "SalaryDetails";
            this.Text = "SalaryDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadminslrydetails;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnhrsalarydetails;
        private System.Windows.Forms.Button btnemsalarydetails;
        private System.Windows.Forms.Label label1;
    }
}