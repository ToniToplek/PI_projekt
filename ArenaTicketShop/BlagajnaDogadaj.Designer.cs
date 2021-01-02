namespace ArenaTicketShop
{
    partial class BlagajnaDogadaj
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputDvorana = new System.Windows.Forms.DataGridView();
            this.outputDogadaj = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.actionOdabir = new System.Windows.Forms.Button();
            this.actionDvorana = new System.Windows.Forms.Button();
            this.actionUrediDogadaj = new System.Windows.Forms.Button();
            this.actionNoviDogadaj = new System.Windows.Forms.Button();
            this.actionProsli = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.actionOdjava = new System.Windows.Forms.Button();
            this.actionBlagajne = new System.Windows.Forms.Button();
            this.actionKorisnik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputDvorana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDogadaj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dvorane:";
            // 
            // outputDvorana
            // 
            this.outputDvorana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputDvorana.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputDvorana.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputDvorana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDvorana.Location = new System.Drawing.Point(44, 67);
            this.outputDvorana.Name = "outputDvorana";
            this.outputDvorana.RowHeadersVisible = false;
            this.outputDvorana.RowTemplate.Height = 24;
            this.outputDvorana.Size = new System.Drawing.Size(246, 339);
            this.outputDvorana.TabIndex = 1;
            this.outputDvorana.SelectionChanged += new System.EventHandler(this.outputDvorana_SelectionChanged);
            // 
            // outputDogadaj
            // 
            this.outputDogadaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputDogadaj.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputDogadaj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputDogadaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDogadaj.Location = new System.Drawing.Point(349, 67);
            this.outputDogadaj.Name = "outputDogadaj";
            this.outputDogadaj.RowHeadersVisible = false;
            this.outputDogadaj.RowTemplate.Height = 24;
            this.outputDogadaj.Size = new System.Drawing.Size(522, 339);
            this.outputDogadaj.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(345, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Događaji:";
            // 
            // actionOdabir
            // 
            this.actionOdabir.Location = new System.Drawing.Point(767, 431);
            this.actionOdabir.Name = "actionOdabir";
            this.actionOdabir.Size = new System.Drawing.Size(104, 33);
            this.actionOdabir.TabIndex = 4;
            this.actionOdabir.Text = "Odabir";
            this.actionOdabir.UseVisualStyleBackColor = true;
            this.actionOdabir.Click += new System.EventHandler(this.actionOdabir_Click);
            // 
            // actionDvorana
            // 
            this.actionDvorana.Location = new System.Drawing.Point(44, 431);
            this.actionDvorana.Name = "actionDvorana";
            this.actionDvorana.Size = new System.Drawing.Size(131, 33);
            this.actionDvorana.TabIndex = 5;
            this.actionDvorana.Text = "Uredi dvoranu";
            this.actionDvorana.UseVisualStyleBackColor = true;
            this.actionDvorana.Click += new System.EventHandler(this.actionDvorana_Click);
            // 
            // actionUrediDogadaj
            // 
            this.actionUrediDogadaj.Location = new System.Drawing.Point(349, 431);
            this.actionUrediDogadaj.Name = "actionUrediDogadaj";
            this.actionUrediDogadaj.Size = new System.Drawing.Size(131, 33);
            this.actionUrediDogadaj.TabIndex = 6;
            this.actionUrediDogadaj.Text = "Uredi događaj";
            this.actionUrediDogadaj.UseVisualStyleBackColor = true;
            this.actionUrediDogadaj.Click += new System.EventHandler(this.actionUrediDogadaj_Click);
            // 
            // actionNoviDogadaj
            // 
            this.actionNoviDogadaj.Location = new System.Drawing.Point(486, 431);
            this.actionNoviDogadaj.Name = "actionNoviDogadaj";
            this.actionNoviDogadaj.Size = new System.Drawing.Size(131, 33);
            this.actionNoviDogadaj.TabIndex = 7;
            this.actionNoviDogadaj.Text = "Novi događaj";
            this.actionNoviDogadaj.UseVisualStyleBackColor = true;
            this.actionNoviDogadaj.Click += new System.EventHandler(this.actionNoviDogadaj_Click);
            // 
            // actionProsli
            // 
            this.actionProsli.Location = new System.Drawing.Point(623, 431);
            this.actionProsli.Name = "actionProsli";
            this.actionProsli.Size = new System.Drawing.Size(138, 33);
            this.actionProsli.TabIndex = 8;
            this.actionProsli.Text = "Prošli događaji";
            this.actionProsli.UseVisualStyleBackColor = true;
            this.actionProsli.Click += new System.EventHandler(this.actionProsli_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://github.com/foivz/r19046/wiki/3.-Korisni%C4%8Dka-dokumentacija";
            // 
            // actionOdjava
            // 
            this.actionOdjava.Location = new System.Drawing.Point(796, 12);
            this.actionOdjava.Name = "actionOdjava";
            this.actionOdjava.Size = new System.Drawing.Size(75, 33);
            this.actionOdjava.TabIndex = 9;
            this.actionOdjava.Text = "Odjava";
            this.actionOdjava.UseVisualStyleBackColor = true;
            this.actionOdjava.Click += new System.EventHandler(this.actionOdjava_Click);
            // 
            // actionBlagajne
            // 
            this.actionBlagajne.Location = new System.Drawing.Point(661, 12);
            this.actionBlagajne.Name = "actionBlagajne";
            this.actionBlagajne.Size = new System.Drawing.Size(100, 33);
            this.actionBlagajne.TabIndex = 10;
            this.actionBlagajne.Text = "Blagajne";
            this.actionBlagajne.UseVisualStyleBackColor = true;
            this.actionBlagajne.Click += new System.EventHandler(this.actionBlagajne_Click);
            // 
            // actionKorisnik
            // 
            this.actionKorisnik.Location = new System.Drawing.Point(555, 12);
            this.actionKorisnik.Name = "actionKorisnik";
            this.actionKorisnik.Size = new System.Drawing.Size(100, 33);
            this.actionKorisnik.TabIndex = 11;
            this.actionKorisnik.Text = "Korisnik";
            this.actionKorisnik.UseVisualStyleBackColor = true;
            this.actionKorisnik.Click += new System.EventHandler(this.actionKorisnik_Click);
            // 
            // BlagajnaDogadaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 489);
            this.Controls.Add(this.actionKorisnik);
            this.Controls.Add(this.actionBlagajne);
            this.Controls.Add(this.actionOdjava);
            this.Controls.Add(this.actionProsli);
            this.Controls.Add(this.actionNoviDogadaj);
            this.Controls.Add(this.actionUrediDogadaj);
            this.Controls.Add(this.actionDvorana);
            this.Controls.Add(this.actionOdabir);
            this.Controls.Add(this.outputDogadaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputDvorana);
            this.Controls.Add(this.label1);
            this.Name = "BlagajnaDogadaj";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir događaja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlagajnaDogadaj_FormClosing);
            this.Load += new System.EventHandler(this.BlagajnaDogadaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputDvorana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDogadaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView outputDvorana;
        private System.Windows.Forms.DataGridView outputDogadaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button actionOdabir;
        private System.Windows.Forms.Button actionDvorana;
        private System.Windows.Forms.Button actionUrediDogadaj;
        private System.Windows.Forms.Button actionNoviDogadaj;
        private System.Windows.Forms.Button actionProsli;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button actionOdjava;
        private System.Windows.Forms.Button actionBlagajne;
        private System.Windows.Forms.Button actionKorisnik;
    }
}