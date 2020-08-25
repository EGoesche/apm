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
        private Startfenster mainForm = null;
        private List<Flug> Fluege { get; set; }
        public List<Kunde> Kunden { get; set; }
        public DataGridViewRow SelectedRow { get; set; }


        public KundenSuchen()
        {
            InitializeComponent();
        }

        public KundenSuchen(Form callingForm, string nextForm)
        {
            InitializeComponent();
            mainForm = callingForm as Startfenster;
            Fluege = GetFluege();
            Kunden = mainForm.GetKunden();
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
                    ZeigeForm(new KundenAnzeigen(mainForm, this));
                }
                else
                {
                    pn_anzeige.Visible = false;
                    pn_suche.Visible = false;
                    ZeigeForm(new KundenBearbeiten(mainForm, this));
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
