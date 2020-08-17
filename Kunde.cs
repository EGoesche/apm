using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    class Kunde : Person
    {
        public int Kundenummer { get; set; }
        public string Status { get; set; }

        public Kunde(int kundennummer, string status, string vorname, string nachname, DateTime geburtsdatum, string geschlecht,
            int telefonnummer, string emailAdresse, string staatsbuergerschaft, string strasse,
            string hausnummer, int zip, string wohnort, string land) : base(vorname, nachname, geburtsdatum, geschlecht, 
                telefonnummer, emailAdresse, staatsbuergerschaft, strasse, hausnummer, zip, wohnort, land)
        {
            Kundenummer = kundennummer;
            Status = status;
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Geschlecht = geschlecht;
            Telefonnummer = telefonnummer;
            EMailAdresse = emailAdresse;
            Staatsbuergerschaft = staatsbuergerschaft;
            Strasse = strasse;
            Hausnummer = hausnummer;
            Zip = zip;
            Wohnort = wohnort;
            Land = land;
        }
    }
}
