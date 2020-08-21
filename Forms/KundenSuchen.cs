using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apm.Forms
{
    public partial class KundenSuchen : Form
    {
        private List<Flug> Fluege { get; set; }
        private List<Kunde> Kunden { get; set; }


        public KundenSuchen()
        {
            InitializeComponent();
            Fluege = GetFluege();
            Kunden = GetKunden();
        }


        /// <summary>
        /// Generiert einen Kundenstamm und fuellt ihn mit Testkunden. Die erstellten
        /// Daten werden in eine Liste gefuellt.
        /// </summary>
        /// <returns></returns>
        private List<Kunde> GetKunden()
        {
            var list = new List<Kunde>();

            Kundenstamm ksLufthansa = new Kundenstamm("Lufthansa");
            try
            {
                Kunde kunde1 = new Kunde(1273856, "unbekannt", "Hans", "Mueller", DateTime.Now, 'm', 0152017324, "h.mueller@test.de",
                    "deutsch", "Am Schwanenteich", "8", 09648, "Mittweida", "Deutschland");
                ksLufthansa.Add(kunde1, "1273856");

                Kunde kunde2 = new Kunde(1936122, "unbekannt", "Jan", "Schmidt", DateTime.Now, 'm', 037183624, "j.schm@try.com",
                    "deutsch", "Gasse", "12b", 08213, "Stenn", "Deutschland");
                ksLufthansa.Add(kunde2, "1936122");

                Kunde kunde3 = new Kunde(1200836, "unbekannt", "Julia", "Meyer", DateTime.Now, 'w', 034821374, "julchen.mey@gmail.de",
                    "deutsch", "Am Tor", "27a", 01283, "Tübingen", "Deutschland");
                ksLufthansa.Add(kunde3, "1200836");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Kunde konnte nicht hinzugefuegt werden: " + e.Message);
            }

            ComponentCollection kundenstammListe = ksLufthansa.Components;
            IEnumerator denum = kundenstammListe.GetEnumerator();

            while (denum.MoveNext())
            {
                list.Add((Kunde)denum.Current);
            }

            return list;
        }


        /// <summary>
        /// Erstelle Testdaten in Form von Fluegen
        /// </summary>
        /// <returns>Liste, welche die Fluege beinhaltet</returns>
        private List<Flug> GetFluege()
        {
            var list = new List<Flug>();

            list.Add(new Flug(4234, "FRA", "JFK", 
                new DateTime(2020, 09, 25, 10, 30, 00), new DateTime(2020, 09, 25, 19, 25, 00)));

            list.Add(new Flug(1932, "TXL", "MUC",
                new DateTime(2020, 09, 25, 11, 50, 00), new DateTime(2020, 09, 25, 12, 45, 00)));

            list.Add(new Flug(4234, "DUS", "AUH",
                new DateTime(2020, 09, 26, 06, 15, 00), new DateTime(2020, 09, 26, 20, 32, 00)));

            list.Add(new Flug(4234, "LEJ", "CDG",
                new DateTime(2020, 09, 28, 15, 40, 00), new DateTime(2020, 09, 28, 17, 02, 00)));

            return list;
        }


        /// <summary>
        /// Fuellt die DataGridView mit Fluegen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KundenSuchen_Load(object sender, EventArgs e)
        {
            dgv_fluege.DataSource = Fluege;
        }


        /// <summary>
        /// Leert die Textboxen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zuruecksetzen_Click(object sender, EventArgs e)
        {
            tb_kundennummer.Text = "";
            tb_name.Text = "";
            tb_adresse.Text = "";
            tb_land.Text = "";
        }
    }
}
