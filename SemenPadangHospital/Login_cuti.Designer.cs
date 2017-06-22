namespace SemenPadangHospital
{
    partial class Login_cuti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_cuti));
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbnip = new System.Windows.Forms.TextBox();
            this.btapply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbbtn = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(143, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Admin login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "User";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(94, 243);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(153, 20);
            this.tbpass.TabIndex = 10;
            this.tbpass.Text = "sisfo123";
            this.tbpass.UseSystemPasswordChar = true;
            this.tbpass.TextChanged += new System.EventHandler(this.tbpass_TextChanged);
            this.tbpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpass_KeyDown);
            // 
            // tbnip
            // 
            this.tbnip.Location = new System.Drawing.Point(94, 217);
            this.tbnip.Name = "tbnip";
            this.tbnip.Size = new System.Drawing.Size(153, 20);
            this.tbnip.TabIndex = 9;
            this.tbnip.Text = "admin";
            // 
            // btapply
            // 
            this.btapply.Location = new System.Drawing.Point(172, 269);
            this.btapply.Name = "btapply";
            this.btapply.Size = new System.Drawing.Size(75, 23);
            this.btapply.TabIndex = 7;
            this.btapply.Text = "Login";
            this.btapply.UseVisualStyleBackColor = true;
            this.btapply.Click += new System.EventHandler(this.btapply_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 31);
            this.button2.TabIndex = 14;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pbbtn
            // 
            this.pbbtn.Location = new System.Drawing.Point(143, 119);
            this.pbbtn.Name = "pbbtn";
            this.pbbtn.Size = new System.Drawing.Size(104, 10);
            this.pbbtn.TabIndex = 15;
            // 
            // Login_cuti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(393, 341);
            this.Controls.Add(this.pbbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbnip);
            this.Controls.Add(this.btapply);
            this.Name = "Login_cuti";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_cuti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbnip;
        private System.Windows.Forms.Button btapply;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar pbbtn;
    }
}