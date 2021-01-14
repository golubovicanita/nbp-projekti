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
    public partial class PrikaziSveRestoraneForm : Form
    {
        public string restoranID;
        public PrikaziSveRestoraneForm()
        {
            InitializeComponent();
            
        }

        public void popuniPodacima()
        {
            List<Restoran> restorani = DataProvider.GetRestaurants();
            this.ListaSvihRestorana.Items.Clear();
            foreach(Restoran r in restorani)
            {

                ListViewItem item = new ListViewItem(new string[] { r.restoranID.ToString(), r.naziv.ToString(), r.adresa.ToString(), r.lokacija.ToString(), r.radnoVreme.ToString(), r.telefon.ToString(), r.vremeCekanja.ToString(), r.ocena.ToString(), r.uzivoMuzika.ToString() });
                this.ListaSvihRestorana.Items.Add(item);
            }
            this.ListaSvihRestorana.Refresh();
        }
        private void PrikaziSveRestoraneForm_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }

        private void btnDodajRestoran_Click(object sender, EventArgs e)
        {
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (this.ListaSvihRestorana.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite restoran koji zelite da obrisete!");
                return;
            }

            string poruka = "Da li zelite da obrisete izabrani restoran?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DataProvider.deleteRestoran(this.ListaSvihRestorana.SelectedItems[0].SubItems[0].Text, this.ListaSvihRestorana.SelectedItems[0].SubItems[3].Text, Int32.Parse(this.ListaSvihRestorana.SelectedItems[0].SubItems[6].Text), Int32.Parse(this.ListaSvihRestorana.SelectedItems[0].SubItems[7].Text), this.ListaSvihRestorana.SelectedItems[0].SubItems[8].Text);
                MessageBox.Show("Brisanje restorana je uspesno obavljeno!");
                this.popuniPodacima();

            }
            else
            {
                MessageBox.Show("Brisanje restorana je otkazano!");
            }
        }

        private void btnPrikaziMeni_Click(object sender, EventArgs e)
        {
            
            MeniRestoranaForma forma = new MeniRestoranaForma(this.ListaSvihRestorana.SelectedItems[0].SubItems[0].Text);
            forma.ShowDialog();
        }

        private void btnUtisci_Click(object sender, EventArgs e)
        {
            UtisciForma forma = new UtisciForma(this.ListaSvihRestorana.SelectedItems[0].SubItems[0].Text);
            forma.ShowDialog();
            Refresh();
        }

        private void btnAddUtisak_Click(object sender, EventArgs e)
        {
            DodajUtisakForma forma = new DodajUtisakForma(this.ListaSvihRestorana.SelectedItems[0].SubItems[0].Text);
            forma.ShowDialog();
            Refresh();

        }

        /* private void brnDodajUMeni_Click(object sender, EventArgs e)
         {
             DodajUMeniForma forma = new DodajUMeniForma(this.ListaSvihRestorana.SelectedItems[0].SubItems[0].Text);
             forma.ShowDialog();

         }*/
    }
}
