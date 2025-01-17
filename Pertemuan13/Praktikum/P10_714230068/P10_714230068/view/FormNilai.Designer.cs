using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace P10_714230068.view
{
    partial class FormNilai
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
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.gbFormNilai = new System.Windows.Forms.GroupBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNilai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNPM = new System.Windows.Forms.ComboBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.comboBoxMatkul = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCariData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.gbFormNilai.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(22, 23);
            this.DataNilai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataNilai.RowHeadersWidth = 51;
            this.DataNilai.Size = new System.Drawing.Size(514, 162);
            this.DataNilai.TabIndex = 0;
            // 
            // gbFormNilai
            // 
            this.gbFormNilai.Controls.Add(this.textBoxNama);
            this.gbFormNilai.Controls.Add(this.textBoxNilai);
            this.gbFormNilai.Controls.Add(this.label4);
            this.gbFormNilai.Controls.Add(this.label3);
            this.gbFormNilai.Controls.Add(this.label2);
            this.gbFormNilai.Controls.Add(this.label1);
            this.gbFormNilai.Controls.Add(this.comboBoxNPM);
            this.gbFormNilai.Controls.Add(this.comboBoxKategori);
            this.gbFormNilai.Controls.Add(this.comboBoxMatkul);
            this.gbFormNilai.Location = new System.Drawing.Point(21, 233);
            this.gbFormNilai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFormNilai.Name = "gbFormNilai";
            this.gbFormNilai.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFormNilai.Size = new System.Drawing.Size(250, 205);
            this.gbFormNilai.TabIndex = 1;
            this.gbFormNilai.TabStop = false;
            this.gbFormNilai.Text = "Form Input Nilai";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(116, 108);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.ReadOnly = true;
            this.textBoxNama.Size = new System.Drawing.Size(114, 20);
            this.textBoxNama.TabIndex = 8;
            // 
            // textBoxNilai
            // 
            this.textBoxNilai.Location = new System.Drawing.Point(116, 144);
            this.textBoxNilai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNilai.Name = "textBoxNilai";
            this.textBoxNilai.Size = new System.Drawing.Size(114, 20);
            this.textBoxNilai.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matkul";
            // 
            // comboBoxNPM
            // 
            this.comboBoxNPM.FormattingEnabled = true;
            this.comboBoxNPM.Location = new System.Drawing.Point(116, 86);
            this.comboBoxNPM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNPM.Name = "comboBoxNPM";
            this.comboBoxNPM.Size = new System.Drawing.Size(114, 21);
            this.comboBoxNPM.TabIndex = 2;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Items.AddRange(new object[] {
            "ATS",
            "AAS"});
            this.comboBoxKategori.Location = new System.Drawing.Point(116, 54);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(114, 21);
            this.comboBoxKategori.TabIndex = 1;
            // 
            // comboBoxMatkul
            // 
            this.comboBoxMatkul.FormattingEnabled = true;
            this.comboBoxMatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.comboBoxMatkul.Location = new System.Drawing.Point(116, 24);
            this.comboBoxMatkul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMatkul.Name = "comboBoxMatkul";
            this.comboBoxMatkul.Size = new System.Drawing.Size(114, 21);
            this.comboBoxMatkul.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxCariData);
            this.groupBox1.Location = new System.Drawing.Point(283, 233);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(292, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cari Data";
            // 
            // textBoxCariData
            // 
            this.textBoxCariData.Location = new System.Drawing.Point(119, 16);
            this.textBoxCariData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCariData.Name = "textBoxCariData";
            this.textBoxCariData.Size = new System.Drawing.Size(128, 20);
            this.textBoxCariData.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonHapus);
            this.groupBox2.Controls.Add(this.buttonUbah);
            this.groupBox2.Controls.Add(this.buttonSimpan);
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Location = new System.Drawing.Point(283, 306);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(292, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tombol Action";
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(23, 114);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(247, 19);
            this.buttonHapus.TabIndex = 3;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonUbah
            // 
            this.buttonUbah.Location = new System.Drawing.Point(23, 86);
            this.buttonUbah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(247, 19);
            this.buttonUbah.TabIndex = 2;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(23, 57);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(247, 19);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(23, 30);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(247, 19);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataNilai);
            this.groupBox3.Location = new System.Drawing.Point(16, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(558, 208);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table Data Nilai";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(119, 41);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(128, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 473);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFormNilai);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.gbFormNilai.ResumeLayout(false);
            this.gbFormNilai.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DataNilai;
        private GroupBox gbFormNilai;
        private Label label1;
        private ComboBox comboBoxNPM;
        private ComboBox comboBoxKategori;
        private ComboBox comboBoxMatkul;
        private TextBox textBoxNilai;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBoxCariData;
        private GroupBox groupBox2;
        private Button buttonHapus;
        private Button buttonUbah;
        private Button buttonSimpan;
        private Button buttonRefresh;
        private Label label5;
        private GroupBox groupBox3;
        private TextBox textBoxNama;
        private Button btnExport;
    }
}