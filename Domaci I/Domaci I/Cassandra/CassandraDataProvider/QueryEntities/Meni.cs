using System;
using System.Collections.Generic;
using System.Text;

namespace CassandraDataProvider.QueryEntities
{
    public class Meni
    {
        public string restoranID { get; set; }
        public string meniID { get; set; }
        public string naziv { get; set; }
        public string tipJela { get; set; }
        public string kolicina { get; set; }
        public string cena { get; set; }


    }
}
