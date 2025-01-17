using System.Drawing;
using System.Windows.Forms;

namespace P10_714230068.view
{
    partial class FormTransaksi
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
            this.gbTabel = new System.Windows.Forms.GroupBox();
            this.dataTransaksi = new System.Windows.Forms.DataGridView();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.buttonRubah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.gbPencarian = new System.Windows.Forms.GroupBox();
            this.cariData = new System.Windows.Forms.Label();
            this.textBoxPencarian = new System.Windows.Forms.TextBox();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.gbTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransaksi)).BeginInit();
            this.gbForm.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.gbPencarian.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTabel
            // 
            this.gbTabel.Controls.Add(this.dataTransaksi);
            this.gbTabel.Location = new System.Drawing.Point(20, 12);
            this.gbTabel.Name = "gbTabel";
            this.gbTabel.Size = new System.Drawing.Size(627, 222);
            this.gbTabel.TabIndex = 0;
            this.gbTabel.TabStop = false;
            this.gbTabel.Text = "Tabel Data Transaksi";
            // 
            // dataTransaksi
            // 
            this.dataTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransaksi.Location = new System.Drawing.Point(14, 19);
            this.dataTransaksi.Name = "dataTransaksi";
            this.dataTransaksi.Size = new System.Drawing.Size(597, 185);
            this.dataTransaksi.TabIndex = 0;
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.labelTotal);
            this.gbForm.Controls.Add(this.labelHarga);
            this.gbForm.Controls.Add(this.comboBoxID);
            this.gbForm.Controls.Add(this.textBoxQuantity);
            this.gbForm.Controls.Add(this.textBoxHarga);
            this.gbForm.Controls.Add(this.textBoxNama);
            this.gbForm.Controls.Add(this.textBoxTotal);
            this.gbForm.Controls.Add(this.labelAlamat);
            this.gbForm.Controls.Add(this.labelNama);
            this.gbForm.Controls.Add(this.labelID);
            this.gbForm.Location = new System.Drawing.Point(20, 240);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(323, 248);
            this.gbForm.TabIndex = 1;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form Data Transaksi";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(21, 169);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Total";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(21, 103);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(73, 13);
            this.labelHarga.TabIndex = 12;
            this.labelHarga.Text = "Harga Barang";
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(94, 29);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(197, 21);
            this.comboBoxID.TabIndex = 11;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(94, 133);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(197, 20);
            this.textBoxQuantity.TabIndex = 10;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(94, 99);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.ReadOnly = true;
            this.textBoxHarga.Size = new System.Drawing.Size(197, 20);
            this.textBoxHarga.TabIndex = 9;
            this.textBoxHarga.Text = "Rp. ";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(94, 64);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.ReadOnly = true;
            this.textBoxNama.Size = new System.Drawing.Size(197, 20);
            this.textBoxNama.TabIndex = 7;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(94, 168);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(197, 20);
            this.textBoxTotal.TabIndex = 6;
            this.textBoxTotal.Text = "Rp. ";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(21, 138);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(46, 13);
            this.labelAlamat.TabIndex = 3;
            this.labelAlamat.Text = "Quantity";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(21, 68);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(72, 13);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama Barang";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(21, 31);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(55, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID Barang";
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.buttonRubah);
            this.gbAction.Controls.Add(this.buttonHapus);
            this.gbAction.Controls.Add(this.buttonSimpan);
            this.gbAction.Controls.Add(this.buttonRefresh);
            this.gbAction.Location = new System.Drawing.Point(361, 329);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(286, 184);
            this.gbAction.TabIndex = 2;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Tabel Action";
            // 
            // buttonRubah
            // 
            this.buttonRubah.Location = new System.Drawing.Point(28, 102);
            this.buttonRubah.Name = "buttonRubah";
            this.buttonRubah.Size = new System.Drawing.Size(242, 23);
            this.buttonRubah.TabIndex = 3;
            this.buttonRubah.Text = "Rubah";
            this.buttonRubah.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(28, 138);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(242, 23);
            this.buttonHapus.TabIndex = 2;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(28, 63);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(242, 23);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(28, 25);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(242, 23);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // gbPencarian
            // 
            this.gbPencarian.Controls.Add(this.buttonExportExcel);
            this.gbPencarian.Controls.Add(this.cariData);
            this.gbPencarian.Controls.Add(this.textBoxPencarian);
            this.gbPencarian.Location = new System.Drawing.Point(361, 239);
            this.gbPencarian.Name = "gbPencarian";
            this.gbPencarian.Size = new System.Drawing.Size(286, 82);
            this.gbPencarian.TabIndex = 3;
            this.gbPencarian.TabStop = false;
            this.gbPencarian.Text = "Form Pencarian";
            // 
            // cariData
            // 
            this.cariData.AutoSize = true;
            this.cariData.Location = new System.Drawing.Point(14, 28);
            this.cariData.Name = "cariData";
            this.cariData.Size = new System.Drawing.Size(51, 13);
            this.cariData.TabIndex = 1;
            this.cariData.Text = "Cari Data";
            // 
            // textBoxPencarian
            // 
            this.textBoxPencarian.Location = new System.Drawing.Point(66, 25);
            this.textBoxPencarian.Name = "textBoxPencarian";
            this.textBoxPencarian.Size = new System.Drawing.Size(204, 20);
            this.textBoxPencarian.TabIndex = 0;
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Location = new System.Drawing.Point(66, 51);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(204, 23);
            this.buttonExportExcel.TabIndex = 4;
            this.buttonExportExcel.Text = "Export Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 564);
            this.Controls.Add(this.gbPencarian);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.gbTabel);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.gbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTransaksi)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.gbAction.ResumeLayout(false);
            this.gbPencarian.ResumeLayout(false);
            this.gbPencarian.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTabel;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelAngkatan;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.DataGridView dataTransaksi;
        private System.Windows.Forms.Button buttonRubah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonRefresh;
        private GroupBox gbPencarian;
        private Label cariData;
        private TextBox textBoxPencarian;
        private ComboBox comboBoxID;
        private Label labelTotal;
        private Label labelHarga;
        private Button buttonExportExcel;
    }
}