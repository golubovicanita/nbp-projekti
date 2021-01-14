using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cassandra;
using CassandraDataProvider.QueryEntities;
namespace CassandraDataProvider
{
    public static class DataProvider
    {
        #region Restoran
        public static List<Restoran> GetRestaurants()
        {
            ISession session = SessionManager.GetSession();
            List<Restoran> restorani = new List<Restoran>();
            if (session == null)
                return null;
            var restoraniData = session.Execute("select * from \"Restoran\"");
            foreach (var restoranData in restoraniData)
            {
                Restoran restoran = new Restoran();
                restoran.restoranID = restoranData["restoranID"] != null ? restoranData["restoranID"].ToString() : string.Empty;
                restoran.naziv = restoranData["naziv"] != null ? restoranData["naziv"].ToString() : string.Empty;
                restoran.adresa = restoranData["adresa"] != null ? restoranData["adresa"].ToString() : string.Empty;
                restoran.lokacija = restoranData["lokacija"] != null ? restoranData["lokacija"].ToString() : string.Empty;
                restoran.radnoVreme = restoranData["radnoVreme"] != null ? restoranData["radnoVreme"].ToString() : string.Empty;
                restoran.telefon = restoranData["telefon"] != null ? restoranData["telefon"].ToString() : string.Empty;
                restoran.vremeCekanja = restoranData["vremeCekanja"] != null ? (int)restoranData["vremeCekanja"]: 0;
                restoran.ocena = restoranData["ocena"] != null ? (int)restoranData["ocena"] : 0;
                restoran.uzivoMuzika = restoranData["uzivoMuzika"] != null ? restoranData["uzivoMuzika"].ToString() : string.Empty;
                restorani.Add(restoran);
            }
            return restorani;

        }
        public static List<Restoran_by_lokacija> GetRestaurantsByLokacija(string lokacija)
        {
            ISession session = SessionManager.GetSession();
            List<Restoran_by_lokacija> restorani = new List<Restoran_by_lokacija>();
            if (session == null)
                return null;
            var restoraniData = session.Execute("select * from \"Restoran_by_lokacija\" where lokacija = '" + lokacija+"'" );
            foreach (var restoranData in restoraniData)
            {
                Restoran_by_lokacija restoran = new Restoran_by_lokacija();
                restoran.restoranID = restoranData["restoranID"] != null ? restoranData["restoranID"].ToString() : string.Empty;
                restoran.naziv = restoranData["naziv"] != null ? restoranData["naziv"].ToString() : string.Empty;
                restoran.adresa = restoranData["adresa"] != null ? restoranData["adresa"].ToString() : string.Empty;
                restoran.lokacija = restoranData["lokacija"] != null ? restoranData["lokacija"].ToString() : string.Empty;
                restoran.radnoVreme = restoranData["radnoVreme"] != null ? restoranData["radnoVreme"].ToString() : string.Empty;
                restoran.telefon = restoranData["telefon"] != null ? restoranData["telefon"].ToString() : string.Empty;
                restoran.vremeCekanja = restoranData["vremeCekanja"] != null ? (int)restoranData["vremeCekanja"] : 0;
                restoran.ocena = restoranData["ocena"] != null ? (int)restoranData["ocena"] : 0;
                restoran.uzivoMuzika = restoranData["uzivoMuzika"] != null ? restoranData["uzivoMuzika"].ToString() : string.Empty;
                restorani.Add(restoran);
            }
            return restorani;

        }

        public static List<Restoran_by_ocena> GetRestaurantsByOcena(int ocena)
        {
            ISession session = SessionManager.GetSession();
            List<Restoran_by_ocena> restorani = new List<Restoran_by_ocena>();
            if (session == null)
                return null;
            var restoraniData = session.Execute("select * from \"Restoran_by_ocena\" where ocena >= " + ocena + " ALLOW FILTERING");
            foreach (var restoranData in restoraniData)
            {
                Restoran_by_ocena restoran = new Restoran_by_ocena();
                restoran.restoranID = restoranData["restoranID"] != null ? restoranData["restoranID"].ToString() : string.Empty;
                restoran.naziv = restoranData["naziv"] != null ? restoranData["naziv"].ToString() : string.Empty;
                restoran.adresa = restoranData["adresa"] != null ? restoranData["adresa"].ToString() : string.Empty;
                restoran.lokacija = restoranData["lokacija"] != null ? restoranData["lokacija"].ToString() : string.Empty;
                restoran.radnoVreme = restoranData["radnoVreme"] != null ? restoranData["radnoVreme"].ToString() : string.Empty;
                restoran.telefon = restoranData["telefon"] != null ? restoranData["telefon"].ToString() : string.Empty;
                restoran.vremeCekanja = restoranData["vremeCekanja"] != null ? (int)restoranData["vremeCekanja"] : 0;
                restoran.ocena = restoranData["ocena"] != null ? (int)restoranData["ocena"] : 0;
                restoran.uzivoMuzika = restoranData["uzivoMuzika"] != null ? restoranData["uzivoMuzika"].ToString() : string.Empty;
                restorani.Add(restoran);
            }
            return restorani;

        }
        public static List<Restoran_by_vremeCekanja> GetRestaurantsByVremeCekanja(int vreme)
        {
            ISession session = SessionManager.GetSession();
            List<Restoran_by_vremeCekanja> restorani = new List<Restoran_by_vremeCekanja>();
            if (session == null)
                return null;
            var restoraniData = session.Execute("select * from \"Restoran_by_vremeCekanja\" where \"vremeCekanja\" <= " + vreme + " ALLOW FILTERING");
            foreach (var restoranData in restoraniData)
            {
                Restoran_by_vremeCekanja restoran = new Restoran_by_vremeCekanja();
                restoran.restoranID = restoranData["restoranID"] != null ? restoranData["restoranID"].ToString() : string.Empty;
                restoran.naziv = restoranData["naziv"] != null ? restoranData["naziv"].ToString() : string.Empty;
                restoran.adresa = restoranData["adresa"] != null ? restoranData["adresa"].ToString() : string.Empty;
                restoran.lokacija = restoranData["lokacija"] != null ? restoranData["lokacija"].ToString() : string.Empty;
                restoran.radnoVreme = restoranData["radnoVreme"] != null ? restoranData["radnoVreme"].ToString() : string.Empty;
                restoran.telefon = restoranData["telefon"] != null ? restoranData["telefon"].ToString() : string.Empty;
                restoran.vremeCekanja = restoranData["vremeCekanja"] != null ? (int)restoranData["vremeCekanja"] : 0;
                restoran.ocena = restoranData["ocena"] != null ? (int)restoranData["ocena"] : 0;
                restoran.uzivoMuzika = restoranData["uzivoMuzika"] != null ? restoranData["uzivoMuzika"].ToString() : string.Empty;
                restorani.Add(restoran);
            }
            return restorani;

        }

        public static List<Restoran_by_lokacijaANDmuzika> GetRestaurantsByLokacijaImuzika(string lokacija, string muzika)
        {
            
            ISession session = SessionManager.GetSession();
            List<Restoran_by_lokacijaANDmuzika> restorani = new List<Restoran_by_lokacijaANDmuzika>();
            if (session == null)
                return null;
            var restoraniData = session.Execute("select * from \"Restoran_by_lokacijaANDmuzika\"  where lokacija= '" +lokacija+ "' AND \"uzivoMuzika\" = '" + muzika+ "'" );
            foreach (var restoranData in restoraniData)
            {
                Restoran_by_lokacijaANDmuzika restoran = new Restoran_by_lokacijaANDmuzika();
                restoran.restoranID = restoranData["restoranID"] != null ? restoranData["restoranID"].ToString() : string.Empty;
                restoran.naziv = restoranData["naziv"] != null ? restoranData["naziv"].ToString() : string.Empty;
                restoran.adresa = restoranData["adresa"] != null ? restoranData["adresa"].ToString() : string.Empty;
                restoran.lokacija = restoranData["lokacija"] != null ? restoranData["lokacija"].ToString() : string.Empty;
                restoran.radnoVreme = restoranData["radnoVreme"] != null ? restoranData["radnoVreme"].ToString() : string.Empty;
                restoran.telefon = restoranData["telefon"] != null ? restoranData["telefon"].ToString() : string.Empty;
                restoran.vremeCekanja = restoranData["vremeCekanja"] != null ? (int)restoranData["vremeCekanja"] : 0;
                restoran.ocena = restoranData["ocena"] != null ? (int)restoranData["ocena"] : 0;
                restoran.uzivoMuzika = restoranData["uzivoMuzika"] != null ? restoranData["uzivoMuzika"].ToString() : string.Empty;
                restorani.Add(restoran);
            }
            return restorani;

        }
        public static bool AddRestoran(string id, string naziv, string adresa, string lokacija, string radnoV, string telefon, int vremeC, int ocena, string muzika )
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
            {
                return false;
            }
            RowSet restoranData = session.Execute("insert into \"Restoran\" (\"restoranID\", naziv, adresa, lokacija, \"radnoVreme\", telefon, \"vremeCekanja\", ocena, \"uzivoMuzika\") values ('" + id + "', '" + naziv + "', '" + adresa + "', '"+lokacija+"', '"+radnoV+"', '"+telefon+"', "+ vremeC + ", " + ocena + ", '"+muzika+"') ");
            RowSet restoranData2 = session.Execute("insert into \"Restoran_by_lokacija\" (\"restoranID\", naziv, adresa, lokacija, \"radnoVreme\", telefon, \"vremeCekanja\", ocena, \"uzivoMuzika\") values ('" + id + "', '" + naziv + "', '" + adresa + "', '" + lokacija + "', '" + radnoV + "', '" + telefon + "', " + vremeC + ", " + ocena + ", '" + muzika + "') ");
            RowSet restoranData3 = session.Execute("insert into \"Restoran_by_ocena\" (\"restoranID\", naziv, adresa, lokacija, \"radnoVreme\", telefon, \"vremeCekanja\", ocena, \"uzivoMuzika\") values ('" + id + "', '" + naziv + "', '" + adresa + "', '" + lokacija + "', '" + radnoV + "', '" + telefon + "', " + vremeC + ", " + ocena + ", '" + muzika + "') ");
            RowSet restoranData4 = session.Execute("insert into \"Restoran_by_vremeCekanja\" (\"restoranID\", naziv, adresa, lokacija, \"radnoVreme\", telefon, \"vremeCekanja\", ocena, \"uzivoMuzika\") values ('" + id + "', '" + naziv + "', '" + adresa + "', '" + lokacija + "', '" + radnoV + "', '" + telefon + "', " + vremeC + ", " + ocena + ", '" + muzika + "') ");
            RowSet restoranData5 = session.Execute("insert into \"Restoran_by_lokacijaANDmuzika\" (\"restoranID\", naziv, adresa, lokacija, \"radnoVreme\", telefon, \"vremeCekanja\", ocena, \"uzivoMuzika\") values ('" + id + "', '" + naziv + "', '" + adresa + "', '" + lokacija + "', '" + radnoV + "', '" + telefon + "', " + vremeC + ", " + ocena + ", '" + muzika + "') ");
            return true;
        }
        public static Restoran GetRestoran(string id)
        {
            ISession session = SessionManager.GetSession();
            Restoran restoran = new Restoran();
            if (session == null)
                return null;
            Row restoranData = session.Execute("select * from \"Restoran\" where \"restoranID\" = '" + id + "'").FirstOrDefault();
            if (restoranData != null)
            {
                restoran.restoranID = restoranData["restoranID"] != null ? restoranData["restoranID"].ToString() : string.Empty;
                restoran.naziv = restoranData["naziv"] != null ? restoranData["naziv"].ToString() : string.Empty;
                restoran.adresa = restoranData["adresa"] != null ? restoranData["adresa"].ToString() : string.Empty;
                restoran.lokacija = restoranData["lokacija"] != null ? restoranData["lokacija"].ToString() : string.Empty;
                restoran.radnoVreme = restoranData["radnoVreme"] != null ? restoranData["radnoVreme"].ToString() : string.Empty;
                restoran.telefon = restoranData["telefon"] != null ? restoranData["telefon"].ToString() : string.Empty;
                restoran.vremeCekanja = restoranData["vremeCekanja"] != null ? (int)restoranData["vremeCekanja"] : 0;
                restoran.ocena = restoranData["ocena"] != null ? (int)restoranData["ocena"] : 0;
                restoran.uzivoMuzika = restoranData["uzivoMuzika"] != null ? restoranData["uzivoMuzika"].ToString() : string.Empty;
            }
            return restoran;
        }
        public static void deleteRestoran(string id, string lokacija, int vremeCekanja, int ocena, string uzivoMuzika)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return;
            RowSet restoranData = session.Execute("delete from \"Restoran\" where \"restoranID\" = '" + id + "'");
            RowSet restoran_by_lokacijaData = session.Execute("delete from \"Restoran_by_lokacija\" where lokacija = '"+ lokacija +"'  AND \"restoranID\" = '" + id + "'");
            RowSet restoran_by_ocenaData = session.Execute("delete from \"Restoran_by_ocena\" where ocena= " + ocena + " AND  \"restoranID\" = '" + id + "'");
            RowSet restoran_by_vremeCekanjaData = session.Execute("delete from \"Restoran_by_vremeCekanja\" where \"vremeCekanja\"= " + vremeCekanja + " AND  \"restoranID\" = '" + id + "'");
            RowSet restoran_by_lokacijaANDmuzikaData = session.Execute("delete from \"Restoran_by_lokacijaANDmuzika\" where lokacija= '" + lokacija + "' AND \"uzivoMuzika\"= '" + uzivoMuzika + "' AND \"restoranID\" = '" + id + "'");
        }
        #endregion
        #region Korisnik
        public static List<Korisnik> GetKorisnici()
        {
            ISession session = SessionManager.GetSession();
            List<Korisnik> korisnici = new List<Korisnik>();
            if (session == null)
                return null;
            var korisniciData = session.Execute("select * from \"Korisnik\"");
            foreach (var korisnikData in korisniciData)
            {
                Korisnik korisnik = new Korisnik();
                korisnik.telefon = korisnikData["telefon"] != null ? korisnikData["telefon"].ToString() : string.Empty;
                korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;
                
                korisnici.Add(korisnik);
            }
            return korisnici;

        }


        public static Korisnik GetKorisnik(string telefon)
        {
            ISession session = SessionManager.GetSession();
            Korisnik korisnik = new Korisnik();
            if (session == null)
                return null;
            Row korisnikData = session.Execute("select * from \"Korisnik\" where telefon = '"+telefon+"'").FirstOrDefault();
            if(korisnikData != null)
            {
               
                korisnik.telefon = korisnikData["telefon"] != null ? korisnikData["telefon"].ToString() : string.Empty;
                korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;

                
            }
            return korisnik;

        }
        public static void deleteKorisnik(string broj)
        {
            ISession session = SessionManager.GetSession();
            Korisnik k = new Korisnik();
            if (session == null)
                return;
            RowSet korisnikData = session.Execute("delete from \"Korisnik\" where telefon = '" + broj + "'");
        }
        public static bool AddKorisnik(string i, string p, string t)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
            {
                return false;
            }
            RowSet korisnikData = session.Execute("insert into \"Korisnik\" (telefon, ime, prezime) values ('" + t + "', '" + i + "', '" + p + "') ");
            return true;
        }
        #endregion
        #region Meni
        public static List<Meni> GetMenijeURestoranu(string restoranID)
        {
            ISession session = SessionManager.GetSession();
            List<Meni>meniji = new List<Meni>();
            if (session == null)
                return null;
            var menijiData = session.Execute("select * from \"Meni\" where \"restoranID\" = '"+ restoranID+"'");
            foreach (var meniData in menijiData)
            {
                Meni meni = new Meni();
                meni.restoranID = meniData["restoranID"] != null ? meniData["restoranID"].ToString() : string.Empty;
                meni.meniID = meniData["meniID"] != null ? meniData["meniID"].ToString() : string.Empty;
                meni.naziv = meniData["naziv"] != null ? meniData["naziv"].ToString() : string.Empty;
                meni.tipJela = meniData["tipJela"] != null ? meniData["tipJela"].ToString() : string.Empty;
                meni.kolicina = meniData["kolicina"] != null ? meniData["kolicina"].ToString(): string.Empty;
                meni.cena = meniData["cena"] != null ? meniData["cena"].ToString() : string.Empty;

                meniji.Add(meni);
            }
            return meniji;
        }
        public static Meni GetMeni(string restoranID, string meniID)
        {
            ISession session = SessionManager.GetSession();
            Meni meni = new Meni();
            if (session == null)
                return null;
            Row meniData = session.Execute("select * from \"Meni\" where \"restoranID\" = '" + restoranID + "' AND \"meniID\"= '" + meniID+"'").FirstOrDefault();
            if (meniData != null)
            {

                meni.restoranID = meniData["restoranID"] != null ? meniData["restoranID"].ToString() : string.Empty;
                meni.meniID = meniData["meniID"] != null ? meniData["meniID"].ToString() : string.Empty;
                meni.naziv = meniData["naziv"] != null ? meniData["naziv"].ToString() : string.Empty;
                meni.tipJela = meniData["tipJela"] != null ? meniData["tipJela"].ToString() : string.Empty;
                meni.kolicina = meniData["kolicina"] != null ? meniData["kolicina"].ToString() : string.Empty;
                meni.cena = meniData["cena"] != null ? meniData["cena"].ToString() : string.Empty;


            }
            return meni;
        }
        public static void deleteMeni(string restoranID, string meniID)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return;
            RowSet meniData = session.Execute("delete from \"Meni\" where \"restoranID\" = '" + restoranID + "' AND  \"meniID\"= '"+meniID+"'");
        }
        public static bool AddUMeni(string id, string meni, string naziv, string tip, string kolicina, string cena)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
            {
                return false;
            }
            RowSet meniData = session.Execute("insert into \"Meni\" (\"restoranID\", \"meniID\", naziv, \"tipJela\", kolicina, cena) values ('" + id + "', '" + meni + "', '" + naziv + "', '" + tip + "', '" + kolicina + "', '" + cena + "') ");
            return true;
        }

        #endregion

        #region Licni Meni
        public static void CreateLicniMeni(string restoranID, string korisnikID, string licniMeniID, List<string> lista)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
            {
                return;
            }

            RowSet licniMeniData = session.Execute("insert into \"LicniMeni\" (\"restoranID\", \"korisnikID\", \"licniMeniID\") values ('" + restoranID + "', '" + korisnikID + "', '" + licniMeniID + "')");
            RowSet licniMeniData2 = session.Execute("insert into \"LicniMeni_by_korisnikID\" (\"restoranID\", \"korisnikID\", \"licniMeniID\") values ('" + restoranID + "', '" + korisnikID + "', '" + licniMeniID + "')");
            RowSet data, data2;
            foreach (string l in lista)
            {
                data = session.Execute("update \"LicniMeni\" set spisak = spisak + { '" + l + "' } where \"restoranID\" = '" + restoranID + "' and \"korisnikID\"= '" + korisnikID + "' and \"licniMeniID\"= '" + licniMeniID + "'");
                data2 = session.Execute("update \"LicniMeni_by_korisnikID\" set spisak = spisak + { '" + l + "' } where \"restoranID\" = '" + restoranID + "' and \"korisnikID\"= '" + korisnikID + "' and \"licniMeniID\"= '" + licniMeniID + "'");

            }
        }
        public static LicniMeni GetLicniMeni(string restoranID, string korisnikID)
        {
             ISession session = SessionManager.GetSession();
             LicniMeni meni = new LicniMeni();
             if (session == null)
                 return null;
             Row meniData = session.Execute("select * from \"LicniMeni\" where \"restoranID\" = '" + restoranID + "' AND \"korisnikID\"= '" + korisnikID + "'").FirstOrDefault();
            if (meniData != null)
            {
                List<string> lista = new List<string>();
                meni.restoranID = meniData["restoranID"] != null ? meniData["restoranID"].ToString() : string.Empty;
                meni.korisnikID = meniData["korisnikID"] != null ? meniData["korisnikID"].ToString() : string.Empty;
                meni.licniMeniID = meniData["licniMeniID"] != null ? meniData["licniMeniID"].ToString() : string.Empty;
                meni.spisak = meniData["spisak"] != null ? (IEnumerable<string>) meniData["spisak"]: null;


             }
             return meni;
            
        }
        public static void DeleteIzLicnogMenija(string r, string k, string m)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return;
            RowSet meniData = session.Execute("delete from \"LicniMeni\" where \"restoranID\" = '" + r + "' AND  \"korisnikID\"= '" + k + "' and \"licniMeniID\"= '"+m+"'");
            RowSet meniData2 = session.Execute("delete from \"LicniMeni_by_korisnikID\" where \"licniMeniID\"= '" + m + "' and \"restoranID\" = '" + r + "' AND  \"korisnikID\"= '" + k + "' ");
        }
        public static List<LicniMeni> GetLicniMeniji(string r, string k)
        {
            ISession session = SessionManager.GetSession();
            List<LicniMeni> meniji = new List<LicniMeni>();
            if (session == null)
                return null;
            var menijiData = session.Execute("select * from \"LicniMeni\" where \"restoranID\" = '" + r + "' AND \"korisnikID\"= '" + k + "'");
            foreach (var meniData in menijiData)
            {
                LicniMeni meni = new LicniMeni();
                meni.restoranID = meniData["restoranID"] != null ? meniData["restoranID"].ToString() : string.Empty;
                meni.korisnikID = meniData["korisnikID"] != null ? meniData["korisnikID"].ToString() : string.Empty;
                meni.licniMeniID = meniData["licniMeniID"] != null ? meniData["licniMeniID"].ToString() : string.Empty;
                meni.spisak = meniData["spisak"] != null ? (IEnumerable<string>)meniData["spisak"] : null;
                meniji.Add(meni);

            }
            return meniji;
        }
        #endregion
        #region LicniMeni_by_korisnikID
        public static List<LicniMeni_by_korisnikID> GetLicniMenijiKorisnika( string k)
        {
            ISession session = SessionManager.GetSession();
            List<LicniMeni_by_korisnikID> meniji = new List<LicniMeni_by_korisnikID>();
            if (session == null)
                return null;
            var menijiData = session.Execute("select * from \"LicniMeni_by_korisnikID\" where \"korisnikID\"= '" + k + "'");
            foreach (var meniData in menijiData)
            {
                LicniMeni_by_korisnikID meni = new LicniMeni_by_korisnikID();
                meni.restoranID = meniData["restoranID"] != null ? meniData["restoranID"].ToString() : string.Empty;
                meni.korisnikID = meniData["korisnikID"] != null ? meniData["korisnikID"].ToString() : string.Empty;
                meni.licniMeniID = meniData["licniMeniID"] != null ? meniData["licniMeniID"].ToString() : string.Empty;
                meni.spisak = meniData["spisak"] != null ? (IEnumerable<string>)meniData["spisak"] : null;
                meniji.Add(meni);

            }
            return meniji;
        }
        #endregion

        #region Rezervacija_by_datum
        public static List<Rezervacija_by_datum> GetRezervacijeDatum(DateTime datum)
        {
           
            ISession session = SessionManager.GetSession();
            List<Rezervacija_by_datum> rezervacije = new List<Rezervacija_by_datum>();
            if (session == null)
                return null;
            var rezervacijeData = session.Execute("select * from \"Rezervacija_by_datum\" where datum= '" + datum.ToShortDateString() + "'" );
            foreach (var rezData in rezervacijeData)
            {
                Rezervacija_by_datum rez = new Rezervacija_by_datum();
                rez.restoranID = rezData["restoranID"] != null ? rezData["restoranID"].ToString() : string.Empty;
                rez.korisnikID = rezData["korisnikID"] != null ? rezData["korisnikID"].ToString() : string.Empty;
                rez.licniMeniID = rezData["licniMeniID"] != null ? rezData["licniMeniID"].ToString() : string.Empty;
                rez.rezervacijaID = rezData["rezervacijaID"] != null ? rezData["rezervacijaID"].ToString() : string.Empty;
                rez.datum = datum.ToShortDateString(); 
                rez.vremeOd = rezData["vremeOd"] != null ? rezData["vremeOd"].ToString() : string.Empty;
                rez.vremeDo = rezData["vremeDo"] != null ? rezData["vremeDo"].ToString() : string.Empty;
                rez.brojOsoba = rezData["brojOsoba"] != null ? (int)rezData["brojOsoba"] : 0;
                rezervacije.Add(rez);


            }
            return rezervacije;
        }
        #endregion
        #region Rezervacija
       
        public static bool Rezervisi(string restoranID, string korisnikID, string rezervacijaID, string licniMeniID, DateTime datum, string vremeOd, string vremeDo, int brojOsoba)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
            {
                return false;
            }

            
            RowSet rezervacijaData = session.Execute("insert into \"Rezervacija\" (\"restoranID\", \"korisnikID\", \"rezervacijaID\", \"licniMeniID\", datum, \"vremeOd\", \"vremeDo\", \"brojOsoba\") values ('" + restoranID + "', '" + korisnikID + "', '" + rezervacijaID + "', '" + licniMeniID + "', '" + datum.ToShortDateString() + "', '" + vremeOd + "', '" + vremeDo + "', " + brojOsoba + ")");
            RowSet rezervacija2Data = session.Execute("insert into \"Rezervacija_by_datum\" (\"restoranID\", \"korisnikID\", \"rezervacijaID\", \"licniMeniID\", datum, \"vremeOd\", \"vremeDo\", \"brojOsoba\") values ('" + restoranID + "', '" + korisnikID + "', '" + rezervacijaID + "', '" + licniMeniID + "', '" + datum.ToShortDateString() + "', '" + vremeOd + "', '" + vremeDo + "', " + brojOsoba + ")");
            RowSet rezervacija3Data = session.Execute("insert into \"Rezervacija_by_korisnikID\" (\"restoranID\", \"korisnikID\", \"rezervacijaID\", \"licniMeniID\", datum, \"vremeOd\", \"vremeDo\", \"brojOsoba\") values ('" + restoranID + "', '" + korisnikID + "', '" + rezervacijaID + "', '" + licniMeniID + "', '" + datum.ToShortDateString() + "', '" + vremeOd + "', '" + vremeDo + "', " + brojOsoba + ")");

            return true;

        }
        #endregion
        #region Rezervacija_by_korisnikID

        public static List<Rezervacija_by_korisnikID> GetRezervacijeKorisnika(string k)
        {

            ISession session = SessionManager.GetSession();
            List<Rezervacija_by_korisnikID> rezervacije = new List<Rezervacija_by_korisnikID>();
            if (session == null)
                return null;
            var rezervacijeData = session.Execute("select * from \"Rezervacija_by_korisnikID\" where \"korisnikID\"= '" + k + "'");
            foreach (var rezData in rezervacijeData)
            {
                Rezervacija_by_korisnikID rez = new Rezervacija_by_korisnikID();
                rez.restoranID = rezData["restoranID"] != null ? rezData["restoranID"].ToString() : string.Empty;
                rez.korisnikID = rezData["korisnikID"] != null ? rezData["korisnikID"].ToString() : string.Empty;
                rez.licniMeniID = rezData["licniMeniID"] != null ? rezData["licniMeniID"].ToString() : string.Empty;
                rez.rezervacijaID = rezData["rezervacijaID"] != null ? rezData["rezervacijaID"].ToString() : string.Empty;
                rez.datum = rezData["datum"] != null ? rezData["datum"].ToString() : string.Empty;//dodato
                rez.vremeOd = rezData["vremeOd"] != null ? rezData["vremeOd"].ToString() : string.Empty;
                rez.vremeDo = rezData["vremeDo"] != null ? rezData["vremeDo"].ToString() : string.Empty;
                rez.brojOsoba = rezData["brojOsoba"] != null ? (int)rezData["brojOsoba"] : 0;
                rezervacije.Add(rez);
                

            }
            return rezervacije;
        }
        public static void OtkaziRez(string res, string k, string rez, string l, DateTime d)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return;
           
            RowSet resData = session.Execute("delete from \"Rezervacija\" where \"restoranID\" = '" + res + "' and \"korisnikID\" = '" + k + "' and \"licniMeniID\" = '" + l + "' and \"rezervacijaID\" = '" + rez + "'");
            RowSet resData2 = session.Execute("delete from \"Rezervacija_by_korisnikID\" where \"korisnikID\" = '" + k + "' and \"restoranID\" = '" + res + "'  and \"licniMeniID\" = '" + l + "' and \"rezervacijaID\" = '" + rez + "'");
            RowSet resData3 = session.Execute("delete from \"Rezervacija_by_datum\" where datum = '"+d.ToShortDateString()+ "' and \"restoranID\" = '" + res + "'   and \"korisnikID\" = '" + k + "' and  \"rezervacijaID\" = '" + rez + "'");
        }
        #endregion
        #region Utisci
        public static void AddUtisak(string res, string k, int o, string kom, string ID)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
            {
                return ;
            }
            RowSet data = session.Execute("insert into \"Utisci\" (\"restoranID\", \"utisakID\", \"korisnikID\", ocena, komentar) values ('"+ res+ "', '" +ID + "', '" + k + "', " + o + ", '" + kom + "')");
        }
        public static List<Utisci> GetUtisciRestoran(string restoranID)
        {
            ISession session = SessionManager.GetSession();
            List<Utisci>utisci = new List<Utisci>();
            if (session == null)
                return null;
            var utisciData = session.Execute("select * from \"Utisci\" where \"restoranID\"= '" + restoranID + "'");
            foreach (var uData in utisciData)
            {
                Utisci utisak = new Utisci();
                utisak.restoranID = uData["restoranID"] != null ? uData["restoranID"].ToString() : string.Empty;
                utisak.utisakID = uData["utisakID"] != null ? uData["utisakID"].ToString() : string.Empty;
                utisak.korisnikID = uData["korisnikID"] != null ? uData["korisnikID"].ToString() : string.Empty;
                utisak.ocena = uData["ocena"] != null ? (int)uData["ocena"] : 0;
                utisak.komentar = uData["komentar"] != null ? uData["komentar"].ToString() : string.Empty;
                utisci.Add(utisak);


            }
            return utisci;
        }
        #endregion

    }
}

