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
            this.btn_zuruecksetzen = new FontAwesome.Sharp.IconButton();
            this.tb_land = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_kundennummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pn_anzeige = new System.Windows.Forms.Panel();
            this.btn_auswaehlen = new FontAwesome.Sharp.IconButton();
            this.dgv_fluege = new System.Windows.Forms.DataGridView();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pn_suche.SuspendLayout();
            this.pn_anzeige.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fluege)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_suche
            // 
            this.pn_suche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_suche.Controls.Add(this.btn_zuruecksetzen);
            this.pn_suche.Controls.Add(this.tb_land);
            this.pn_suche.Controls.Add(this.label4);
            this.pn_suche.Controls.Add(this.tb_adresse);
            this.pn_suche.Controls.Add(this.label3);
            this.pn_suche.Controls.Add(this.tb_name);
            this.pn_suche.Controls.Add(this.label2);
            this.pn_suche.Controls.Add(this.tb_kundennummer);
            this.pn_suche.Controls.Add(this.label1);
            this.pn_suche.Controls.Add(this.iconButton1);
            this.pn_suche.Location = new System.Drawing.Point(0, 0);
            this.pn_suche.Name = "pn_suche";
            this.pn_suche.Size = new System.Drawing.Size(301, 450);
            this.pn_suche.TabIndex = 0;
            // 
            // btn_zuruecksetzen
            // 
            this.btn_zuruecksetzen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_zuruecksetzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zuruecksetzen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_zuruecksetzen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_zuruecksetzen.IconColor = System.Drawing.Color.Black;
            this.btn_zuruecksetzen.IconSize = 16;
            this.btn_zuruecksetzen.Location = new System.Drawing.Point(0, 408);
            this.btn_zuruecksetzen.Name = "btn_zuruecksetzen";
            this.btn_zuruecksetzen.Rotation = 0D;
            this.btn_zuruecksetzen.Size = new System.Drawing.Size(301, 39);
            this.btn_zuruecksetzen.TabIndex = 15;
            this.btn_zuruecksetzen.Text = "Zurücksetzen";
            this.btn_zuruecksetzen.UseVisualStyleBackColor = true;
            this.btn_zuruecksetzen.Click += new System.EventHandler(this.btn_zuruecksetzen_Click);
            // 
            // tb_land
            // 
            this.tb_land.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_land.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_land.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_land.Location = new System.Drawing.Point(0, 299);
            this.tb_land.Name = "tb_land";
            this.tb_land.Size = new System.Drawing.Size(301, 31);
            this.tb_land.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Land";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_adresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_adresse.Location = new System.Drawing.Point(0, 225);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(301, 31);
            this.tb_adresse.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adresse";
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(0, 151);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(301, 31);
            this.tb_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // tb_kundennummer
            // 
            this.tb_kundennummer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_kundennummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kundennummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kundennummer.Location = new System.Drawing.Point(0, 77);
            this.tb_kundennummer.Name = "tb_kundennummer";
            this.tb_kundennummer.Size = new System.Drawing.Size(301, 31);
            this.tb_kundennummer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kundennummer";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(0, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(301, 43);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Suche";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // pn_anzeige
            // 
            this.pn_anzeige.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_anzeige.Controls.Add(this.btn_auswaehlen);
            this.pn_anzeige.Controls.Add(this.dgv_fluege);
            this.pn_anzeige.Controls.Add(this.iconButton2);
            this.pn_anzeige.Location = new System.Drawing.Point(301, 0);
            this.pn_anzeige.Name = "pn_anzeige";
            this.pn_anzeige.Size = new System.Drawing.Size(499, 450);
            this.pn_anzeige.TabIndex = 1;
            // 
            // btn_auswaehlen
            // 
            this.btn_auswaehlen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_auswaehlen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auswaehlen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_auswaehlen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_auswaehlen.IconColor = System.Drawing.Color.Black;
            this.btn_auswaehlen.IconSize = 16;
            this.btn_auswaehlen.Location = new System.Drawing.Point(335, 408);
            this.btn_auswaehlen.Name = "btn_auswaehlen";
            this.btn_auswaehlen.Rotation = 0D;
            this.btn_auswaehlen.Size = new System.Drawing.Size(164, 39);
            this.btn_auswaehlen.TabIndex = 16;
            this.btn_auswaehlen.Text = "Auswählen";
            this.btn_auswaehlen.UseVisualStyleBackColor = true;
            // 
            // dgv_fluege
            // 
            this.dgv_fluege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_fluege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fluege.Location = new System.Drawing.Point(17, 72);
            this.dgv_fluege.Name = "dgv_fluege";
            this.dgv_fluege.ReadOnly = true;
            this.dgv_fluege.RowTemplate.Height = 24;
            this.dgv_fluege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fluege.Size = new System.Drawing.Size(470, 306);
            this.dgv_fluege.TabIndex = 4;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(499, 43);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Kommende Flüge";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // KundenSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_anzeige);
            this.Controls.Add(this.pn_suche);
            this.Name = "KundenSuchen";
            this.Text = "KundenSuchen";
            this.Load += new System.EventHandler(this.KundenSuchen_Load);
            this.pn_suche.ResumeLayout(false);
            this.pn_suche.PerformLayout();
            this.pn_anzeige.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fluege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_suche;
        private System.Windows.Forms.Panel pn_anzeige;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_kundennummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_land;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_zuruecksetzen;
        private System.Windows.Forms.DataGridView dgv_fluege;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btn_auswaehlen;
    }
}