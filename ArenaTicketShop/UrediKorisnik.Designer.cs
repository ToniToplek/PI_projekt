namespace ArenaTicketShop
{
    partial class UrediKorisnik
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
            this.outputKorisnik = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.actionUredi = new System.Windows.Forms.Button();
            this.actionNovi = new System.Windows.Forms.Button();
            this.actionOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputKorisnik)).BeginInit();
            this.SuspendLayout();
            // 
            // outputKorisnik
            // 
            this.outputKorisnik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputKorisnik.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputKorisnik.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputKorisnik.Location = new System.Drawing.Point(39, 57);
            this.outputKorisnik.Name = "outputKorisnik";
            this.outputKorisnik.RowHeadersVisible = false;
            this.outputKorisnik.RowTemplate.Height = 24;
            this.outputKorisnik.Size = new System.Drawing.Size(671, 293);
            this.outputKorisnik.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Korisnici";
            // 
            // actionUredi
            // 
            this.actionUredi.Location = new System.Drawing.Point(39, 369);
            this.actionUredi.Name = "actionUredi";
            this.actionUredi.Size = new System.Drawing.Size(100, 35);
            this.actionUredi.TabIndex = 24;
            this.actionUredi.Text = "Uredi";
            this.actionUredi.UseVisualStyleBackColor = true;
            this.actionUredi.Click += new System.EventHandler(this.actionUredi_Click);
            // 
            // actionNovi
            // 
            this.actionNovi.Location = new System.Drawing.Point(161, 369);
            this.actionNovi.Name = "actionNovi";
            this.actionNovi.Size = new System.Drawing.Size(100, 35);
            this.actionNovi.TabIndex = 25;
            this.actionNovi.Text = "Novi";
            this.actionNovi.UseVisualStyleBackColor = true;
            this.actionNovi.Click += new System.EventHandler(this.actionNovi_Click);
            // 
            // actionOdustani
            // 
            this.actionOdustani.Location = new System.Drawing.Point(610, 369);
            this.actionOdustani.Name = "actionOdustani";
            this.actionOdustani.Size = new System.Drawing.Size(100, 35);
            this.actionOdustani.TabIndex = 26;
            this.actionOdustani.Text = "Odustani";
            this.actionOdustani.UseVisualStyleBackColor = true;
            this.actionOdustani.Click += new System.EventHandler(this.actionOdustani_Click);
            // 
            // UrediKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.actionOdustani);
            this.Controls.Add(this.actionNovi);
            this.Controls.Add(this.actionUredi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputKorisnik);
            this.Name = "UrediKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi Korisnika";
            this.Load += new System.EventHandler(this.UrediKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputKorisnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView outputKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actionUredi;
        private System.Windows.Forms.Button actionNovi;
        private System.Windows.Forms.Button actionOdustani;
    }
}