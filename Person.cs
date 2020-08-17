using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public string Geschlecht { get; set; }
        public int Telefonnummer { get; set; }
        public string EMailAdresse { get; set; }
        public string Staatsbuergerschaft { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public int Zip { get; set; }
        public string Wohnort { get; set; }
        public string Land { get; set; }

      

        public Person(string vorname, string nachname, DateTime geburtsdatum, string geschlecht, 
            int telefonnummer, string emailAdresse, string staatsbuergerschaft, string strasse, 
            string hausnummer, int zip, string wohnort, string land)
        {
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
