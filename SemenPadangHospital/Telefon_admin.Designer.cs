namespace SemenPadangHospital
{
    partial class Telefon_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telefon_admin));
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bcNama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bcNomor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomor = new System.Windows.Forms.TextBox();
            this.dgv_telfon = new System.Windows.Forms.DataGridView();
            this.tbunit = new System.Windows.Forms.TextBox();
            this.tbtlpunit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telfon)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 31);
            this.button2.TabIndex = 3;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.dgv_telfon);
            this.groupBox1.Location = new System.Drawing.Point(381, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 446);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Unit SPH";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 25);
            this.tabControl1.Location = new System.Drawing.Point(6, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(245, 64);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.bcNama);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbNama);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(237, 31);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cari Nama";
            // 
            // bcNama
            // 
            this.bcNama.Location = new System.Drawing.Point(180, 6);
            this.bcNama.Name = "bcNama";
            this.bcNama.Size = new System.Drawing.Size(54, 23);
            this.bcNama.TabIndex = 3;
            this.bcNama.Text = "search";
            this.bcNama.UseVisualStyleBackColor = true;
            this.bcNama.Click += new System.EventHandler(this.bcNama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama :";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(53, 6);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(121, 20);
            this.tbNama.TabIndex = 1;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            this.tbNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNama_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.bcNomor);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbNomor);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(237, 31);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cari No.telp";
            // 
            // bcNomor
            // 
            this.bcNomor.Location = new System.Drawing.Point(180, 6);
            this.bcNomor.Name = "bcNomor";
            this.bcNomor.Size = new System.Drawing.Size(54, 23);
            this.bcNomor.TabIndex = 7;
            this.bcNomor.Text = "search";
            this.bcNomor.UseVisualStyleBackColor = true;
            this.bcNomor.Click += new System.EventHandler(this.bcNomor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nomor :";
            // 
            // tbNomor
            // 
            this.tbNomor.Location = new System.Drawing.Point(56, 6);
            this.tbNomor.Name = "tbNomor";
            this.tbNomor.Size = new System.Drawing.Size(120, 20);
            this.tbNomor.TabIndex = 4;
            this.tbNomor.TextChanged += new System.EventHandler(this.tbNomor_TextChanged);
            this.tbNomor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomor_KeyDown);
            // 
            // dgv_telfon
            // 
            this.dgv_telfon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telfon.Location = new System.Drawing.Point(6, 92);
            this.dgv_telfon.Name = "dgv_telfon";
            this.dgv_telfon.Size = new System.Drawing.Size(422, 348);
            this.dgv_telfon.TabIndex = 0;
            this.dgv_telfon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_telfon_CellClick);
            // 
            // tbunit
            // 
            this.tbunit.Location = new System.Drawing.Point(162, 172);
            this.tbunit.Name = "tbunit";
            this.tbunit.Size = new System.Drawing.Size(171, 20);
            this.tbunit.TabIndex = 4;
            this.tbunit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbtlpunit
            // 
            this.tbtlpunit.Location = new System.Drawing.Point(162, 198);
            this.tbtlpunit.Name = "tbtlpunit";
            this.tbtlpunit.Size = new System.Drawing.Size(171, 20);
            this.tbtlpunit.TabIndex = 5;
            this.tbtlpunit.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbtlpunit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbtlpunit_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama unit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nomor telp. Unit :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(113, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 31);
            this.button5.TabIndex = 10;
            this.button5.Text = "Simpan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbno
            // 
            this.tbno.Location = new System.Drawing.Point(339, 172);
            this.tbno.Name = "tbno";
            this.tbno.Size = new System.Drawing.Size(18, 20);
            this.tbno.TabIndex = 11;
            this.tbno.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Daftar nomor telfon unit";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(710, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 31);
            this.button6.TabIndex = 13;
            this.button6.Text = "Export ke Excel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Telefon_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(827, 508);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbno);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbtlpunit);
            this.Controls.Add(this.tbunit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Telefon_admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon_admin";
            this.Load += new System.EventHandler(this.Telefon_admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telfon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bcNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bcNomor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomor;
        private System.Windows.Forms.DataGridView dgv_telfon;
        private System.Windows.Forms.TextBox tbunit;
        private System.Windows.Forms.TextBox tbtlpunit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
    }
}