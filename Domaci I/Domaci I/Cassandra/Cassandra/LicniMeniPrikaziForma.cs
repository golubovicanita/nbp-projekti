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
    public partial class LicniMeniPrikaziForma : Form
    {
        string restoran;
        string korisnik;
        public LicniMeniPrikaziForma()
        {
            InitializeComponent();
        }
        public LicniMeniPrikaziForma(string r, string k)
        {
            InitializeComponent();
            restoran = r;
            korisnik = k;
        }

        private void LicniMeniPrikaziForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (this.licniMeni.SelectedItems.Count == 0)
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
                DataProvider.DeleteIzLicnogMenija(restoran, korisnik, this.licniMeni.SelectedItems[0].SubItems[0].Text);
                MessageBox.Show("Uspesno je uklonjeno iz menija!");
                this.popuniPodacima();
                
            }
            else
            {
                MessageBox.Show("Brisanje je otkazano!");
            }
        }
        public void popuniPodacima()
        {
            this.txtIme.Text = DataProvider.GetKorisnik(korisnik).ime;
            this.txtRestoran.Text = DataProvider.GetRestoran(restoran).naziv;
            
            List<LicniMeni> meniji = DataProvider.GetLicniMeniji(restoran, korisnik);
            this.txtBroj.Text = meniji.Count().ToString();
            this.licniMeni.Items.Clear();
            foreach (LicniMeni m in meniji)
            {
                foreach(string s in m.spisak)
                {
                    ListViewItem item = new ListViewItem(new string[] { m.licniMeniID.ToString(), s});
                    this.licniMeni.Items.Add(item);
                }
               
                
            }
            this.licniMeni.Refresh();
        }

        private void btnrezervacija_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = r.Next(6000, 8000);
            string rezervacijaID = x.ToString();
            string restoranID = restoran;
            string korisnikID = korisnik;
            string licniMeniId = this.licniMeni.SelectedItems[0].SubItems[0].Text;
            string vremeOd = this.txtVremeOd.Text;
            string vremeDo = this.txtVremeDo.Text;
            int brOsoba = Int32.Parse(txtBrojOsoba.Text);
            DateTime datum = this.dateTimePicker1.Value;
            bool rezervisao= DataProvider.Rezervisi(restoranID, korisnikID, rezervacijaID, licniMeniId, datum, vremeOd, vremeDo, brOsoba);
            if (rezervisao == true)
            {
                MessageBox.Show("Uspesno ste rezervisali!");
                Close();
            }
            else
            {
                MessageBox.Show("Neuspesna rezervacija");
            }

        }
    }
}
