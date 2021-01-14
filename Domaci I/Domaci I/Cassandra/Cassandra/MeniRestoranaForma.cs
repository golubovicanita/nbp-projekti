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
    public partial class MeniRestoranaForma : Form
    {
        public string izabranRestoranID;
        public List<string> licniMeni = new List<string>(10);
        public string[] meni;
        public MeniRestoranaForma()
        {
            InitializeComponent();
        }
        public MeniRestoranaForma(string id)
        {
            InitializeComponent();
            izabranRestoranID = id;
            
        }

        private void MeniRestoranaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public  void popuniPodacima()
        {
            
            this.txtImeRestorana.Text = DataProvider.GetRestoran(izabranRestoranID).naziv;

            List<Meni> meniji = DataProvider.GetMenijeURestoranu(izabranRestoranID);
            this.listaMenija.Items.Clear();
            foreach (Meni m in meniji)
            {

                ListViewItem item = new ListViewItem(new string[] { m.restoranID.ToString(), m.meniID.ToString(), m.naziv.ToString(), m.tipJela.ToString(), m.kolicina.ToString(), m.cena.ToString() });
                this.listaMenija.Items.Add(item);
            }
            this.listaMenija.Refresh();
        }

        public void btnDodaUMeni_Click(object sender, EventArgs e)
        {
            DodajUMeniForma forma = new DodajUMeniForma(izabranRestoranID);
            forma.ShowDialog();
            popuniPodacima();
                
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (this.listaMenija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sta zelite iz menija da obrisete!");
                return;
            }

            string poruka = "Da li zelite da uklonite iz menija?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DataProvider.deleteMeni(izabranRestoranID, this.listaMenija.SelectedItems[0].SubItems[1].Text);
                MessageBox.Show("Uspesno je uklonjeno iz menija!");
                this.popuniPodacima();

            }
            else
            {
                MessageBox.Show("Brisanje je otkazano!");
            }
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
           
            licniMeni.Add(this.listaMenija.SelectedItems[0].SubItems[2].Text); // naziv jela
            MessageBox.Show("Uneli ste u svoj licni meni!");
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            meni = licniMeni.ToArray();
            string korisniktelefon = this.txtKorisnikBroj.Text;
            Korisnik daLiJeUneoSvojePodatke = DataProvider.GetKorisnik(korisniktelefon);
            Random rand = new Random();
            int x = rand.Next(0, 150);
            if (daLiJeUneoSvojePodatke.ime == null)
            {
                DodajKorisnikaForma forma = new DodajKorisnikaForma();
                forma.ShowDialog();
            }
            
             DataProvider.CreateLicniMeni(izabranRestoranID, korisniktelefon, x.ToString(), licniMeni);
             MessageBox.Show("Kreirali ste svoj licni meni, odaberite datum i rezervisite.");
            
        }

        private void btnPrikaziLicniMeni_Click(object sender, EventArgs e)
        {
            LicniMeni meni = DataProvider.GetLicniMeni( izabranRestoranID, this.txtKorisnikBroj.Text);
            if (meni.licniMeniID == null)
            {
                MessageBox.Show("Nemate kreiran licni meni.");
            }
            else
            {
                LicniMeniPrikaziForma forma = new LicniMeniPrikaziForma(izabranRestoranID, this.txtKorisnikBroj.Text);
                forma.ShowDialog();
            }
            
        }
    }
}
