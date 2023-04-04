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

namespace _5_ocak_2023_çalışma2
{
    public partial class giris2 : Form
    {
        SqlConnection sqlnesne = new SqlConnection("Data Source = HALIL\\SQLEXPRESS; Initial Catalog = CenazeVeriTabanı; Integrated Security = True");
        public giris2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            sqlnesne.Open();
            SqlCommand gir = new SqlCommand("select * from kullanici_giris where kullaniciAd=@p1 and sifre=@p2",sqlnesne);
            gir.Parameters.AddWithValue("@p1",textBox1.Text);
            gir.Parameters.AddWithValue("@p2",textBox2.Text);

            SqlDataReader dr=gir.ExecuteReader();


            if (dr.Read())
            {
                Form1 girisyap = new Form1();
                girisyap.Show();
                this.Hide();

                giris2 cık =new giris2();

                cık.Close();
                cık.Dispose();

                    
            }
            else
            {
                MessageBox.Show("yanlış kullanıcı adı veya şifre girdiniz");
                
            }

         
            sqlnesne.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void giris2_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
