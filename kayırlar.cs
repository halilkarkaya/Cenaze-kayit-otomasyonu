using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_ocak_2023_çalışma2
{
    public partial class kayırlar : Form
    {
        public kayırlar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kayırlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cenazeVeriTabanıDataSet.ölü_veritabanı' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ölü_veritabanıTableAdapter.Fill(this.cenazeVeriTabanıDataSet.ölü_veritabanı);

        }
    }
}
