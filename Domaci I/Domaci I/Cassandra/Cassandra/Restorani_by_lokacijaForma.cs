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
    public partial class Restorani_by_lokacijaForma : Form
    {
        string izabranaLokacija;
        public Restorani_by_lokacijaForma()
        {
            InitializeComponent();
        }
        public Restorani_by_lokacijaForma(string lokacija)
        {
            InitializeComponent();
            izabranaLokacija = lokacija;
        }


        private void Restorani_by_lokacijaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<Restoran_by_lokacija> restorani = DataProvider.GetRestaurantsByLokacija(izabranaLokacija);
            if (restorani.Count() == 0)
            {
                MessageBox.Show("Nijedan restoran ne zadovoljava kriterijum." );
                Close();
            }
            this.restoraniLokacija.Items.Clear();
            foreach (Restoran_by_lokacija r in restorani)
            {

                ListViewItem item = new ListViewItem(new string[] { r.restoranID.ToString(), r.naziv.ToString(), r.adresa.ToString(), r.lokacija.ToString(), r.radnoVreme.ToString(), r.telefon.ToString(), r.vremeCekanja.ToString(), r.ocena.ToString(), r.uzivoMuzika.ToString() });
                this.restoraniLokacija.Items.Add(item);
            }
            this.restoraniLokacija.Refresh();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            //ovde dodam ove na lokaciji
            PrikaziMeniRestoran_BY_LokacijaForma forma = new PrikaziMeniRestoran_BY_LokacijaForma(this.restoraniLokacija.SelectedItems[0].SubItems[0].Text, izabranaLokacija);
            forma.ShowDialog();
        }
    }
}
