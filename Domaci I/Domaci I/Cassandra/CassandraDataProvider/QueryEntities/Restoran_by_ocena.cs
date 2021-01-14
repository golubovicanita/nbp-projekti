using System;
using System.Collections.Generic;
using System.Text;

namespace CassandraDataProvider.QueryEntities
{
    public class Restoran_by_ocena
    {
        public string restoranID { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public string lokacija { get; set; }
        public string radnoVreme { get; set; }
        public string telefon { get; set; }
        public int vremeCekanja { get; set; }
        public int ocena { get; set; }
        public string uzivoMuzika { get; set; }
    }
}
