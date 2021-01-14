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
    public partial class PrikaziMeniRestoranaSaKracimVremenomForma : Form
    {
        string restoranID;
        int vremeCekanja;
        public PrikaziMeniRestoranaSaKracimVremenomForma()
        {
            InitializeComponent();
        }
        public PrikaziMeniRestoranaSaKracimVremenomForma(string id, int vreme)
        {
            InitializeComponent();
            restoranID = id;
            vremeCekanja = vreme;
        }

        private void PrikaziMeniRestoranaSaKracimVremenomForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.txtRestoran.Text = DataProvider.GetRestoran(restoranID).naziv;
            this.txtVreme.Text = vremeCekanja.ToString();

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
