namespace PayrollMSsample
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.btnback = new System.Windows.Forms.Button();
            this.btnviewsdetails = new System.Windows.Forms.Button();
            this.btnviewedetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(783, 664);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(119, 47);
            this.btnback.TabIndex = 78;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnviewsdetails
            // 
            this.btnviewsdetails.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewsdetails.Location = new System.Drawing.Point(490, 309);
            this.btnviewsdetails.Name = "btnviewsdetails";
            this.btnviewsdetails.Size = new System.Drawing.Size(316, 122);
            this.btnviewsdetails.TabIndex = 77;
            this.btnviewsdetails.Text = "View Employee salary deatils";
            this.btnviewsdetails.UseVisualStyleBackColor = true;
            this.btnviewsdetails.Click += new System.EventHandler(this.btnviewsdetails_Click);
            // 
            // btnviewedetails
            // 
            this.btnviewedetails.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewedetails.Location = new System.Drawing.Point(107, 309);
            this.btnviewedetails.Name = "btnviewedetails";
            this.btnviewedetails.Size = new System.Drawing.Size(316, 122);
            this.btnviewedetails.TabIndex = 76;
            this.btnviewedetails.Text = "View Employee deatils";
            this.btnviewedetails.UseVisualStyleBackColor = true;
            this.btnviewedetails.Click += new System.EventHandler(this.btnviewedetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 55);
            this.label1.TabIndex = 75;
            this.label1.Text = "Welcome Employee page";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 751);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnviewsdetails);
            this.Controls.Add(this.btnviewedetails);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnviewsdetails;
        private System.Windows.Forms.Button btnviewedetails;
        private System.Windows.Forms.Label label1;
    }
}