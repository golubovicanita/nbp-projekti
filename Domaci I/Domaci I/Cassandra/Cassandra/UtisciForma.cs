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
    public partial class UtisciForma : Form
    {
        string restoranID;
        public UtisciForma()
        {
            InitializeComponent();
        }
        public UtisciForma(string r)
        {
            InitializeComponent();
            restoranID = r;
        }

        private void UtisciForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txtRestoran.Text = DataProvider.GetRestoran(restoranID).naziv;
            List<Utisci> utisci = DataProvider.GetUtisciRestoran(restoranID);
            this.utisci.Items.Clear();
            foreach (Utisci u in utisci)
            {

                ListViewItem item = new ListViewItem(new string[] { u.korisnikID.ToString(), u.ocena.ToString(), u.komentar.ToString(), u.utisakID.ToString() });
                this.utisci.Items.Add(item);
            }
            this.utisci.Refresh();
        }
    }
}
