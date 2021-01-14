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
    public partial class DodajKorisnikaForma : Form
    {
        public DodajKorisnikaForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string ime = this.txtIme.Text;
            string prezime = this.txtPrezime.Text;
            string telefon = this.txtBroj.Text;
            Korisnik daLiPostojiSaTimTelefonom = DataProvider.GetKorisnik(telefon);
            if (daLiPostojiSaTimTelefonom.telefon == null)
            {
                bool dodat = DataProvider.AddKorisnik(ime, prezime, telefon);
                if (dodat)
                {
                    MessageBox.Show("Uspesno ste dodali korisnika!");
                }
                else
                {
                    MessageBox.Show("Neuspesno dodavanje korisnika!");
                }
                
            }
            else
            {
                MessageBox.Show("Postoji vec korisnik sa tim brojem.");
            }
            Close();
            
        }
    }
}
