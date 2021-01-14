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
    public partial class PrikaziMeniRestoran_LokacijaMuzikaForma : Form
    {
        string restoranID, izabranaMuzika, izabranaLokacija;
        public PrikaziMeniRestoran_LokacijaMuzikaForma()
        {
            InitializeComponent();
        }
        public PrikaziMeniRestoran_LokacijaMuzikaForma(string id, string lok, string muz)
        {
            InitializeComponent();
            restoranID = id;
            izabranaLokacija = lok;
            izabranaMuzika = muz;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrikaziMeniRestoran_LokacijaMuzikaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.txtRestoran.Text = DataProvider.GetRestoran(restoranID).naziv;
            this.txtLokacija.Text = izabranaLokacija;
            this.txtMuzika.Text = izabranaMuzika;

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
