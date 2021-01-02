namespace ArenaTicketShop
{
    partial class ProsliDogadaji
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
            this.outputProsloDogadaji = new System.Windows.Forms.DataGridView();
            this.actionUrediDogadaj = new System.Windows.Forms.Button();
            this.actionOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.outputProsloDogadaji)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prošli događaji:";
            // 
            // outputProsloDogadaji
            // 
            this.outputProsloDogadaji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputProsloDogadaji.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputProsloDogadaji.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputProsloDogadaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputProsloDogadaji.Location = new System.Drawing.Point(15, 48);
            this.outputProsloDogadaji.Name = "outputProsloDogadaji";
            this.outputProsloDogadaji.RowHeadersVisible = false;
            this.outputProsloDogadaji.RowTemplate.Height = 24;
            this.outputProsloDogadaji.Size = new System.Drawing.Size(522, 352);
            this.outputProsloDogadaji.TabIndex = 4;
            // 
            // actionUrediDogadaj
            // 
            this.actionUrediDogadaj.Location = new System.Drawing.Point(556, 48);
            this.actionUrediDogadaj.Name = "actionUrediDogadaj";
            this.actionUrediDogadaj.Size = new System.Drawing.Size(90, 25);
            this.actionUrediDogadaj.TabIndex = 5;
            this.actionUrediDogadaj.Text = "Uredi";
            this.actionUrediDogadaj.UseVisualStyleBackColor = true;
            this.actionUrediDogadaj.Click += new System.EventHandler(this.actionUrediDogadaj_Click);
            // 
            // actionOdustani
            // 
            this.actionOdustani.Location = new System.Drawing.Point(556, 372);
            this.actionOdustani.Name = "actionOdustani";
            this.actionOdustani.Size = new System.Drawing.Size(90, 25);
            this.actionOdustani.TabIndex = 7;
            this.actionOdustani.Text = "Odustani";
            this.actionOdustani.UseVisualStyleBackColor = true;
            this.actionOdustani.Click += new System.EventHandler(this.actionOdustani_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://github.com/foivz/r19046/wiki/3.-Korisni%C4%8Dka-dokumentacija";
            // 
            // ProsliDogadaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 435);
            this.Controls.Add(this.actionOdustani);
            this.Controls.Add(this.actionUrediDogadaj);
            this.Controls.Add(this.outputProsloDogadaji);
            this.Controls.Add(this.label1);
            this.Name = "ProsliDogadaji";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prosli Dogadaji";
            this.Load += new System.EventHandler(this.ProsliDogadaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputProsloDogadaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView outputProsloDogadaji;
        private System.Windows.Forms.Button actionUrediDogadaj;
        private System.Windows.Forms.Button actionOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}