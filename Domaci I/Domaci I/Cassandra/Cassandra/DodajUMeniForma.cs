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
    public partial class DodajUMeniForma : Form
    {
        public string restoranId;
        public DodajUMeniForma()
        {
            InitializeComponent();
            

        }
        public DodajUMeniForma(string id)
        {
            InitializeComponent();
            restoranId = id;
            this.txtRestoran.Text = DataProvider.GetRestoran(restoranId).naziv;
            this.cboxTip.Items.Add("Čorba");
            this.cboxTip.Items.Add("Toplo predjelo");
            this.cboxTip.Items.Add("Hladno predjelo");
            this.cboxTip.Items.Add("Gotova jela");
            this.cboxTip.Items.Add("Doručak");
            this.cboxTip.Items.Add("Riba");
            this.cboxTip.Items.Add("Specijaliteti sa roštilja");
            this.cboxTip.Items.Add("Salate");
            this.cboxTip.Items.Add("Sirevi");
            this.cboxTip.Items.Add("Deserti");
            this.cboxTip.Items.Add("PiĆa");
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int x = rand.Next(1000, 3000);

            Meni daLiPostojiIstiId = DataProvider.GetMeni(restoranId, x.ToString());

            if (daLiPostojiIstiId.naziv == null)
            {
                bool dodat = DataProvider.AddUMeni(restoranId.ToString(), x.ToString(), txtNaziv.Text, this.cboxTip.SelectedItem.ToString(), txtKolicina.Text, txtCena.Text);
                if (dodat)
                {
                    MessageBox.Show("Uspesno ste dodali stavku u meni!");
                }
                else
                {
                    MessageBox.Show("Neuspesno dodavanje !");
                }

            }
            else
            {
                MessageBox.Show("Postoji vec stavka sa tim id-jem.");
                
            }
            Close();


        }
        


    }
}
