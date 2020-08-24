using System;
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
    public partial class KundenBearbeiten : Form
    {
        public List<Kunde> Kunden { get; set; }
        private KundenSuchen mainForm = null;
        private int _kundenIndex;

        public KundenBearbeiten()
        {
            InitializeComponent();
        }

        public KundenBearbeiten(Form callingForm)
        {
            mainForm = callingForm as KundenSuchen;
            InitializeComponent();
        }

        private void KundenBearbeiten_Load(object sender, EventArgs e)
        {
            Kunden = mainForm.Kunden;
            _kundenIndex = Kunden.FindIndex(a => a.Kundennummer == int.Parse(mainForm.SelectedRow.Cells[0].Value.ToString()));
            tb_kundennummer.Text = Kunden[_kundenIndex].Kundennummer.ToString();
            tb_vorname.Text = Kunden[_kundenIndex].Vorname.ToString();
            tb_nachname.Text = Kunden[_kundenIndex].Nachname.ToString();
            dtp_geburtsdatum.Value = Kunden[_kundenIndex].Geburtsdatum.Date;
            tb_strasse.Text = Kunden[_kundenIndex].Strasse.ToString();
            tb_zipCode.Text = Kunden[_kundenIndex].Zip.ToString();
            tb_wohnort.Text = Kunden[_kundenIndex].Wohnort.ToString();
            tb_land.Text = Kunden[_kundenIndex].Land.ToString();
            cb_status.SelectedItem = Kunden[_kundenIndex].Status.ToString();
            cb_geschlecht.SelectedItem = Kunden[_kundenIndex].Geschlecht.ToString();
            tb_staatsbuergerschaft.Text = Kunden[_kundenIndex].Staatsbuergerschaft.ToString();
            tb_hausnummer.Text = Kunden[_kundenIndex].Hausnummer.ToString();
            tb_telefonnummer.Text = Kunden[_kundenIndex].Telefonnummer.ToString();
            tb_email.Text = Kunden[_kundenIndex].EMailAdresse.ToString();
        }

        private void btn_speichern_Click(object sender, EventArgs e)
        {
            Kunden[_kundenIndex].Kundennummer = int.Parse(tb_kundennummer.Text);
            Kunden[_kundenIndex].Vorname = tb_vorname.Text;
            Kunden[_kundenIndex].Nachname = tb_nachname.Text;
            Kunden[_kundenIndex].Geburtsdatum = dtp_geburtsdatum.Value; // vllt muss zusaetliche Umwandlung erfolgen
            Kunden[_kundenIndex].Strasse = tb_strasse.Text;
            Kunden[_kundenIndex].Zip = int.Parse(tb_zipCode.Text);
            Kunden[_kundenIndex].Wohnort = tb_wohnort.Text;
            Kunden[_kundenIndex].Land = tb_land.Text;
            Kunden[_kundenIndex].Status = cb_status.SelectedItem.ToString(); // zusaetzliche Validierung muss erfolgen
            Kunden[_kundenIndex].Geschlecht = cb_geschlecht.SelectedItem.ToString().ToCharArray()[0]; // ebenso
            Kunden[_kundenIndex].Staatsbuergerschaft = tb_staatsbuergerschaft.Text;
            Kunden[_kundenIndex].Hausnummer = tb_hausnummer.Text;
            Kunden[_kundenIndex].Telefonnummer = int.Parse(tb_telefonnummer.Text);
            Kunden[_kundenIndex].EMailAdresse = tb_email.Text;
        }
    }
}
