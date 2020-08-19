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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sprache = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_anmelden = new System.Windows.Forms.LinkLabel();
            this.startfensterMenu1 = new apm.StartfensterMenu();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btn_anmelden);
            this.panel1.Controls.Add(this.btn_sprache);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 0;
            // 
            // btn_sprache
            // 
            this.btn_sprache.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btn_sprache.AutoSize = true;
            this.btn_sprache.BackColor = System.Drawing.Color.Transparent;
            this.btn_sprache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sprache.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sprache.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_sprache.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btn_sprache.Location = new System.Drawing.Point(578, 39);
            this.btn_sprache.Name = "btn_sprache";
            this.btn_sprache.Size = new System.Drawing.Size(70, 18);
            this.btn_sprache.TabIndex = 1;
            this.btn_sprache.TabStop = true;
            this.btn_sprache.Text = "Sprache";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            // 
            // btn_anmelden
            // 
            this.btn_anmelden.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btn_anmelden.AutoSize = true;
            this.btn_anmelden.BackColor = System.Drawing.Color.Transparent;
            this.btn_anmelden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anmelden.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anmelden.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btn_anmelden.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btn_anmelden.Location = new System.Drawing.Point(681, 39);
            this.btn_anmelden.Name = "btn_anmelden";
            this.btn_anmelden.Size = new System.Drawing.Size(90, 18);
            this.btn_anmelden.TabIndex = 2;
            this.btn_anmelden.TabStop = true;
            this.btn_anmelden.Text = "Anmeldem";
            // 
            // startfensterMenu1
            // 
            this.startfensterMenu1.Location = new System.Drawing.Point(0, 79);
            this.startfensterMenu1.Name = "startfensterMenu1";
            this.startfensterMenu1.Size = new System.Drawing.Size(800, 360);
            this.startfensterMenu1.TabIndex = 1;
            // 
            // Startfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startfensterMenu1);
            this.Controls.Add(this.panel1);
            this.Name = "Startfenster";
            this.Text = "Startfenster";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel btn_sprache;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btn_anmelden;
        private StartfensterMenu startfensterMenu1;
    }
}

