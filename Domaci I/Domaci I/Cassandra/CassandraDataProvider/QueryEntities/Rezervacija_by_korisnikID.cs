using System;
using System.Collections.Generic;
using System.Text;

namespace CassandraDataProvider.QueryEntities
{
    public  class Rezervacija_by_korisnikID
    {
        public string restoranID { get; set; }
        public string korisnikID { get; set; }
        public string rezervacijaID { get; set; }
        public string licniMeniID { get; set; }
        //public DateTime datum { get; set; }
        public string datum;
        public string vremeOd { get; set; }
        public string vremeDo { get; set; }
        public int brojOsoba { get; set; }
    }
}
