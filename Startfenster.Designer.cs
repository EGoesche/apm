namespace apm
{
    partial class Startfenster
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_header = new System.Windows.Forms.Panel();
            this.lbtn_anmelden = new System.Windows.Forms.LinkLabel();
            this.lbtn_sprache = new System.Windows.Forms.LinkLabel();
            this.lb_home = new System.Windows.Forms.Label();
            this.startfensterMenu = new apm.StartfensterMenu();
            this.passagierinfoSuche = new apm.PassagierinfoSuche();
            this.pn_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.pn_header.Controls.Add(this.lbtn_anmelden);
            this.pn_header.Controls.Add(this.lbtn_sprache);
            this.pn_header.Controls.Add(this.lb_home);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(999, 73);
            this.pn_header.TabIndex = 0;
            // 
            // lbtn_anmelden
            // 
            this.lbtn_anmelden.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(104)))), ((int)(((byte)(146)))));
            this.lbtn_anmelden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbtn_anmelden.AutoSize = true;
            this.lbtn_anmelden.BackColor = System.Drawing.Color.Transparent;
            this.lbtn_anmelden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbtn_anmelden.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtn_anmelden.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbtn_anmelden.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.lbtn_anmelden.Location = new System.Drawing.Point(878, 36);
            this.lbtn_anmelden.Name = "lbtn_anmelden";
            this.lbtn_anmelden.Size = new System.Drawing.Size(85, 18);
            this.lbtn_anmelden.TabIndex = 2;
            this.lbtn_anmelden.TabStop = true;
            this.lbtn_anmelden.Text = "Anmelden";
            // 
            // lbtn_sprache
            // 
            this.lbtn_sprache.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(104)))), ((int)(((byte)(146)))));
            this.lbtn_sprache.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbtn_sprache.AutoSize = true;
            this.lbtn_sprache.BackColor = System.Drawing.Color.Transparent;
            this.lbtn_sprache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbtn_sprache.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtn_sprache.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbtn_sprache.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.lbtn_sprache.Location = new System.Drawing.Point(762, 36);
            this.lbtn_sprache.Name = "lbtn_sprache";
            this.lbtn_sprache.Size = new System.Drawing.Size(70, 18);
            this.lbtn_sprache.TabIndex = 1;
            this.lbtn_sprache.TabStop = true;
            this.lbtn_sprache.Text = "Sprache";
            // 
            // lb_home
            // 
            this.lb_home.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_home.AutoSize = true;
            this.lb_home.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lb_home.Location = new System.Drawing.Point(435, 15);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(128, 44);
            this.lb_home.TabIndex = 0;
            this.lb_home.Text = "HOME";
            this.lb_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startfensterMenu
            // 
            this.startfensterMenu.Location = new System.Drawing.Point(0, 79);
            this.startfensterMenu.Name = "startfensterMenu";
            this.startfensterMenu.Size = new System.Drawing.Size(1000, 470);
            this.startfensterMenu.TabIndex = 1;
            this.startfensterMenu.Load += new System.EventHandler(this.startfensterMenu_Load);
            // 
            // passagierinfoSuche
            // 
            this.passagierinfoSuche.Location = new System.Drawing.Point(0, 77);
            this.passagierinfoSuche.Name = "passagierinfoSuche";
            this.passagierinfoSuche.Size = new System.Drawing.Size(1000, 470);
            this.passagierinfoSuche.TabIndex = 2;
            // 
            // Startfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 559);
            this.Controls.Add(this.passagierinfoSuche);
            this.Controls.Add(this.startfensterMenu);
            this.Controls.Add(this.pn_header);
            this.MinimumSize = new System.Drawing.Size(1015, 598);
            this.Name = "Startfenster";
            this.Text = "Startfenster";
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.LinkLabel lbtn_sprache;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.LinkLabel lbtn_anmelden;
        private StartfensterMenu startfensterMenu;
        private PassagierinfoSuche passagierinfoSuche;
    }
}

