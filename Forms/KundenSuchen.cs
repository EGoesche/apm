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
        private string _nextForm = null;
        private Form _currentForm;
        private List<Flug> Fluege { get; set; }
        public List<Kunde> Kunden { get; set; }
        public DataGridViewRow SelectedRow { get; set; }


        public KundenSuchen()
        {
            InitializeComponent();
        }

        public KundenSuchen(string nextForm)
        {
            InitializeComponent();
            Fluege = GetFluege();
            Kunden = GetKunden();
            _nextForm = nextForm;
        }

        /// <summary>
        /// Schliesst die aktuelle Form und oeffnet die uebergebene Form.
        /// </summary>
        /// <param name="form">Anzuzeigende Form</param>
        private void ZeigeForm(Form form)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }
            _currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pn_form.Controls.Add(form);
            pn_form.Tag = form;
            form.BringToFront();
            form.Show();
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

                Kunde kunde2 = new Kunde(1936122, "Flug storniert", "Jan", "Schmidt", DateTime.Now, 'm', 037183624, "j.schm@try.com",
                    "deutsch", "Gasse", "12b", 08213, "Stenn", "Deutschland");
                ksLufthansa.Add(kunde2, "1936122");

                Kunde kunde3 = new Kunde(1200836, "Flug gebucht", "Julia", "Meyer", DateTime.Now, 'w', 034821374, "julchen.mey@gmail.de",
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
        /// Erstelle Testdaten fuer Fluege
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
        /// Sucht nach Uebereinstimmungen in einer uebergebenen Kundenliste mit den angegebenen Parametern.
        /// Gibt eine Kundenliste aus, welche Kunden mit Uebereinstimmungen enthaelt.
        /// </summary>
        /// <param name="kundenliste">Kundenliste, in welcher gesucht werden soll</param>
        /// <param name="kundennummer">Gesuchte Kundennummer</param>
        /// <param name="name">Gesuchter Name</param>
        /// <param name="adresse">Gesuchte Adresse</param>
        /// <param name="land">Gesuchtes Land</param>
        /// <returns>Liste von Kunden mit Uebereinstimmungen</returns>
        private List<Kunde> SuchKunde(List<Kunde> kundenliste, int kundennummer, string name, string adresse, string land)
        {
            var uebereinstimmungen = new List<Kunde>();

            uebereinstimmungen.Add(kundenliste.Find(x => x.Vorname.Contains(name)));
           
            if (kundenliste.Contains(kundenliste.Find(x => x.Nachname.Contains(name))))
                uebereinstimmungen.Add(kundenliste.Find(x => x.Nachname.Contains(name)));


            return uebereinstimmungen;
        }


        /// <summary>
        /// Ueberprueft, ob alle TextBoxes leer sind. Wenn dies der Fall ist
        /// werden die kommenden Fluege angezeigt. Andernfalls wird eine Suchanfrage
        /// gestellt.
        /// </summary>
        /// <returns></returns>
        private void WechselKundenFluege()
        {
            if (tb_kundennummer.Text == "" && tb_name.Text == "" && tb_adresse.Text == "" && tb_land.Text == "")
            {
                dgv_fluegeKunden.DataSource = Fluege;
                ibtn_fluegeKunden.Text = "Kommende Flüge";
            }
            else
            {
                dgv_fluegeKunden.DataSource = Kunden;

                // Fange Fehler ab und ersetze die Kundennummer durch eine Null, falls keine
                // eingegeben wurde.
                try
                {
                    int userVal;
                    if (int.TryParse(tb_kundennummer.Text, out userVal))
                        dgv_fluegeKunden.DataSource = SuchKunde(Kunden, userVal, tb_name.Text, tb_adresse.Text, tb_land.Text);
                    else
                        dgv_fluegeKunden.DataSource = SuchKunde(Kunden, 0, tb_name.Text, tb_adresse.Text, tb_land.Text);
                    
                    ibtn_fluegeKunden.Text = "Suchergebnisse";
                    dgv_fluegeKunden.Columns["Site"].Visible = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
            }
        }


        /// <summary>
        /// Fuellt die DataGridView mit Fluegen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KundenSuchen_Load(object sender, EventArgs e)
        {
            dgv_fluegeKunden.DataSource = Fluege;
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

        /// <summary>
        /// Wenn alle TextBoxes leer sind werden kommende Fluege gezeigt.
        /// Andernfalls Kunden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_kundennummer_TextChanged(object sender, EventArgs e)
        {
            WechselKundenFluege();
        }

        /// <summary>
        /// Wenn alle TextBoxes leer sind werden kommende Fluege gezeigt.
        /// Andernfalls Kunden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            WechselKundenFluege();
        }

        /// <summary>
        /// Wenn alle TextBoxes leer sind werden kommende Fluege gezeigt.
        /// Andernfalls Kunden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_adresse_TextChanged(object sender, EventArgs e)
        {
            WechselKundenFluege();
        }

        /// <summary>
        /// Wenn alle TextBoxes leer sind werden kommende Fluege gezeigt.
        /// Andernfalls Kunden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_land_TextChanged(object sender, EventArgs e)
        {
            WechselKundenFluege();
        }

        /// <summary>
        /// Bestaetigt die Auswahl eines Kunden uber die Suchergebnisse und oeffnet
        /// das Fenster zum Bearbeiten.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_auswaehlen_Click(object sender, EventArgs e)
        {
            SelectedRow = dgv_fluegeKunden.Rows[dgv_fluegeKunden.CurrentCell.RowIndex];
            Console.WriteLine(this.Name);
            if (ibtn_fluegeKunden.Text == "Suchergebnisse")
            {
                if (_nextForm == "KundenAnzeigen")
                {
                    pn_anzeige.Visible = false;
                    pn_suche.Visible = false;
                    ZeigeForm(new KundenAnzeigen(this));
                }
                else
                {
                    pn_anzeige.Visible = false;
                    pn_suche.Visible = false;
                    ZeigeForm(new KundenBearbeiten(this));
                }
            }
            else
                // Die Implementation der Funktion, ueber welche ein Kunde auch anhand der kommenden
                // Fluege ausgewaehlt werden kann, ist in diesem Beleg nicht vorgesehen.
                MessageBox.Show("Bevor Sie einen Kunden auswählen können, müssen Sie diesen über das " +
                    "Suchformular finden.", "Hinweis");
        }
    }
}
