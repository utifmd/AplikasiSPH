namespace SemenPadangHospital
{
    partial class Cuti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuti));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbcarinm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_cuti = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btreset = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpbatas = new System.Windows.Forms.DateTimePicker();
            this.dtpambil = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpcuti = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbsisa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpperiode = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtcuti = new System.Windows.Forms.DateTimePicker();
            this.dtperiode = new System.Windows.Forms.DateTimePicker();
            this.no = new System.Windows.Forms.TextBox();
            this.dtambil = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtbatas = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtkembali = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbsisa = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbnama_ = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuti)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tbcarinm);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(796, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari berdasarkan : ";
            // 
            // tbcarinm
            // 
            this.tbcarinm.Location = new System.Drawing.Point(126, 36);
            this.tbcarinm.Name = "tbcarinm";
            this.tbcarinm.Size = new System.Drawing.Size(155, 20);
            this.tbcarinm.TabIndex = 4;
            this.tbcarinm.TextChanged += new System.EventHandler(this.tbcarinm_TextChanged);
            this.tbcarinm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbcarinm_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama Karyawan";
            // 
            // dgv_cuti
            // 
            this.dgv_cuti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuti.Location = new System.Drawing.Point(12, 57);
            this.dgv_cuti.Name = "dgv_cuti";
            this.dgv_cuti.Size = new System.Drawing.Size(778, 366);
            this.dgv_cuti.TabIndex = 3;
            this.dgv_cuti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cuti_CellClick);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 31);
            this.button2.TabIndex = 4;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(316, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "DAFTAR CUTI KARYAWAN SPH";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1004, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Export ke Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(42, 21);
            this.tabControl1.Location = new System.Drawing.Point(796, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 276);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btreset);
            this.tabPage1.Controls.Add(this.btdelete);
            this.tabPage1.Controls.Add(this.btsave);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtpbatas);
            this.tabPage1.Controls.Add(this.dtpambil);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtpcuti);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbsisa);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbnama);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpperiode);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(300, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ambil";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(189, 209);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(48, 27);
            this.btreset.TabIndex = 38;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click_1);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(243, 209);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(48, 27);
            this.btdelete.TabIndex = 37;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(135, 209);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(48, 27);
            this.btsave.TabIndex = 35;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Batas kembali";
            // 
            // dtpbatas
            // 
            this.dtpbatas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpbatas.Location = new System.Drawing.Point(91, 149);
            this.dtpbatas.Name = "dtpbatas";
            this.dtpbatas.Size = new System.Drawing.Size(200, 20);
            this.dtpbatas.TabIndex = 31;
            // 
            // dtpambil
            // 
            this.dtpambil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpambil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpambil.Location = new System.Drawing.Point(91, 123);
            this.dtpambil.Name = "dtpambil";
            this.dtpambil.Size = new System.Drawing.Size(200, 20);
            this.dtpambil.TabIndex = 31;
            this.dtpambil.ValueChanged += new System.EventHandler(this.dtpambil_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ambil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Periode";
            // 
            // dtpcuti
            // 
            this.dtpcuti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcuti.Location = new System.Drawing.Point(91, 46);
            this.dtpcuti.Name = "dtpcuti";
            this.dtpcuti.Size = new System.Drawing.Size(200, 20);
            this.dtpcuti.TabIndex = 31;
            this.dtpcuti.Value = new System.DateTime(2016, 6, 23, 0, 0, 0, 0);
            this.dtpcuti.ValueChanged += new System.EventHandler(this.dtpcuti_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sisa cuti";
            // 
            // cbsisa
            // 
            this.cbsisa.FormattingEnabled = true;
            this.cbsisa.Items.AddRange(new object[] {
            "1 hari",
            "2 hari",
            "3 hari",
            "4 hari",
            "5 hari",
            "6 hari",
            "7 hari",
            "8 hari",
            "9 hari",
            "10 hari",
            "11 hari",
            "12 hari"});
            this.cbsisa.Location = new System.Drawing.Point(91, 96);
            this.cbsisa.Name = "cbsisa";
            this.cbsisa.Size = new System.Drawing.Size(121, 21);
            this.cbsisa.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cuti";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(91, 20);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(165, 20);
            this.tbnama.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Karyawan";
            // 
            // dtpperiode
            // 
            this.dtpperiode.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpperiode.Location = new System.Drawing.Point(91, 72);
            this.dtpperiode.Name = "dtpperiode";
            this.dtpperiode.Size = new System.Drawing.Size(200, 20);
            this.dtpperiode.TabIndex = 31;
            this.dtpperiode.Value = new System.DateTime(2016, 6, 23, 0, 0, 0, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtcuti);
            this.tabPage3.Controls.Add(this.dtperiode);
            this.tabPage3.Controls.Add(this.no);
            this.tabPage3.Controls.Add(this.dtambil);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.btupdate);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dtbatas);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.dtkembali);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.cmbsisa);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.tbnama_);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(282, 247);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kembali";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtcuti
            // 
            this.dtcuti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtcuti.Location = new System.Drawing.Point(91, 46);
            this.dtcuti.Name = "dtcuti";
            this.dtcuti.Size = new System.Drawing.Size(200, 20);
            this.dtcuti.TabIndex = 43;
            // 
            // dtperiode
            // 
            this.dtperiode.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtperiode.Location = new System.Drawing.Point(91, 71);
            this.dtperiode.Name = "dtperiode";
            this.dtperiode.Size = new System.Drawing.Size(200, 20);
            this.dtperiode.TabIndex = 42;
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(269, 20);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(22, 20);
            this.no.TabIndex = 41;
            this.no.Visible = false;
            // 
            // dtambil
            // 
            this.dtambil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtambil.Location = new System.Drawing.Point(91, 122);
            this.dtambil.Name = "dtambil";
            this.dtambil.Size = new System.Drawing.Size(200, 20);
            this.dtambil.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Ambil";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 27);
            this.button3.TabIndex = 38;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 27);
            this.button4.TabIndex = 37;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(131, 209);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(54, 27);
            this.btupdate.TabIndex = 36;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Batas kembali";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dtbatas
            // 
            this.dtbatas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbatas.Location = new System.Drawing.Point(91, 173);
            this.dtbatas.Name = "dtbatas";
            this.dtbatas.Size = new System.Drawing.Size(200, 20);
            this.dtbatas.TabIndex = 33;
            this.dtbatas.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Kembali";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dtkembali
            // 
            this.dtkembali.Checked = false;
            this.dtkembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtkembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtkembali.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtkembali.Location = new System.Drawing.Point(91, 147);
            this.dtkembali.Name = "dtkembali";
            this.dtkembali.Size = new System.Drawing.Size(200, 20);
            this.dtkembali.TabIndex = 29;
            this.dtkembali.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Periode";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Sisa cuti";
            // 
            // cmbsisa
            // 
            this.cmbsisa.FormattingEnabled = true;
            this.cmbsisa.Items.AddRange(new object[] {
            "1 hari",
            "2 hari",
            "3 hari",
            "4 hari",
            "5 hari",
            "6 hari",
            "7 hari",
            "8 hari",
            "9 hari",
            "10 hari",
            "11 hari",
            "12 hari"});
            this.cmbsisa.Location = new System.Drawing.Point(91, 96);
            this.cmbsisa.Name = "cmbsisa";
            this.cmbsisa.Size = new System.Drawing.Size(121, 21);
            this.cmbsisa.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Cuti";
            // 
            // tbnama_
            // 
            this.tbnama_.Location = new System.Drawing.Point(91, 20);
            this.tbnama_.Name = "tbnama_";
            this.tbnama_.Size = new System.Drawing.Size(165, 20);
            this.tbnama_.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Karyawan";
            // 
            // Cuti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1116, 435);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_cuti);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cuti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuti Karyawan SPH";
            this.Load += new System.EventHandler(this.Cuti_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuti)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbcarinm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_cuti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpbatas;
        private System.Windows.Forms.DateTimePicker dtpambil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpcuti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbsisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpperiode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtbatas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtkembali;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbsisa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbnama_;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtambil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.DateTimePicker dtcuti;
        private System.Windows.Forms.DateTimePicker dtperiode;
    }
}