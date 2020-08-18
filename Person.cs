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
        // Definition, Get und Set fuer die einzelnen Attribute einer Person
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

      
        /// <summary>
        /// Konstruktor Person
        /// </summary>
        /// <param name="vorname">Vorname der Person</param>
        /// <param name="nachname">Nachname der Person</param>
        /// <param name="geburtsdatum">Geburtsdatum der Person</param>
        /// <param name="geschlecht">Geschlecht der Person</param>
        /// <param name="telefonnummer">Telefonnummer der Person</param>
        /// <param name="emailAdresse">E-Mail-Adresse der Person</param>
        /// <param name="staatsbuergerschaft">Staatsbuergerschaft der Person</param>
        /// <param name="strasse">Strasse, in welcher die Person wohnhaft ist</param>
        /// <param name="hausnummer">Hausnummer des Hauses, in welches die Person wohnhaft ist</param>
        /// <param name="zip">ZIP-Code oder Postleizahl des Wohnortes der Person</param>
        /// <param name="wohnort">Wohnort der Person</param>
        /// <param name="land">Land, in welches die Person wohnhaft ist</param>
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
