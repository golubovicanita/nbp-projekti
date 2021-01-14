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
    public partial class PrikaziRezervacijeZaDatumForma : Form
    {
        DateTime izabranDatum;
        public PrikaziRezervacijeZaDatumForma()
        {
            InitializeComponent();
        }
        public PrikaziRezervacijeZaDatumForma(DateTime datum)
        {
            InitializeComponent();
            izabranDatum = datum;
        }
        public void popuniPodacima()
        {
            List<Rezervacija_by_datum> rez = DataProvider.GetRezervacijeDatum(izabranDatum);
            this.listaRezervacija.Items.Clear();
            foreach (Rezervacija_by_datum r in rez)
            {
                string naziv = DataProvider.GetRestoran(r.restoranID).naziv;
                ListViewItem item = new ListViewItem(new string[] { r.restoranID.ToString(), naziv, r.korisnikID.ToString(), r.rezervacijaID.ToString(), r.licniMeniID.ToString(), r.datum.ToString(), r.vremeOd.ToString(), r.vremeDo.ToString(), r.brojOsoba.ToString() });
                this.listaRezervacija.Items.Add(item);
            }
            this.listaRezervacija.Refresh();
        }
        private void PrikaziRezervacijeZaDatumForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
