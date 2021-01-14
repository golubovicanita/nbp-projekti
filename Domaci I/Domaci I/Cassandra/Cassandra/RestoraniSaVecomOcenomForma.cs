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
    public partial class RestoraniSaVecomOcenomForma : Form
    {
        int izabranaOcena;
        public RestoraniSaVecomOcenomForma()
        {
            InitializeComponent();
        }
        public RestoraniSaVecomOcenomForma(int ocena)
        {
            InitializeComponent();
            izabranaOcena = ocena;
        }

        private void RestoraniSaVecomOcenomForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<Restoran_by_ocena> restorani = DataProvider.GetRestaurantsByOcena(izabranaOcena);
            if (restorani.Count() == 0)
            {
                MessageBox.Show("Nijedan restoran ne zadovoljava kriterijum.");
                Close();
            }
            this.restorani.Items.Clear();
            foreach (Restoran_by_ocena r in restorani)
            {

                ListViewItem item = new ListViewItem(new string[] { r.restoranID.ToString(), r.naziv.ToString(), r.adresa.ToString(), r.lokacija.ToString(), r.radnoVreme.ToString(), r.telefon.ToString(), r.vremeCekanja.ToString(), r.ocena.ToString(), r.uzivoMuzika.ToString() });
                this.restorani.Items.Add(item);
            }
            this.restorani.Refresh();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            MeniRestoranaSaOcenomForma forma = new MeniRestoranaSaOcenomForma(this.restorani.SelectedItems[0].SubItems[0].Text, izabranaOcena);
            forma.ShowDialog();
            
        }
    }
}
