namespace PayrollMSsample
{
    partial class SystemAdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemAdminPage));
            this.btnmanageHRslry = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnviewslry = new System.Windows.Forms.Button();
            this.btnmanageHR = new System.Windows.Forms.Button();
            this.btnManageEm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmanageHRslry
            // 
            this.btnmanageHRslry.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageHRslry.Location = new System.Drawing.Point(542, 392);
            this.btnmanageHRslry.Name = "btnmanageHRslry";
            this.btnmanageHRslry.Size = new System.Drawing.Size(239, 124);
            this.btnmanageHRslry.TabIndex = 30;
            this.btnmanageHRslry.Text = "Manage HR Salaries Details";
            this.btnmanageHRslry.UseVisualStyleBackColor = true;
            this.btnmanageHRslry.Click += new System.EventHandler(this.btnmanageHRslry_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(781, 652);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 64);
            this.button5.TabIndex = 29;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(571, 652);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 64);
            this.button4.TabIndex = 28;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnviewslry
            // 
            this.btnviewslry.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewslry.Location = new System.Drawing.Point(170, 392);
            this.btnviewslry.Name = "btnviewslry";
            this.btnviewslry.Size = new System.Drawing.Size(242, 124);
            this.btnviewslry.TabIndex = 27;
            this.btnviewslry.Text = "View Salaries Details";
            this.btnviewslry.UseVisualStyleBackColor = true;
            this.btnviewslry.Click += new System.EventHandler(this.btnviewslry_Click);
            // 
            // btnmanageHR
            // 
            this.btnmanageHR.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageHR.Location = new System.Drawing.Point(542, 172);
            this.btnmanageHR.Name = "btnmanageHR";
            this.btnmanageHR.Size = new System.Drawing.Size(239, 124);
            this.btnmanageHR.TabIndex = 26;
            this.btnmanageHR.Text = "Manage HR";
            this.btnmanageHR.UseVisualStyleBackColor = true;
            this.btnmanageHR.Click += new System.EventHandler(this.btnmanageHR_Click);
            // 
            // btnManageEm
            // 
            this.btnManageEm.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEm.Location = new System.Drawing.Point(170, 172);
            this.btnManageEm.Name = "btnManageEm";
            this.btnManageEm.Size = new System.Drawing.Size(242, 124);
            this.btnManageEm.TabIndex = 25;
            this.btnManageEm.Text = "Manage Employee";
            this.btnManageEm.UseVisualStyleBackColor = true;
            this.btnManageEm.Click += new System.EventHandler(this.btnManageEm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 55);
            this.label1.TabIndex = 24;
            this.label1.Text = "Welcome Syestem Admin page";
            // 
            // SystemAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 751);
            this.Controls.Add(this.btnmanageHRslry);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnviewslry);
            this.Controls.Add(this.btnmanageHR);
            this.Controls.Add(this.btnManageEm);
            this.Controls.Add(this.label1);
            this.Name = "SystemAdminPage";
            this.Text = "SystemAdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmanageHRslry;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnviewslry;
        private System.Windows.Forms.Button btnmanageHR;
        private System.Windows.Forms.Button btnManageEm;
        private System.Windows.Forms.Label label1;
    }
}