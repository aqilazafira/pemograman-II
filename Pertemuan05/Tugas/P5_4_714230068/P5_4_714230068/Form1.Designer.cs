namespace P5_4_714230068
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
            this.Nama = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.TanggalLahir = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.PilihanKelas = new System.Windows.Forms.GroupBox();
            this.PilihanJadwal = new System.Windows.Forms.GroupBox();
            this.SeninRabu = new System.Windows.Forms.RadioButton();
            this.SelasaKamis = new System.Windows.Forms.RadioButton();
            this.SabtuMinggu = new System.Windows.Forms.RadioButton();
            this.Minggu = new System.Windows.Forms.RadioButton();
            this.SepakBola = new System.Windows.Forms.CheckBox();
            this.Renang = new System.Windows.Forms.CheckBox();
            this.Tenis = new System.Windows.Forms.CheckBox();
            this.Yoga = new System.Windows.Forms.CheckBox();
            this.Basket = new System.Windows.Forms.CheckBox();
            this.BuluTangkis = new System.Windows.Forms.CheckBox();
            this.Voli = new System.Windows.Forms.CheckBox();
            this.Panahan = new System.Windows.Forms.CheckBox();
            this.Tampilan = new System.Windows.Forms.Button();
            this.Selesai = new System.Windows.Forms.Button();
            this.PilihanKelas.SuspendLayout();
            this.PilihanJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(136, 61);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(51, 20);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama";
            this.Nama.Click += new System.EventHandler(this.Nama_Click);
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Location = new System.Drawing.Point(135, 109);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(106, 20);
            this.JenisKelamin.TabIndex = 1;
            this.JenisKelamin.Text = "Jenis Kelamin";
            this.JenisKelamin.Click += new System.EventHandler(this.JenisKelamin_Click);
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.AutoSize = true;
            this.TanggalLahir.Location = new System.Drawing.Point(136, 156);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(105, 20);
            this.TanggalLahir.TabIndex = 2;
            this.TanggalLahir.Text = "Tanggal Lahir";
            this.TanggalLahir.Click += new System.EventHandler(this.TanggalLahir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.comboBox1.Location = new System.Drawing.Point(281, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "FORM PENDAFTARAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PilihanKelas
            // 
            this.PilihanKelas.Controls.Add(this.Panahan);
            this.PilihanKelas.Controls.Add(this.Voli);
            this.PilihanKelas.Controls.Add(this.BuluTangkis);
            this.PilihanKelas.Controls.Add(this.Basket);
            this.PilihanKelas.Controls.Add(this.Yoga);
            this.PilihanKelas.Controls.Add(this.Tenis);
            this.PilihanKelas.Controls.Add(this.Renang);
            this.PilihanKelas.Controls.Add(this.SepakBola);
            this.PilihanKelas.Location = new System.Drawing.Point(54, 200);
            this.PilihanKelas.Name = "PilihanKelas";
            this.PilihanKelas.Size = new System.Drawing.Size(312, 192);
            this.PilihanKelas.TabIndex = 7;
            this.PilihanKelas.TabStop = false;
            this.PilihanKelas.Text = "Pilihan Kelas";
            this.PilihanKelas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PilihanJadwal
            // 
            this.PilihanJadwal.Controls.Add(this.Minggu);
            this.PilihanJadwal.Controls.Add(this.SabtuMinggu);
            this.PilihanJadwal.Controls.Add(this.SelasaKamis);
            this.PilihanJadwal.Controls.Add(this.SeninRabu);
            this.PilihanJadwal.Location = new System.Drawing.Point(426, 200);
            this.PilihanJadwal.Name = "PilihanJadwal";
            this.PilihanJadwal.Size = new System.Drawing.Size(302, 192);
            this.PilihanJadwal.TabIndex = 8;
            this.PilihanJadwal.TabStop = false;
            this.PilihanJadwal.Text = "Pilihan Jadwal";
            this.PilihanJadwal.Enter += new System.EventHandler(this.PilihanJadwal_Enter);
            // 
            // SeninRabu
            // 
            this.SeninRabu.AutoSize = true;
            this.SeninRabu.Location = new System.Drawing.Point(29, 34);
            this.SeninRabu.Name = "SeninRabu";
            this.SeninRabu.Size = new System.Drawing.Size(244, 24);
            this.SeninRabu.TabIndex = 0;
            this.SeninRabu.TabStop = true;
            this.SeninRabu.Text = "Senin s/d Rabu, 14.00 - 16.00";
            this.SeninRabu.UseVisualStyleBackColor = true;
            this.SeninRabu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SelasaKamis
            // 
            this.SelasaKamis.AutoSize = true;
            this.SelasaKamis.Location = new System.Drawing.Point(29, 73);
            this.SelasaKamis.Name = "SelasaKamis";
            this.SelasaKamis.Size = new System.Drawing.Size(256, 24);
            this.SelasaKamis.TabIndex = 9;
            this.SelasaKamis.TabStop = true;
            this.SelasaKamis.Text = "Selasa s/d Kamis, 14.00 - 16.00";
            this.SelasaKamis.UseVisualStyleBackColor = true;
            this.SelasaKamis.CheckedChanged += new System.EventHandler(this.SelasaKamis_CheckedChanged);
            // 
            // SabtuMinggu
            // 
            this.SabtuMinggu.AutoSize = true;
            this.SabtuMinggu.Location = new System.Drawing.Point(29, 112);
            this.SabtuMinggu.Name = "SabtuMinggu";
            this.SabtuMinggu.Size = new System.Drawing.Size(259, 24);
            this.SabtuMinggu.TabIndex = 10;
            this.SabtuMinggu.TabStop = true;
            this.SabtuMinggu.Text = "Sabtu s/d Minggu, 09.00 - 11.00";
            this.SabtuMinggu.UseVisualStyleBackColor = true;
            this.SabtuMinggu.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Minggu
            // 
            this.Minggu.AutoSize = true;
            this.Minggu.Location = new System.Drawing.Point(29, 151);
            this.Minggu.Name = "Minggu";
            this.Minggu.Size = new System.Drawing.Size(191, 24);
            this.Minggu.TabIndex = 11;
            this.Minggu.TabStop = true;
            this.Minggu.Text = "Minggu, 13.00 - 20.00 ";
            this.Minggu.UseVisualStyleBackColor = true;
            this.Minggu.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // SepakBola
            // 
            this.SepakBola.AutoSize = true;
            this.SepakBola.Location = new System.Drawing.Point(20, 35);
            this.SepakBola.Name = "SepakBola";
            this.SepakBola.Size = new System.Drawing.Size(117, 24);
            this.SepakBola.TabIndex = 0;
            this.SepakBola.Text = "Sepak Bola";
            this.SepakBola.UseVisualStyleBackColor = true;
            this.SepakBola.CheckedChanged += new System.EventHandler(this.SepakBola_CheckedChanged);
            // 
            // Renang
            // 
            this.Renang.AutoSize = true;
            this.Renang.Location = new System.Drawing.Point(20, 74);
            this.Renang.Name = "Renang";
            this.Renang.Size = new System.Drawing.Size(92, 24);
            this.Renang.TabIndex = 1;
            this.Renang.Text = "Renang";
            this.Renang.UseVisualStyleBackColor = true;
            this.Renang.CheckedChanged += new System.EventHandler(this.Renang_CheckedChanged);
            // 
            // Tenis
            // 
            this.Tenis.AutoSize = true;
            this.Tenis.Location = new System.Drawing.Point(20, 112);
            this.Tenis.Name = "Tenis";
            this.Tenis.Size = new System.Drawing.Size(73, 24);
            this.Tenis.TabIndex = 2;
            this.Tenis.Text = "Tenis";
            this.Tenis.UseVisualStyleBackColor = true;
            this.Tenis.CheckedChanged += new System.EventHandler(this.Tenis_CheckedChanged);
            // 
            // Yoga
            // 
            this.Yoga.AutoSize = true;
            this.Yoga.Location = new System.Drawing.Point(20, 151);
            this.Yoga.Name = "Yoga";
            this.Yoga.Size = new System.Drawing.Size(73, 24);
            this.Yoga.TabIndex = 3;
            this.Yoga.Text = "Yoga";
            this.Yoga.UseVisualStyleBackColor = true;
            this.Yoga.CheckedChanged += new System.EventHandler(this.Yoga_CheckedChanged);
            // 
            // Basket
            // 
            this.Basket.AutoSize = true;
            this.Basket.Location = new System.Drawing.Point(170, 35);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(85, 24);
            this.Basket.TabIndex = 4;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            this.Basket.CheckedChanged += new System.EventHandler(this.Basket_CheckedChanged);
            // 
            // BuluTangkis
            // 
            this.BuluTangkis.AutoSize = true;
            this.BuluTangkis.Location = new System.Drawing.Point(170, 74);
            this.BuluTangkis.Name = "BuluTangkis";
            this.BuluTangkis.Size = new System.Drawing.Size(126, 24);
            this.BuluTangkis.TabIndex = 5;
            this.BuluTangkis.Text = "Bulu Tangkis";
            this.BuluTangkis.UseVisualStyleBackColor = true;
            this.BuluTangkis.CheckedChanged += new System.EventHandler(this.BuluTangkis_CheckedChanged);
            // 
            // Voli
            // 
            this.Voli.AutoSize = true;
            this.Voli.Location = new System.Drawing.Point(170, 112);
            this.Voli.Name = "Voli";
            this.Voli.Size = new System.Drawing.Size(61, 24);
            this.Voli.TabIndex = 6;
            this.Voli.Text = "Voli";
            this.Voli.UseVisualStyleBackColor = true;
            this.Voli.CheckedChanged += new System.EventHandler(this.Voli_CheckedChanged);
            // 
            // Panahan
            // 
            this.Panahan.AutoSize = true;
            this.Panahan.Location = new System.Drawing.Point(170, 152);
            this.Panahan.Name = "Panahan";
            this.Panahan.Size = new System.Drawing.Size(99, 24);
            this.Panahan.TabIndex = 7;
            this.Panahan.Text = "Panahan";
            this.Panahan.UseVisualStyleBackColor = true;
            this.Panahan.CheckedChanged += new System.EventHandler(this.Panahan_CheckedChanged);
            // 
            // Tampilan
            // 
            this.Tampilan.BackColor = System.Drawing.Color.Gray;
            this.Tampilan.Location = new System.Drawing.Point(272, 409);
            this.Tampilan.Name = "Tampilan";
            this.Tampilan.Size = new System.Drawing.Size(94, 34);
            this.Tampilan.TabIndex = 9;
            this.Tampilan.Text = "Tampilan";
            this.Tampilan.UseVisualStyleBackColor = false;
            this.Tampilan.Click += new System.EventHandler(this.Tampilan_Click);
            // 
            // Selesai
            // 
            this.Selesai.BackColor = System.Drawing.Color.DimGray;
            this.Selesai.Location = new System.Drawing.Point(426, 409);
            this.Selesai.Name = "Selesai";
            this.Selesai.Size = new System.Drawing.Size(86, 34);
            this.Selesai.TabIndex = 10;
            this.Selesai.Text = "Selesai";
            this.Selesai.UseVisualStyleBackColor = false;
            this.Selesai.Click += new System.EventHandler(this.Selesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(781, 475);
            this.Controls.Add(this.Selesai);
            this.Controls.Add(this.Tampilan);
            this.Controls.Add(this.PilihanJadwal);
            this.Controls.Add(this.PilihanKelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PilihanKelas.ResumeLayout(false);
            this.PilihanKelas.PerformLayout();
            this.PilihanJadwal.ResumeLayout(false);
            this.PilihanJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label TanggalLahir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PilihanKelas;
        private System.Windows.Forms.GroupBox PilihanJadwal;
        private System.Windows.Forms.CheckBox SepakBola;
        private System.Windows.Forms.RadioButton Minggu;
        private System.Windows.Forms.RadioButton SabtuMinggu;
        private System.Windows.Forms.RadioButton SelasaKamis;
        private System.Windows.Forms.RadioButton SeninRabu;
        private System.Windows.Forms.CheckBox Yoga;
        private System.Windows.Forms.CheckBox Tenis;
        private System.Windows.Forms.CheckBox Renang;
        private System.Windows.Forms.CheckBox Panahan;
        private System.Windows.Forms.CheckBox Voli;
        private System.Windows.Forms.CheckBox BuluTangkis;
        private System.Windows.Forms.CheckBox Basket;
        private System.Windows.Forms.Button Tampilan;
        private System.Windows.Forms.Button Selesai;
    }
}

