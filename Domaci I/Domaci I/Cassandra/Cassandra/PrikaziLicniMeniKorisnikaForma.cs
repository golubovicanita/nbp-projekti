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
    public partial class PrikaziLicniMeniKorisnikaForma : Form
    {
        string korisnik;
        public PrikaziLicniMeniKorisnikaForma()
        {
            InitializeComponent();
        }
        public PrikaziLicniMeniKorisnikaForma(string k)
        {
            InitializeComponent();
            korisnik = k;
        }
        public void popuniPodacima()
        {

            List<LicniMeni_by_korisnikID> meniji = DataProvider.GetLicniMenijiKorisnika(korisnik);
            this.licniMeni.Items.Clear();
            foreach (LicniMeni_by_korisnikID m in meniji)
            {
                string imeRestorana = DataProvider.GetRestoran(m.restoranID).naziv;
                foreach (string s in m.spisak)
                {
                    ListViewItem item = new ListViewItem(new string[] { m.restoranID.ToString(), imeRestorana,  m.licniMeniID.ToString(), s });
                    this.licniMeni.Items.Add(item);
                }


            }
            this.licniMeni.Refresh();
        }
        private void PrikaziLicniMeniKorisnikaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
