using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    /// <summary>
    /// Der Kunde ist eine Komponente, welche einem Kundenstamm zugeordnet werden 
    /// kann. Er erbt von der Person.
    /// </summary>
    class Kunde : Person, IComponent
    {
        private ISite _curKundennummerSite;
        public event EventHandler Disposed;
        public int Kundenummer { get; set; }
        public string Status { get; set; }


        /// <summary>
        /// Konstruktor Kunde
        /// </summary>
        /// <param name="kundennummer">Nummer, ueber welche der Kunde eindeutig identifizierbar ist</param>
        /// <param name="status">Aktueller Status der Flugabfertigung, in welchem sich der Kunde befindet</param>
        /// <param name="vorname">Vorname des Kunden</param>
        /// <param name="nachname">Nachname des Kunden</param>
        /// <param name="geburtsdatum">Geburtsdatum des Kunden</param>
        /// <param name="geschlecht">Geschlecht des Kunden</param>
        /// <param name="telefonnummer">Telefonnummer des Kunden</param>
        /// <param name="emailAdresse">E-Mail-Adresse des Kunden</param>
        /// <param name="staatsbuergerschaft">Staatsbuergerschaft des Kunden</param>
        /// <param name="strasse">Strasse, in welcher der Kunde wohnhaft ist</param>
        /// <param name="hausnummer">Hausnummer des Hauses, in welches der Kunde wohnhaft ist</param>
        /// <param name="zip">ZIP-Code oder Postleizahl des Wohnortes des Kunden</param>
        /// <param name="wohnort">Wohnort des Kunden</param>
        /// <param name="land">Land, in welches der Kunde wohnhaft ist</param>
        public Kunde(int kundennummer, string status, string vorname, string nachname, 
            DateTime geburtsdatum, string geschlecht, int telefonnummer, 
            string emailAdresse, string staatsbuergerschaft, string strasse,
            string hausnummer, int zip, string wohnort, string land) : base(vorname, 
                nachname, geburtsdatum, geschlecht, telefonnummer, emailAdresse, 
                staatsbuergerschaft, strasse, hausnummer, zip, wohnort, land)
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

        
        /// <summary>
        /// Entfernt ein Kundenobjekt.
        /// </summary>
        public virtual void Dispose()
        {
            if (Disposed != null)
            {
                Disposed(this, EventArgs.Empty);
            }
        }

        
        /// <summary>
        /// Liefert bzw. setzt das Site Objekt
        /// </summary>
        public virtual ISite Site
        {
            get
            {
                return _curKundennummerSite;
            }
            set
            {
                _curKundennummerSite = value;
            }
        }

        
        /// <summary>
        /// Vergleich zwei Kundenobjekte miteinander.
        /// </summary>
        /// <param name="cmp">Zu vergleichendes Kundenobjekt</param>
        /// <returns></returns>
        public override bool Equals(object cmp)
        {
            Kunde cmpObj = (Kunde)cmp;
            if (this.Kundenummer.Equals(cmpObj.Kundenummer) && this.Status.Equals(cmpObj.Status) && 
                this.Vorname.Equals(cmpObj.Vorname) && this.Nachname.Equals(cmpObj.Nachname))
                return true;

            return false;
        }

        
        /// <summary>
        /// Liefert den HashCode des Kundenobjektes.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
