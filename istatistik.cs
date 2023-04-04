using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_ocak_2023_çalışma2
{
    public partial class istatistik : Form
    {
        SqlConnection sqlnesne = new SqlConnection("Data Source = HALIL\\SQLEXPRESS; Initial Catalog = CenazeVeriTabanı; Integrated Security = True");
        public istatistik()
        {
            InitializeComponent();
           
        }

        private void istatistik_Load(object sender, EventArgs e)
        {
          sqlnesne.Open();

          SqlCommand komut1 = new SqlCommand("Select Count(*) from ölü_veritabanı",sqlnesne);
          SqlDataReader sql1=komut1.ExecuteReader();
            while(sql1.Read())
            {
                label2.Text = sql1[0].ToString();

            }

          sqlnesne.Close();

            
        }
    }
}
