namespace PayrollMSsample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.chekpw = new System.Windows.Forms.CheckBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.comtype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(488, 607);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(137, 64);
            this.btnexit.TabIndex = 32;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(249, 607);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(137, 64);
            this.btnlogin.TabIndex = 31;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // chekpw
            // 
            this.chekpw.AutoSize = true;
            this.chekpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekpw.Location = new System.Drawing.Point(600, 527);
            this.chekpw.Name = "chekpw";
            this.chekpw.Size = new System.Drawing.Size(179, 28);
            this.chekpw.TabIndex = 30;
            this.chekpw.Text = "Show password";
            this.chekpw.UseVisualStyleBackColor = true;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(415, 471);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(369, 22);
            this.txtpw.TabIndex = 29;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(415, 406);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(369, 22);
            this.txtname.TabIndex = 28;
            // 
            // comtype
            // 
            this.comtype.FormattingEnabled = true;
            this.comtype.Items.AddRange(new object[] {
            "System Administrator",
            "HR",
            "Employee"});
            this.comtype.Location = new System.Drawing.Point(415, 323);
            this.comtype.Name = "comtype";
            this.comtype.Size = new System.Drawing.Size(369, 24);
            this.comtype.TabIndex = 27;
            this.comtype.SelectedIndexChanged += new System.EventHandler(this.comtype_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 36);
            this.label5.TabIndex = 26;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "User Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 35);
            this.label2.TabIndex = 23;
            this.label2.Text = "Login System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "PAYROLL MANAGMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 751);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.chekpw);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.comtype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox chekpw;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox comtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

