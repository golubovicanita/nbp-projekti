using System;
using System.Collections.Generic;
using System.Text;

namespace CassandraDataProvider.QueryEntities
{
    public class LicniMeni
    {
         public string restoranID { get; set; }
         public string korisnikID { get; set; }
         public  string licniMeniID { get; set; }
         public IEnumerable<string> spisak { get; set; }
    }
}
