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
    public partial class SviKorisniciForma : Form
    {
        public SviKorisniciForma()
        {
            InitializeComponent();
        }

        private void SviKorisniciForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
       
        public void popuniPodacima()
        {
            List<Korisnik> korisnici = DataProvider.GetKorisnici();
            this.korisnici.Items.Clear();
            foreach (Korisnik k in korisnici)
            {

                ListViewItem item = new ListViewItem(new string[] { k.ime.ToString(), k.prezime.ToString(), k.telefon.ToString() });
                this.korisnici.Items.Add(item);
            }
            this.korisnici.Refresh();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (this.korisnici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite korisnika kog zelite da obrisete!");
                return;
            }

            string poruka = "Da li zelite da obrisete izabranog korisnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DataProvider.deleteKorisnik(this.korisnici.SelectedItems[0].SubItems[2].Text);
                MessageBox.Show("Brisanje korisnika je uspesno obavljeno!");
                this.popuniPodacima();

            }
            else
            {
                MessageBox.Show("Brisanje korisnika je otkazano!");
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajKorisnikaForma forma = new DodajKorisnikaForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PrikaziLicniMeniKorisnikaForma forma = new PrikaziLicniMeniKorisnikaForma(this.korisnici.SelectedItems[0].SubItems[2].Text);
            forma.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            PrikaziRezervacijeKorisnikaForma forma = new PrikaziRezervacijeKorisnikaForma(this.korisnici.SelectedItems[0].SubItems[2].Text);
            forma.ShowDialog();
        }
    }
}
