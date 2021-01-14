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
    public partial class Restorani_by_lokacijaMuzikaForma : Form
    {
        string izabranaLokacija;
        string izabranaMuzika; 
        public Restorani_by_lokacijaMuzikaForma()
        {
            InitializeComponent();
        }
        public Restorani_by_lokacijaMuzikaForma(string lokacija, string muzika)
        {
            InitializeComponent();
            izabranaLokacija = lokacija;
            izabranaMuzika = muzika;
        }

        private void Restorani_by_lokacijaMuzikaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<Restoran_by_lokacijaANDmuzika> restorani = DataProvider.GetRestaurantsByLokacijaImuzika(izabranaLokacija, izabranaMuzika);
            if (restorani.Count() == 0)
            {
                MessageBox.Show("Nijedan restoran ne zadovoljava kriterijum.");
                Close();
            }
            this.listLokacijaMuzika.Items.Clear();
            foreach (Restoran_by_lokacijaANDmuzika r in restorani)
            {

                ListViewItem item = new ListViewItem(new string[] { r.restoranID.ToString(), r.naziv.ToString(), r.adresa.ToString(), r.lokacija.ToString(), r.radnoVreme.ToString(), r.telefon.ToString(), r.vremeCekanja.ToString(), r.ocena.ToString(), r.uzivoMuzika.ToString() });
                this.listLokacijaMuzika.Items.Add(item);
            }
            this.listLokacijaMuzika.Refresh();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PrikaziMeniRestoran_LokacijaMuzikaForma forma = new PrikaziMeniRestoran_LokacijaMuzikaForma(this.listLokacijaMuzika.SelectedItems[0].SubItems[0].Text, izabranaLokacija, izabranaMuzika);
            forma.ShowDialog();
        }
    }
}
