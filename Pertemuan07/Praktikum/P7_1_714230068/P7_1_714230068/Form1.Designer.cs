namespace P7_1_714230068
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
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxKelas = new System.Windows.Forms.TextBox();
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.checkBoxKuliah = new System.Windows.Forms.CheckBox();
            this.checkBoxTidur = new System.Windows.Forms.CheckBox();
            this.checkBoxLibur = new System.Windows.Forms.CheckBox();
            this.radioButtonWeekday = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekend = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBoxAngkatan.Location = new System.Drawing.Point(138, 55);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(171, 21);
            this.comboBoxAngkatan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kelas";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(138, 25);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(171, 20);
            this.textBoxNama.TabIndex = 4;
            // 
            // textBoxKelas
            // 
            this.textBoxKelas.Location = new System.Drawing.Point(138, 90);
            this.textBoxKelas.Multiline = true;
            this.textBoxKelas.Name = "textBoxKelas";
            this.textBoxKelas.Size = new System.Drawing.Size(171, 62);
            this.textBoxKelas.TabIndex = 5;
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(134, 169);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(75, 23);
            this.buttonCek.TabIndex = 6;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Location = new System.Drawing.Point(234, 169);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(75, 23);
            this.buttonTutup.TabIndex = 7;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // checkBoxKuliah
            // 
            this.checkBoxKuliah.AutoSize = true;
            this.checkBoxKuliah.Location = new System.Drawing.Point(30, 303);
            this.checkBoxKuliah.Name = "checkBoxKuliah";
            this.checkBoxKuliah.Size = new System.Drawing.Size(55, 17);
            this.checkBoxKuliah.TabIndex = 8;
            this.checkBoxKuliah.Text = "Kuliah";
            this.checkBoxKuliah.UseVisualStyleBackColor = true;
            // 
            // checkBoxTidur
            // 
            this.checkBoxTidur.AutoSize = true;
            this.checkBoxTidur.Location = new System.Drawing.Point(28, 326);
            this.checkBoxTidur.Name = "checkBoxTidur";
            this.checkBoxTidur.Size = new System.Drawing.Size(50, 17);
            this.checkBoxTidur.TabIndex = 9;
            this.checkBoxTidur.Text = "Tidur";
            this.checkBoxTidur.UseVisualStyleBackColor = true;
            // 
            // checkBoxLibur
            // 
            this.checkBoxLibur.AutoSize = true;
            this.checkBoxLibur.Location = new System.Drawing.Point(28, 349);
            this.checkBoxLibur.Name = "checkBoxLibur";
            this.checkBoxLibur.Size = new System.Drawing.Size(49, 17);
            this.checkBoxLibur.TabIndex = 10;
            this.checkBoxLibur.Text = "Libur";
            this.checkBoxLibur.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeekday
            // 
            this.radioButtonWeekday.AutoSize = true;
            this.radioButtonWeekday.Location = new System.Drawing.Point(30, 246);
            this.radioButtonWeekday.Name = "radioButtonWeekday";
            this.radioButtonWeekday.Size = new System.Drawing.Size(89, 17);
            this.radioButtonWeekday.TabIndex = 11;
            this.radioButtonWeekday.TabStop = true;
            this.radioButtonWeekday.Text = "Senin - Jumat";
            this.radioButtonWeekday.UseVisualStyleBackColor = true;
            this.radioButtonWeekday.CheckedChanged += new System.EventHandler(this.Weekday_CheckedChanged);
            // 
            // radioButtonWeekend
            // 
            this.radioButtonWeekend.AutoSize = true;
            this.radioButtonWeekend.Location = new System.Drawing.Point(30, 269);
            this.radioButtonWeekend.Name = "radioButtonWeekend";
            this.radioButtonWeekend.Size = new System.Drawing.Size(97, 17);
            this.radioButtonWeekend.TabIndex = 12;
            this.radioButtonWeekend.TabStop = true;
            this.radioButtonWeekend.Text = "Sabtu - Minggu";
            this.radioButtonWeekend.UseVisualStyleBackColor = true;
            this.radioButtonWeekend.CheckedChanged += new System.EventHandler(this.Weekend_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "KEGIATAN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonCetak
            // 
            this.buttonCetak.Location = new System.Drawing.Point(134, 383);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(75, 23);
            this.buttonCetak.TabIndex = 14;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(234, 383);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(314, 425);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonWeekend);
            this.Controls.Add(this.radioButtonWeekday);
            this.Controls.Add(this.checkBoxLibur);
            this.Controls.Add(this.checkBoxTidur);
            this.Controls.Add(this.checkBoxKuliah);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.textBoxKelas);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAngkatan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxKelas;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.CheckBox checkBoxKuliah;
        private System.Windows.Forms.CheckBox checkBoxTidur;
        private System.Windows.Forms.CheckBox checkBoxLibur;
        private System.Windows.Forms.RadioButton radioButtonWeekday;
        private System.Windows.Forms.RadioButton radioButtonWeekend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Button buttonReset;
    }
}

