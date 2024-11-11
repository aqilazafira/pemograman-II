using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P5_4_714230068
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void TanggalLahir_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Nama_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void JenisKelamin_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void SepakBola_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Renang_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Tenis_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Yoga_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Basket_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BuluTangkis_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Voli_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Panahan_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void PilihanJadwal_Enter(object sender, EventArgs e)
        {
        }

        private void SelasaKamis_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Tampilan_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string jenisKelamin = comboBox1.SelectedItem?.ToString() ?? "";
            DateTime tanggalLahir = dateTimePicker1.Value;

            List<string> pilihanKelas = new List<string>();
            if (SepakBola.Checked) pilihanKelas.Add("Sepak Bola");
            if (Renang.Checked) pilihanKelas.Add("Renang");
            if (Tenis.Checked) pilihanKelas.Add("Tenis");
            if (Yoga.Checked) pilihanKelas.Add("Yoga");
            if (Basket.Checked) pilihanKelas.Add("Basket");
            if (BuluTangkis.Checked) pilihanKelas.Add("Bulu Tangkis");
            if (Voli.Checked) pilihanKelas.Add("Voli");
            if (Panahan.Checked) pilihanKelas.Add("Panahan");

            string pilihanJadwal = "";
            if (SeninRabu.Checked) pilihanJadwal = "Senin s/d Rabu, 14.00 - 16.00";
            else if (SelasaKamis.Checked) pilihanJadwal = "Selasa s/d Kamis, 14.00 - 16.00";
            else if (SabtuMinggu.Checked) pilihanJadwal = "Sabtu s/d Minggu, 09.00 - 11.00";
            else if (Minggu.Checked) pilihanJadwal = "Minggu, 13.00 - 20.00";

            if (pilihanKelas.Count == 0)
            {
                MessageBox.Show("Harus memilih salah satu dari kelas", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(pilihanJadwal))
            {
                MessageBox.Show("Harus memilih salah satu jadwal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hasil = $"Nama: {nama}\nJenis Kelamin: {jenisKelamin}\nTanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                           $"Pilihan Kelas: {string.Join(", ", pilihanKelas)}\nPilihan Jadwal: {pilihanJadwal}";

            MessageBox.Show(hasil, "Hasil Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
