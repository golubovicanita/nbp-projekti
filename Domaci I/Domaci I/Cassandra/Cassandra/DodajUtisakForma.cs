using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataProvider;
using CassandraDataProvider.QueryEntities;
namespace Cassandra
{
    public partial class DodajUtisakForma : Form
    {
        string izabranR;
        public DodajUtisakForma()
        {
            InitializeComponent();
        }
        public DodajUtisakForma(string r)
        {
            InitializeComponent();
            izabranR = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k = this.txtKorisnik.Text;
            string br;
            int ocena = (int)this.numOcena.Value;
            string kom = this.txtKometar.Text;
            Random r = new Random();
            int i = r.Next(6546, 7857);
            DataProvider.AddUtisak(izabranR, k, ocena, kom, i.ToString());
            MessageBox.Show("Ostavili ste utisak!");
            Close();
        }
    }
}
