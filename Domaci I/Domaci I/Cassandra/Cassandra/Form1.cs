using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataProvider.QueryEntities;
using CassandraDataProvider;
namespace Cassandra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            podaciLokacija();
        }

        private void allRes_Click(object sender, EventArgs e)
        {
            PrikaziSveRestoraneForm forma = new PrikaziSveRestoraneForm();
            forma.ShowDialog();
        }
        public void podaciLokacija()
        {
            List<Restoran> restorani = DataProvider.GetRestaurants();
            this.lokacije.Items.Clear();
            this.lokacijaMuzika.Items.Clear();

            this.lokacije.Items.Add("Centar");
            this.lokacijaMuzika.Items.Add("Centar");
            this.lokacije.Items.Add("Palilula");
            this.lokacijaMuzika.Items.Add("Palilula");
            this.lokacije.Items.Add("Niska Banja");
            this.lokacijaMuzika.Items.Add("Niska Banja");
            this.lokacije.Items.Add("Medijana");
            this.lokacijaMuzika.Items.Add("Medijana");
            this.lokacije.Items.Add("Pantelej");
            this.lokacijaMuzika.Items.Add("Pantelej");


        }

        private void btnResLokacije_Click(object sender, EventArgs e)
        {
            string izabranaLokacija;
            izabranaLokacija = this.lokacije.SelectedItem.ToString();
            Restorani_by_lokacijaForma forma = new Restorani_by_lokacijaForma(izabranaLokacija);
            forma.ShowDialog();
           

        }

        private void btnPrikaziRestOcenaVeca_Click(object sender, EventArgs e)
        {
            int ocena =(int)this.numOcena.Value;
            RestoraniSaVecomOcenomForma forma = new RestoraniSaVecomOcenomForma(ocena);
            forma.ShowDialog();

        }

        private void brnPrikaziRestKraceVreme_Click(object sender, EventArgs e)
        {
            int vreme = Int32.Parse(this.txtVremeCekanja.Text);
            RestoraniSaKracimVremenomCekanjaForma forma = new RestoraniSaKracimVremenomCekanjaForma(vreme);
            forma.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrikaziKorisnike_Click(object sender, EventArgs e)
        {
            SviKorisniciForma forma = new SviKorisniciForma();
            forma.ShowDialog();
        }

        private void btnPretraziBr_Click(object sender, EventArgs e)
        {
            string broj = this.txtBroj.Text;
            Korisnik k= DataProvider.GetKorisnik(broj);
            if (k.telefon == null)
            {
                MessageBox.Show("Ne postoji korisnik sa ovim brojem telefona, ukoliko zelite da rezervisete, unesite kasnije podatke!");
            }
            else
            {
                MessageBox.Show("Korisnik se nalazi na spisku, mozete da rezervisete! ");

            }
        }

        private void btnLokacijaMuzika_Click(object sender, EventArgs e)
        {
            string izabranaLokacija;
            izabranaLokacija = this.lokacijaMuzika.SelectedItem.ToString();
            string muzika;
            if (this.cbMuzika.Checked == false)
            {
                muzika = "ne";
            }
            else
            {
                muzika = "da";
            }
            Restorani_by_lokacijaMuzikaForma forma = new Restorani_by_lokacijaMuzikaForma(izabranaLokacija, muzika);
            forma.ShowDialog();
        }

        private void btnDodajRestoran_Click(object sender, EventArgs e)
        {
            DodajRestoranForma forma = new DodajRestoranForma();
            forma.ShowDialog();
            //this.podaciLokacija();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            PrikaziRezervacijeZaDatumForma forma = new PrikaziRezervacijeZaDatumForma(datum.Value);
            MessageBox.Show(datum.Value.ToShortDateString());
            forma.ShowDialog();
        }
    }
}
