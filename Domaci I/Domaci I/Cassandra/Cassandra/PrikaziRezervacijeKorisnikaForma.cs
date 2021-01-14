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
    public partial class PrikaziRezervacijeKorisnikaForma : Form
    {
        string korisnik;
        public PrikaziRezervacijeKorisnikaForma()
        {
            InitializeComponent();
        }
        public PrikaziRezervacijeKorisnikaForma(string k)
        {
            InitializeComponent();
            korisnik = k;
        }


        private void PrikaziRezervacijeKorisnikaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<Rezervacija_by_korisnikID> rez = DataProvider.GetRezervacijeKorisnika(korisnik);
            this.rezervacije.Items.Clear();
            foreach (Rezervacija_by_korisnikID r in rez)
            {
                string naziv = DataProvider.GetRestoran(r.restoranID).naziv;
                ListViewItem item = new ListViewItem(new string[] { r.restoranID.ToString(), naziv,  r.rezervacijaID.ToString(), r.licniMeniID.ToString(),  r.vremeOd.ToString(), r.vremeDo.ToString(), r.brojOsoba.ToString(), r.datum }); // dodato r.datum
                this.rezervacije.Items.Add(item);
            }
            this.rezervacije.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.rezervacije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite rezervaciju koju zelite da otkazete!");
                return;
            }

            string poruka = "Da li zelite da otkazete rezervaciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            string restoranNaziv = DataProvider.GetRestoran(rezervacije.SelectedItems[0].SubItems[0].Text).naziv;
            string restoran = rezervacije.SelectedItems[0].SubItems[0].Text;
            string rezervacija = rezervacije.SelectedItems[0].SubItems[2].Text;
            string licni = rezervacije.SelectedItems[0].SubItems[3].Text;
            DateTime datum = DateTime.Parse(rezervacije.SelectedItems[0].SubItems[7].Text);
            if (result == DialogResult.OK)
            {
                DataProvider.OtkaziRez(restoran, korisnik, rezervacija, licni, datum);
                MessageBox.Show("Rezervacija u restoranu: " +restoranNaziv  + " je otkazana!");
                this.popuniPodacima();

            }
            else
            {
                MessageBox.Show("Otkazano!");
            }
        }
    }
}
