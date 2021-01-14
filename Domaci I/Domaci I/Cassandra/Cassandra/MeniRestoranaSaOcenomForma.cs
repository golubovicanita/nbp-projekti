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
    public partial class MeniRestoranaSaOcenomForma : Form
    {
        string restoranID;
        int izabranaOcena;

        public MeniRestoranaSaOcenomForma()
        {
            InitializeComponent();
        }
        public MeniRestoranaSaOcenomForma(string id, int ocena)
        {
            InitializeComponent();
            restoranID = id;
            izabranaOcena = ocena;
        }

        private void MeniRestoranaSaOcenomForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.txtRestoran.Text = DataProvider.GetRestoran(restoranID).naziv;
            this.txtOcena.Text = izabranaOcena.ToString();

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
