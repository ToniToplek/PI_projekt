namespace ArenaTicketShop
{
    partial class UrediDvorana
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
            this.label2 = new System.Windows.Forms.Label();
            this.outputSektor = new System.Windows.Forms.DataGridView();
            this.actionNovaDvorana = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputSektor = new System.Windows.Forms.TextBox();
            this.actionNoviSektor = new System.Windows.Forms.Button();
            this.actionIzmjeniSektor = new System.Windows.Forms.Button();
            this.actionObrisi = new System.Windows.Forms.Button();
            this.outputSjedala = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.actionObrisiSjedalo = new System.Windows.Forms.Button();
            this.actionIzmjeniSjedalo = new System.Windows.Forms.Button();
            this.actionNovoSjedalo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.actionBrziUnos = new System.Windows.Forms.Button();
            this.actionBrisiSve = new System.Windows.Forms.Button();
            this.actionUrediDvoranu = new System.Windows.Forms.Button();
            this.actionObrisiDvoranu = new System.Windows.Forms.Button();
            this.actionOdustani = new System.Windows.Forms.Button();
            this.inputRed = new System.Windows.Forms.NumericUpDown();
            this.inputBroj = new System.Windows.Forms.NumericUpDown();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sektori = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.outputDvorana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputSektor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputSjedala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBroj)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Sektori.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upravljanje dvoranama";
            // 
            // outputDvorana
            // 
            this.outputDvorana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputDvorana.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputDvorana.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputDvorana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDvorana.Location = new System.Drawing.Point(35, 68);
            this.outputDvorana.Name = "outputDvorana";
            this.outputDvorana.RowHeadersVisible = false;
            this.outputDvorana.RowTemplate.Height = 24;
            this.outputDvorana.Size = new System.Drawing.Size(163, 317);
            this.outputDvorana.TabIndex = 1;
            this.outputDvorana.SelectionChanged += new System.EventHandler(this.outputDvorana_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dvorane";
            // 
            // outputSektor
            // 
            this.outputSektor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputSektor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputSektor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputSektor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputSektor.Location = new System.Drawing.Point(6, 20);
            this.outputSektor.Name = "outputSektor";
            this.outputSektor.RowHeadersVisible = false;
            this.outputSektor.RowTemplate.Height = 24;
            this.outputSektor.Size = new System.Drawing.Size(157, 317);
            this.outputSektor.TabIndex = 3;
            this.outputSektor.SelectionChanged += new System.EventHandler(this.outputSektor_SelectionChanged);
            // 
            // actionNovaDvorana
            // 
            this.actionNovaDvorana.Location = new System.Drawing.Point(35, 400);
            this.actionNovaDvorana.Name = "actionNovaDvorana";
            this.actionNovaDvorana.Size = new System.Drawing.Size(126, 38);
            this.actionNovaDvorana.TabIndex = 7;
            this.actionNovaDvorana.Text = "Nova dvorana";
            this.actionNovaDvorana.UseVisualStyleBackColor = true;
            this.actionNovaDvorana.Click += new System.EventHandler(this.actionNovaDvorana_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Naziv sektora:";
            // 
            // inputSektor
            // 
            this.inputSektor.Location = new System.Drawing.Point(188, 54);
            this.inputSektor.Name = "inputSektor";
            this.inputSektor.Size = new System.Drawing.Size(150, 22);
            this.inputSektor.TabIndex = 9;
            // 
            // actionNoviSektor
            // 
            this.actionNoviSektor.Location = new System.Drawing.Point(212, 96);
            this.actionNoviSektor.Name = "actionNoviSektor";
            this.actionNoviSektor.Size = new System.Drawing.Size(99, 25);
            this.actionNoviSektor.TabIndex = 10;
            this.actionNoviSektor.Text = "Novi sektor";
            this.actionNoviSektor.UseVisualStyleBackColor = true;
            this.actionNoviSektor.Click += new System.EventHandler(this.actionNoviSektor_Click);
            // 
            // actionIzmjeniSektor
            // 
            this.actionIzmjeniSektor.Location = new System.Drawing.Point(212, 127);
            this.actionIzmjeniSektor.Name = "actionIzmjeniSektor";
            this.actionIzmjeniSektor.Size = new System.Drawing.Size(99, 25);
            this.actionIzmjeniSektor.TabIndex = 11;
            this.actionIzmjeniSektor.Text = "Izmjeni";
            this.actionIzmjeniSektor.UseVisualStyleBackColor = true;
            this.actionIzmjeniSektor.Click += new System.EventHandler(this.actionIzmjeniSektor_Click);
            // 
            // actionObrisi
            // 
            this.actionObrisi.Location = new System.Drawing.Point(212, 158);
            this.actionObrisi.Name = "actionObrisi";
            this.actionObrisi.Size = new System.Drawing.Size(99, 25);
            this.actionObrisi.TabIndex = 12;
            this.actionObrisi.Text = "Obriši";
            this.actionObrisi.UseVisualStyleBackColor = true;
            this.actionObrisi.Click += new System.EventHandler(this.actionObrisi_Click);
            // 
            // outputSjedala
            // 
            this.outputSjedala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputSjedala.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputSjedala.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputSjedala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputSjedala.Location = new System.Drawing.Point(27, 36);
            this.outputSjedala.Name = "outputSjedala";
            this.outputSjedala.RowHeadersVisible = false;
            this.outputSjedala.RowTemplate.Height = 24;
            this.outputSjedala.Size = new System.Drawing.Size(157, 326);
            this.outputSjedala.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Red:";
            // 
            // actionObrisiSjedalo
            // 
            this.actionObrisiSjedalo.Location = new System.Drawing.Point(218, 169);
            this.actionObrisiSjedalo.Name = "actionObrisiSjedalo";
            this.actionObrisiSjedalo.Size = new System.Drawing.Size(99, 25);
            this.actionObrisiSjedalo.TabIndex = 19;
            this.actionObrisiSjedalo.Text = "Obriši";
            this.actionObrisiSjedalo.UseVisualStyleBackColor = true;
            this.actionObrisiSjedalo.Click += new System.EventHandler(this.actionObrisiSjedalo_Click);
            // 
            // actionIzmjeniSjedalo
            // 
            this.actionIzmjeniSjedalo.Location = new System.Drawing.Point(217, 138);
            this.actionIzmjeniSjedalo.Name = "actionIzmjeniSjedalo";
            this.actionIzmjeniSjedalo.Size = new System.Drawing.Size(99, 25);
            this.actionIzmjeniSjedalo.TabIndex = 18;
            this.actionIzmjeniSjedalo.Text = "Izmjeni";
            this.actionIzmjeniSjedalo.UseVisualStyleBackColor = true;
            this.actionIzmjeniSjedalo.Click += new System.EventHandler(this.actionIzmjeniSjedalo_Click);
            // 
            // actionNovoSjedalo
            // 
            this.actionNovoSjedalo.Location = new System.Drawing.Point(217, 107);
            this.actionNovoSjedalo.Name = "actionNovoSjedalo";
            this.actionNovoSjedalo.Size = new System.Drawing.Size(99, 25);
            this.actionNovoSjedalo.TabIndex = 17;
            this.actionNovoSjedalo.Text = "Novo sjedalo";
            this.actionNovoSjedalo.UseVisualStyleBackColor = true;
            this.actionNovoSjedalo.Click += new System.EventHandler(this.actionNovoSjedalo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Broj:";
            // 
            // actionBrziUnos
            // 
            this.actionBrziUnos.Location = new System.Drawing.Point(218, 207);
            this.actionBrziUnos.Name = "actionBrziUnos";
            this.actionBrziUnos.Size = new System.Drawing.Size(99, 38);
            this.actionBrziUnos.TabIndex = 22;
            this.actionBrziUnos.Text = "Brzi unos";
            this.actionBrziUnos.UseVisualStyleBackColor = true;
            this.actionBrziUnos.Click += new System.EventHandler(this.actionBrziUnos_Click);
            // 
            // actionBrisiSve
            // 
            this.actionBrisiSve.Location = new System.Drawing.Point(218, 251);
            this.actionBrisiSve.Name = "actionBrisiSve";
            this.actionBrisiSve.Size = new System.Drawing.Size(99, 38);
            this.actionBrisiSve.TabIndex = 23;
            this.actionBrisiSve.Text = "Obriši sve";
            this.actionBrisiSve.UseVisualStyleBackColor = true;
            this.actionBrisiSve.Click += new System.EventHandler(this.actionBrisiSve_Click);
            // 
            // actionUrediDvoranu
            // 
            this.actionUrediDvoranu.Location = new System.Drawing.Point(167, 400);
            this.actionUrediDvoranu.Name = "actionUrediDvoranu";
            this.actionUrediDvoranu.Size = new System.Drawing.Size(126, 38);
            this.actionUrediDvoranu.TabIndex = 24;
            this.actionUrediDvoranu.Text = "Uredi dvoranu";
            this.actionUrediDvoranu.UseVisualStyleBackColor = true;
            this.actionUrediDvoranu.Click += new System.EventHandler(this.actionUrediDvoranu_Click);
            // 
            // actionObrisiDvoranu
            // 
            this.actionObrisiDvoranu.Location = new System.Drawing.Point(299, 400);
            this.actionObrisiDvoranu.Name = "actionObrisiDvoranu";
            this.actionObrisiDvoranu.Size = new System.Drawing.Size(126, 38);
            this.actionObrisiDvoranu.TabIndex = 25;
            this.actionObrisiDvoranu.Text = "Obriši dvoranu";
            this.actionObrisiDvoranu.UseVisualStyleBackColor = true;
            this.actionObrisiDvoranu.Click += new System.EventHandler(this.actionObrisiDvoranu_Click);
            // 
            // actionOdustani
            // 
            this.actionOdustani.Location = new System.Drawing.Point(799, 406);
            this.actionOdustani.Name = "actionOdustani";
            this.actionOdustani.Size = new System.Drawing.Size(99, 38);
            this.actionOdustani.TabIndex = 26;
            this.actionOdustani.Text = "Odustani";
            this.actionOdustani.UseVisualStyleBackColor = true;
            this.actionOdustani.Click += new System.EventHandler(this.actionOdustani_Click);
            // 
            // inputRed
            // 
            this.inputRed.Location = new System.Drawing.Point(258, 33);
            this.inputRed.Name = "inputRed";
            this.inputRed.Size = new System.Drawing.Size(58, 22);
            this.inputRed.TabIndex = 27;
            // 
            // inputBroj
            // 
            this.inputBroj.Location = new System.Drawing.Point(259, 69);
            this.inputBroj.Name = "inputBroj";
            this.inputBroj.Size = new System.Drawing.Size(58, 22);
            this.inputBroj.TabIndex = 28;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://github.com/foivz/r19046/wiki/3.-Korisni%C4%8Dka-dokumentacija";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputSjedala);
            this.groupBox1.Controls.Add(this.inputBroj);
            this.groupBox1.Controls.Add(this.inputRed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.actionNovoSjedalo);
            this.groupBox1.Controls.Add(this.actionIzmjeniSjedalo);
            this.groupBox1.Controls.Add(this.actionObrisiSjedalo);
            this.groupBox1.Controls.Add(this.actionBrisiSve);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.actionBrziUnos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(554, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 371);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sjedala";
            // 
            // Sektori
            // 
            this.Sektori.Controls.Add(this.inputSektor);
            this.Sektori.Controls.Add(this.outputSektor);
            this.Sektori.Controls.Add(this.label4);
            this.Sektori.Controls.Add(this.actionObrisi);
            this.Sektori.Controls.Add(this.actionNoviSektor);
            this.Sektori.Controls.Add(this.actionIzmjeniSektor);
            this.Sektori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sektori.Location = new System.Drawing.Point(204, 48);
            this.Sektori.Name = "Sektori";
            this.Sektori.Size = new System.Drawing.Size(344, 346);
            this.Sektori.TabIndex = 30;
            this.Sektori.TabStop = false;
            this.Sektori.Text = "Sektori";
            // 
            // UrediDvorana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 456);
            this.Controls.Add(this.Sektori);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionObrisiDvoranu);
            this.Controls.Add(this.actionUrediDvoranu);
            this.Controls.Add(this.actionOdustani);
            this.Controls.Add(this.actionNovaDvorana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputDvorana);
            this.Controls.Add(this.label1);
            this.Name = "UrediDvorana";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje dvoranama";
            this.Load += new System.EventHandler(this.UrediDvorana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputDvorana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputSektor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputSjedala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBroj)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Sektori.ResumeLayout(false);
            this.Sektori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView outputDvorana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView outputSektor;
        private System.Windows.Forms.Button actionNovaDvorana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputSektor;
        private System.Windows.Forms.Button actionNoviSektor;
        private System.Windows.Forms.Button actionIzmjeniSektor;
        private System.Windows.Forms.Button actionObrisi;
        private System.Windows.Forms.DataGridView outputSjedala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button actionObrisiSjedalo;
        private System.Windows.Forms.Button actionIzmjeniSjedalo;
        private System.Windows.Forms.Button actionNovoSjedalo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button actionBrziUnos;
        private System.Windows.Forms.Button actionBrisiSve;
        private System.Windows.Forms.Button actionUrediDvoranu;
        private System.Windows.Forms.Button actionObrisiDvoranu;
        private System.Windows.Forms.Button actionOdustani;
        private System.Windows.Forms.NumericUpDown inputRed;
        private System.Windows.Forms.NumericUpDown inputBroj;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Sektori;
    }
}