using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;


namespace _5_ocak_2023_çalışma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlnesne = new SqlConnection("Data Source = HALIL\\SQLEXPRESS; Initial Catalog = CenazeVeriTabanı; Integrated Security = True");

        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoy.Text = "";
            txtyas.Text = "";
            comboBoxülke.Text = "";
            radioerkek.Checked = false;
            radiokadın.Checked = false;

            txtad.Focus();


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cenazeVeriTabanıDataSet1.ölü_veritabanı' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ölü_veritabanıTableAdapter.Fill(this.cenazeVeriTabanıDataSet1.ölü_veritabanı);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoy.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            label9.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtyas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            comboBoxülke.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radiokadın_CheckedChanged(object sender, EventArgs e)
        {


            if (radiokadın.Checked==true)
            {
                label9.Text = "true";
            }
        }

        private void radioerkek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioerkek.Checked == false)
            {
                label9.Text = "false";
            }
        }


        private void buttontemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
        private void button1_Click(object sender, EventArgs e)
        {

            ses.SoundLocation = "ölüm.wav";
            ses.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ses.Stop();

        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if (label9.Text == "false")
            {

                radiokadın.Checked = true;
            }

             else if (label9.Text == "true")
            {
                radiokadın.Checked = true;
            }
        }


        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxülke_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void label9_Click(object sender, EventArgs e)
        {

        }

       

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            this.Close();
            this.Dispose();

            giris2 cık1 = new giris2();
            cık1.Show();
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ölü_veritabanıTableAdapter.Fill(this.cenazeVeriTabanıDataSet1.ölü_veritabanı);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sqlnesne.Open();


            SqlCommand sil = new SqlCommand("Delete from ölü_veritabanı where id = @k1", sqlnesne);

            sil.Parameters.AddWithValue("@k1", txtid.Text);
            sil.ExecuteNonQuery();
            sqlnesne.Close();
            MessageBox.Show("kayıt silindi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            istatistik ist = new istatistik();
            ist.Show();
        }

        private void Guncellebtn_Click(object sender, EventArgs e)
        {
            sqlnesne.Open();
            SqlCommand guncelle = new SqlCommand("Update ölü_veritabanı set ad=@c1,soyad=@c2,cinsiyet=@c3,yaş=@c4 where id=@c6", sqlnesne);

            guncelle.Parameters.AddWithValue("@c1", txtad.Text);
            guncelle.Parameters.AddWithValue("@c2", txtsoy.Text);
            guncelle.Parameters.AddWithValue("@c3", label9.Text);
            guncelle.Parameters.AddWithValue("@c4", txtyas.Text);
            guncelle.Parameters.AddWithValue("@c5", comboBoxülke.Text);
            guncelle.Parameters.AddWithValue("@c6", txtid.Text);
            guncelle.ExecuteNonQuery();
            sqlnesne.Close();
            MessageBox.Show("kayıt güncellendi");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sqlnesne.Open();
            SqlCommand sqlKomut = new SqlCommand("insert into ölü_veritabanı (ad,soyad,yaş,şehir,cinsiyet) values (@p1,@p2,@p3,@p4,@p5)", sqlnesne);
            sqlKomut.Parameters.AddWithValue("@p1", txtad.Text);
            sqlKomut.Parameters.AddWithValue("@p2", txtsoy.Text);
            sqlKomut.Parameters.AddWithValue("@p3", txtyas.Text);
            sqlKomut.Parameters.AddWithValue("@p4", comboBoxülke.Text);
            sqlKomut.Parameters.AddWithValue("@p5", label9.Text);
            sqlKomut.ExecuteNonQuery();

            sqlnesne.Close();
            MessageBox.Show("Cenaze kaydı eklendi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kayırlar kayıt = new kayırlar();
            kayıt.Show();
        }
    }
}
