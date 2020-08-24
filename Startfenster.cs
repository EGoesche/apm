using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apm.Forms;
using FontAwesome.Sharp;

namespace apm
{
    public partial class Startfenster : Form
    {
        private IconButton _currentButton;
        private Form _currentForm;

        public Startfenster()
        {
            InitializeComponent();
            ZeigeForm(new KundenHinzufuegen());
        }

        private void ZeigeForm(Form form)
        {
            if(_currentForm != null)
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
        /// Selektiert einen Menubutton und passt dementsprechend im Header 
        /// das Icon und den Titel an.
        /// </summary>
        /// <param name="senderButton">Button, welcher eine Selektierung anfordert</param>
        private void AktiviereButton(object senderButton)
        {
            if (senderButton != null)
            {
                DeaktiviereButton();
                _currentButton = (IconButton)senderButton;
                _currentButton.BackColor = Color.FromArgb(126, 214, 223);
                _currentButton.TextAlign = ContentAlignment.MiddleCenter;
                _currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentButton.ImageAlign = ContentAlignment.MiddleRight;

                ipb_seite.IconChar = _currentButton.IconChar;
                lb_formtitel.Text = _currentButton.Text;
            }
        }


        /// <summary>
        /// Hebt die Selektierung eines der Menubuttons auf.
        /// </summary>
        private void DeaktiviereButton()
        {
            if (_currentButton != null)
            {
                _currentButton.BackColor = Color.FromArgb(199, 236, 238);
                _currentButton.TextAlign = ContentAlignment.MiddleLeft;
                _currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void btn_hinzufuegen_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new KundenHinzufuegen());
        }

        private void btn_bearbeiten_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new KundenSuchen("KundenBearbeiten"));
        }

        private void btn_entfernen_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new KundenSuchen());
        }

        private void btn_informationenAbrufen_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new KundenSuchen("KundenAnzeigen"));
        }

        private void btn_umbuchen_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new Umbuchen());
        }

        private void btn_startManuell_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
        }
    }

}
