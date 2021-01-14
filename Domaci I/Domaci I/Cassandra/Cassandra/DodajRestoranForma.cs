using CassandraDataProvider;
using CassandraDataProvider.QueryEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cassandra
{
    public partial class DodajRestoranForma : Form
    {
        public DodajRestoranForma()
        {
            InitializeComponent();
            this.cboxLokacija.Items.Add("Centar");
            this.cboxLokacija.Items.Add("Palilula");
            this.cboxLokacija.Items.Add("Pantelej");
            this.cboxLokacija.Items.Add("Medijana");
            this.cboxLokacija.Items.Add("Niska Banja");
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            dodajRestoran();
        }
        public void dodajRestoran()
        {
            Random rand = new Random();
            int x = rand.Next(100, 1000);
            string id = x.ToString();
            Restoran daLiPostoji = DataProvider.GetRestoran(id);
            string naziv = this.txtNaziv.Text;
            string adresa = this.txtAdresa.Text;
            //string lokacija = this.txtLokacija.Text;
            string lokacija = this.cboxLokacija.SelectedItem.ToString();
            string radnoV = this.txtRadnoVreme.Text;
            string telefon = this.txtTelefon.Text;
            int vremeCekanja = (int)this.numVremeCekanja.Value;
            int ocena = (int)this.numOcena.Value;
            string muzika;
            if (this.cbMuzika.Checked == true)
            {
                muzika = "da";
            }
            else
            {
                muzika = "ne";
            }

            if (daLiPostoji.naziv == null)
            {
                bool dodat = DataProvider.AddRestoran(id, naziv, adresa, lokacija, radnoV, telefon, vremeCekanja, ocena, muzika);
                if (dodat)
                {
                    MessageBox.Show("Uspesno ste dodali restoran: " + naziv);
                }
                else
                {
                    MessageBox.Show("Neuspesno dodavanje restorana!");
                }

            }
            else
            {
                MessageBox.Show("Postoji vec restoran sa tim id-jem.");
                dodajRestoran();
            }
            Close();
        }

        private void DodajRestoranForma_Load(object sender, EventArgs e)
        {

        }
    }
}
