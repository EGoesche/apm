namespace apm.Forms
{
    partial class KundenSuchen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_suche = new System.Windows.Forms.Panel();
            this.tb_land = new System.Windows.Forms.TextBox();
            this.lb_land = new System.Windows.Forms.Label();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.lb_adresse = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_kundennummer = new System.Windows.Forms.TextBox();
            this.lb_kundennummer = new System.Windows.Forms.Label();
            this.pn_anzeige = new System.Windows.Forms.Panel();
            this.dgv_fluegeKunden = new System.Windows.Forms.DataGridView();
            this.pn_form = new System.Windows.Forms.Panel();
            this.btn_auswaehlen = new FontAwesome.Sharp.IconButton();
            this.ibtn_fluegeKunden = new FontAwesome.Sharp.IconButton();
            this.btn_zuruecksetzen = new FontAwesome.Sharp.IconButton();
            this.ibtn_suche = new FontAwesome.Sharp.IconButton();
            this.pn_suche.SuspendLayout();
            this.pn_anzeige.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fluegeKunden)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_suche
            // 
            this.pn_suche.Controls.Add(this.btn_zuruecksetzen);
            this.pn_suche.Controls.Add(this.tb_land);
            this.pn_suche.Controls.Add(this.lb_land);
            this.pn_suche.Controls.Add(this.tb_adresse);
            this.pn_suche.Controls.Add(this.lb_adresse);
            this.pn_suche.Controls.Add(this.tb_name);
            this.pn_suche.Controls.Add(this.lb_name);
            this.pn_suche.Controls.Add(this.tb_kundennummer);
            this.pn_suche.Controls.Add(this.lb_kundennummer);
            this.pn_suche.Controls.Add(this.ibtn_suche);
            this.pn_suche.Location = new System.Drawing.Point(0, 0);
            this.pn_suche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_suche.Name = "pn_suche";
            this.pn_suche.Size = new System.Drawing.Size(234, 364);
            this.pn_suche.TabIndex = 0;
            // 
            // tb_land
            // 
            this.tb_land.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_land.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_land.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_land.Location = new System.Drawing.Point(4, 242);
            this.tb_land.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_land.Name = "tb_land";
            this.tb_land.Size = new System.Drawing.Size(226, 31);
            this.tb_land.TabIndex = 13;
            this.tb_land.TextChanged += new System.EventHandler(this.tb_land_TextChanged);
            // 
            // lb_land
            // 
            this.lb_land.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_land.AutoSize = true;
            this.lb_land.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_land.Location = new System.Drawing.Point(2, 222);
            this.lb_land.Margin = new System.Windows.Forms.Padding(2, 8, 2, 4);
            this.lb_land.Name = "lb_land";
            this.lb_land.Size = new System.Drawing.Size(36, 16);
            this.lb_land.TabIndex = 12;
            this.lb_land.Text = "Land";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_adresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_adresse.Location = new System.Drawing.Point(4, 182);
            this.tb_adresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(226, 31);
            this.tb_adresse.TabIndex = 10;
            this.tb_adresse.TextChanged += new System.EventHandler(this.tb_adresse_TextChanged);
            // 
            // lb_adresse
            // 
            this.lb_adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_adresse.AutoSize = true;
            this.lb_adresse.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adresse.Location = new System.Drawing.Point(2, 162);
            this.lb_adresse.Margin = new System.Windows.Forms.Padding(2, 8, 2, 4);
            this.lb_adresse.Name = "lb_adresse";
            this.lb_adresse.Size = new System.Drawing.Size(55, 16);
            this.lb_adresse.TabIndex = 9;
            this.lb_adresse.Text = "Adresse";
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(4, 122);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(226, 31);
            this.tb_name.TabIndex = 7;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(2, 102);
            this.lb_name.Margin = new System.Windows.Forms.Padding(2, 8, 2, 4);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(43, 16);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Name";
            // 
            // tb_kundennummer
            // 
            this.tb_kundennummer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_kundennummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kundennummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kundennummer.Location = new System.Drawing.Point(4, 62);
            this.tb_kundennummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_kundennummer.Name = "tb_kundennummer";
            this.tb_kundennummer.Size = new System.Drawing.Size(226, 31);
            this.tb_kundennummer.TabIndex = 4;
            this.tb_kundennummer.TextChanged += new System.EventHandler(this.tb_kundennummer_TextChanged);
            // 
            // lb_kundennummer
            // 
            this.lb_kundennummer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kundennummer.AutoSize = true;
            this.lb_kundennummer.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kundennummer.Location = new System.Drawing.Point(2, 42);
            this.lb_kundennummer.Margin = new System.Windows.Forms.Padding(2, 8, 2, 4);
            this.lb_kundennummer.Name = "lb_kundennummer";
            this.lb_kundennummer.Size = new System.Drawing.Size(100, 16);
            this.lb_kundennummer.TabIndex = 3;
            this.lb_kundennummer.Text = "Kundennummer";
            // 
            // pn_anzeige
            // 
            this.pn_anzeige.Controls.Add(this.btn_auswaehlen);
            this.pn_anzeige.Controls.Add(this.dgv_fluegeKunden);
            this.pn_anzeige.Controls.Add(this.ibtn_fluegeKunden);
            this.pn_anzeige.Location = new System.Drawing.Point(238, 0);
            this.pn_anzeige.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_anzeige.Name = "pn_anzeige";
            this.pn_anzeige.Size = new System.Drawing.Size(362, 364);
            this.pn_anzeige.TabIndex = 1;
            // 
            // dgv_fluegeKunden
            // 
            this.dgv_fluegeKunden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_fluegeKunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fluegeKunden.Location = new System.Drawing.Point(13, 58);
            this.dgv_fluegeKunden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_fluegeKunden.Name = "dgv_fluegeKunden";
            this.dgv_fluegeKunden.ReadOnly = true;
            this.dgv_fluegeKunden.RowTemplate.Height = 24;
            this.dgv_fluegeKunden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fluegeKunden.Size = new System.Drawing.Size(338, 245);
            this.dgv_fluegeKunden.TabIndex = 4;
            // 
            // pn_form
            // 
            this.pn_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_form.Location = new System.Drawing.Point(0, 0);
            this.pn_form.Name = "pn_form";
            this.pn_form.Size = new System.Drawing.Size(600, 366);
            this.pn_form.TabIndex = 2;
            // 
            // btn_auswaehlen
            // 
            this.btn_auswaehlen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_auswaehlen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auswaehlen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_auswaehlen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_auswaehlen.IconColor = System.Drawing.Color.Black;
            this.btn_auswaehlen.IconSize = 16;
            this.btn_auswaehlen.Location = new System.Drawing.Point(228, 331);
            this.btn_auswaehlen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_auswaehlen.Name = "btn_auswaehlen";
            this.btn_auswaehlen.Rotation = 0D;
            this.btn_auswaehlen.Size = new System.Drawing.Size(123, 32);
            this.btn_auswaehlen.TabIndex = 16;
            this.btn_auswaehlen.Text = "Auswählen";
            this.btn_auswaehlen.UseVisualStyleBackColor = true;
            this.btn_auswaehlen.Click += new System.EventHandler(this.btn_auswaehlen_Click);
            // 
            // ibtn_fluegeKunden
            // 
            this.ibtn_fluegeKunden.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_fluegeKunden.Enabled = false;
            this.ibtn_fluegeKunden.FlatAppearance.BorderSize = 0;
            this.ibtn_fluegeKunden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_fluegeKunden.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtn_fluegeKunden.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_fluegeKunden.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtn_fluegeKunden.IconColor = System.Drawing.Color.Black;
            this.ibtn_fluegeKunden.IconSize = 16;
            this.ibtn_fluegeKunden.Location = new System.Drawing.Point(0, 0);
            this.ibtn_fluegeKunden.Margin = new System.Windows.Forms.Padding(2);
            this.ibtn_fluegeKunden.Name = "ibtn_fluegeKunden";
            this.ibtn_fluegeKunden.Rotation = 0D;
            this.ibtn_fluegeKunden.Size = new System.Drawing.Size(362, 35);
            this.ibtn_fluegeKunden.TabIndex = 3;
            this.ibtn_fluegeKunden.Text = "Kommende Flüge";
            this.ibtn_fluegeKunden.UseVisualStyleBackColor = true;
            // 
            // btn_zuruecksetzen
            // 
            this.btn_zuruecksetzen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_zuruecksetzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zuruecksetzen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_zuruecksetzen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_zuruecksetzen.IconColor = System.Drawing.Color.Black;
            this.btn_zuruecksetzen.IconSize = 16;
            this.btn_zuruecksetzen.Location = new System.Drawing.Point(4, 331);
            this.btn_zuruecksetzen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_zuruecksetzen.Name = "btn_zuruecksetzen";
            this.btn_zuruecksetzen.Rotation = 0D;
            this.btn_zuruecksetzen.Size = new System.Drawing.Size(226, 32);
            this.btn_zuruecksetzen.TabIndex = 15;
            this.btn_zuruecksetzen.Text = "Zurücksetzen";
            this.btn_zuruecksetzen.UseVisualStyleBackColor = true;
            this.btn_zuruecksetzen.Click += new System.EventHandler(this.btn_zuruecksetzen_Click);
            // 
            // ibtn_suche
            // 
            this.ibtn_suche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtn_suche.Enabled = false;
            this.ibtn_suche.FlatAppearance.BorderSize = 0;
            this.ibtn_suche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_suche.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtn_suche.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_suche.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtn_suche.IconColor = System.Drawing.Color.Black;
            this.ibtn_suche.IconSize = 16;
            this.ibtn_suche.Location = new System.Drawing.Point(4, 1);
            this.ibtn_suche.Margin = new System.Windows.Forms.Padding(2);
            this.ibtn_suche.Name = "ibtn_suche";
            this.ibtn_suche.Rotation = 0D;
            this.ibtn_suche.Size = new System.Drawing.Size(226, 35);
            this.ibtn_suche.TabIndex = 2;
            this.ibtn_suche.Text = "Suche";
            this.ibtn_suche.UseVisualStyleBackColor = true;
            // 
            // KundenSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pn_anzeige);
            this.Controls.Add(this.pn_suche);
            this.Controls.Add(this.pn_form);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KundenSuchen";
            this.Text = "KundenSuchen";
            this.Load += new System.EventHandler(this.KundenSuchen_Load);
            this.pn_suche.ResumeLayout(false);
            this.pn_suche.PerformLayout();
            this.pn_anzeige.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fluegeKunden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_suche;
        private System.Windows.Forms.Panel pn_anzeige;
        private FontAwesome.Sharp.IconButton ibtn_suche;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_kundennummer;
        private System.Windows.Forms.Label lb_kundennummer;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_land;
        private System.Windows.Forms.Label lb_land;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label lb_adresse;
        private FontAwesome.Sharp.IconButton btn_zuruecksetzen;
        private System.Windows.Forms.DataGridView dgv_fluegeKunden;
        private FontAwesome.Sharp.IconButton ibtn_fluegeKunden;
        private FontAwesome.Sharp.IconButton btn_auswaehlen;
        private System.Windows.Forms.Panel pn_form;
    }
}