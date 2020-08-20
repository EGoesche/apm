namespace apm
{
    partial class PassagierinfoAnzeige
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_ergebnisse = new System.Windows.Forms.Panel();
            this.btn_auswaehlen = new System.Windows.Forms.Button();
            this.lb_kommendeFluege = new System.Windows.Forms.Label();
            this.lb_suche = new System.Windows.Forms.Label();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.btn_startmenu = new System.Windows.Forms.Button();
            this.pn_suche = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pn_ergebnisse.SuspendLayout();
            this.pn_suche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_ergebnisse
            // 
            this.pn_ergebnisse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.pn_ergebnisse.Controls.Add(this.btn_auswaehlen);
            this.pn_ergebnisse.Location = new System.Drawing.Point(762, 51);
            this.pn_ergebnisse.Margin = new System.Windows.Forms.Padding(4);
            this.pn_ergebnisse.Name = "pn_ergebnisse";
            this.pn_ergebnisse.Size = new System.Drawing.Size(567, 427);
            this.pn_ergebnisse.TabIndex = 17;
            // 
            // btn_auswaehlen
            // 
            this.btn_auswaehlen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_auswaehlen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btn_auswaehlen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_auswaehlen.FlatAppearance.BorderSize = 0;
            this.btn_auswaehlen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auswaehlen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_auswaehlen.ForeColor = System.Drawing.Color.White;
            this.btn_auswaehlen.Location = new System.Drawing.Point(382, 440);
            this.btn_auswaehlen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_auswaehlen.Name = "btn_auswaehlen";
            this.btn_auswaehlen.Size = new System.Drawing.Size(138, 0);
            this.btn_auswaehlen.TabIndex = 16;
            this.btn_auswaehlen.Text = "Auswählen";
            this.btn_auswaehlen.UseVisualStyleBackColor = false;
            // 
            // lb_kommendeFluege
            // 
            this.lb_kommendeFluege.AutoSize = true;
            this.lb_kommendeFluege.BackColor = System.Drawing.Color.Transparent;
            this.lb_kommendeFluege.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kommendeFluege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lb_kommendeFluege.Location = new System.Drawing.Point(804, 17);
            this.lb_kommendeFluege.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kommendeFluege.Name = "lb_kommendeFluege";
            this.lb_kommendeFluege.Size = new System.Drawing.Size(125, 25);
            this.lb_kommendeFluege.TabIndex = 20;
            this.lb_kommendeFluege.Text = "Flughistorie";
            // 
            // lb_suche
            // 
            this.lb_suche.AutoSize = true;
            this.lb_suche.BackColor = System.Drawing.Color.Transparent;
            this.lb_suche.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_suche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lb_suche.Location = new System.Drawing.Point(139, 17);
            this.lb_suche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_suche.Name = "lb_suche";
            this.lb_suche.Size = new System.Drawing.Size(255, 25);
            this.lb_suche.TabIndex = 19;
            this.lb_suche.Text = "Ausgewählter Passagier";
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zurueck.BackColor = System.Drawing.Color.Transparent;
            this.btn_zurueck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_zurueck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_zurueck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zurueck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zurueck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_zurueck.Location = new System.Drawing.Point(33, 499);
            this.btn_zurueck.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(198, 58);
            this.btn_zurueck.TabIndex = 18;
            this.btn_zurueck.Text = "Zurück";
            this.btn_zurueck.UseVisualStyleBackColor = false;
            // 
            // btn_startmenu
            // 
            this.btn_startmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_startmenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_startmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_startmenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_startmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startmenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_startmenu.Location = new System.Drawing.Point(253, 499);
            this.btn_startmenu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_startmenu.Name = "btn_startmenu";
            this.btn_startmenu.Size = new System.Drawing.Size(198, 58);
            this.btn_startmenu.TabIndex = 21;
            this.btn_startmenu.Text = "Startmenü";
            this.btn_startmenu.UseVisualStyleBackColor = false;
            // 
            // pn_suche
            // 
            this.pn_suche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.pn_suche.Controls.Add(this.dataGridView1);
            this.pn_suche.Location = new System.Drawing.Point(4, 51);
            this.pn_suche.Margin = new System.Windows.Forms.Padding(4);
            this.pn_suche.Name = "pn_suche";
            this.pn_suche.Size = new System.Drawing.Size(653, 427);
            this.pn_suche.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // PassagierinfoAnzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_startmenu);
            this.Controls.Add(this.pn_suche);
            this.Controls.Add(this.pn_ergebnisse);
            this.Controls.Add(this.lb_kommendeFluege);
            this.Controls.Add(this.lb_suche);
            this.Controls.Add(this.btn_zurueck);
            this.Name = "PassagierinfoAnzeige";
            this.Size = new System.Drawing.Size(1333, 578);
            this.pn_ergebnisse.ResumeLayout(false);
            this.pn_suche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn_ergebnisse;
        private System.Windows.Forms.Button btn_auswaehlen;
        private System.Windows.Forms.Label lb_kommendeFluege;
        private System.Windows.Forms.Label lb_suche;
        private System.Windows.Forms.Button btn_zurueck;
        private System.Windows.Forms.Button btn_startmenu;
        private System.Windows.Forms.Panel pn_suche;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
