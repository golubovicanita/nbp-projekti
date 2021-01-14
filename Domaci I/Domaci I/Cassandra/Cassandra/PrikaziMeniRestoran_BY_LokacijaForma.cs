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
    public partial class PrikaziMeniRestoran_BY_LokacijaForma : Form
    {
        string restoranID;
        string izabranaLokacija;
        public PrikaziMeniRestoran_BY_LokacijaForma()
        {
            InitializeComponent();
        }
        public PrikaziMeniRestoran_BY_LokacijaForma(string id, string lokacija)
        {
            InitializeComponent();
            restoranID = id;
            izabranaLokacija = lokacija;
        }

        private void PrikaziMeniRestoran_BY_LokacijaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.txtRestoran.Text = DataProvider.GetRestoran(restoranID).naziv;
            this.txtLokacija.Text =izabranaLokacija;

            List<Meni> meniji = DataProvider.GetMenijeURestoranu(restoranID);
            this.listaMenija.Items.Clear();
            foreach (Meni m in meniji)
            {

                ListViewItem item = new ListViewItem(new string[] { m.meniID.ToString(), m.naziv.ToString(), m.tipJela.ToString(), m.kolicina.ToString(), m.cena.ToString() });
                this.listaMenija.Items.Add(item);
            }
            this.listaMenija.Refresh();
        }
    }
}
