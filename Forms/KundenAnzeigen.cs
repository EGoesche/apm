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
    public partial class KundenAnzeigen : Form
    {
        public List<Kunde> Kunden { get; set; }
        private KundenSuchen mainForm = null;

        public KundenAnzeigen()
        {
            InitializeComponent();
        }

        public KundenAnzeigen(Form callingForm)
        {
            mainForm = callingForm as KundenSuchen;
            InitializeComponent();
        }

        /// <summary>
        /// Uebertrage die Kundenliste von der Form KundenSuchen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KundenAnzeigen_Load(object sender, EventArgs e)
        {
            // Gib die im vorherigen Fenster ausgewaehlte Kundennummer aus
            tb_kundennummer.Text = this.mainForm.SelectedRow.Cells[0].Value.ToString();
            Kunden = this.mainForm.Kunden;
            //Kunden[1].
            // TODO: Suche in der Kundenliste nach dem Kundenobjekt mit der Kundennummer, welche in der SelectedRow steht
            // und schreibe alle seine Werte in die Textboxes
        }
    }
}
