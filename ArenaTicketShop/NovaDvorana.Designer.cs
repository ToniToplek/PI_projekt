namespace ArenaTicketShop
{
    partial class NovaDvorana
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
            this.inputNazivDvorane = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.actionPotvrdiNaziv = new System.Windows.Forms.Button();
            this.actionOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv dvorane:";
            // 
            // inputNazivDvorane
            // 
            this.inputNazivDvorane.Location = new System.Drawing.Point(139, 66);
            this.inputNazivDvorane.Name = "inputNazivDvorane";
            this.inputNazivDvorane.Size = new System.Drawing.Size(161, 22);
            this.inputNazivDvorane.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova dvorana";
            // 
            // actionPotvrdiNaziv
            // 
            this.actionPotvrdiNaziv.Location = new System.Drawing.Point(102, 105);
            this.actionPotvrdiNaziv.Name = "actionPotvrdiNaziv";
            this.actionPotvrdiNaziv.Size = new System.Drawing.Size(90, 25);
            this.actionPotvrdiNaziv.TabIndex = 3;
            this.actionPotvrdiNaziv.Text = "Potvrdi";
            this.actionPotvrdiNaziv.UseVisualStyleBackColor = true;
            this.actionPotvrdiNaziv.Click += new System.EventHandler(this.actionPotvrdiNaziv_Click);
            // 
            // actionOdustani
            // 
            this.actionOdustani.Location = new System.Drawing.Point(210, 105);
            this.actionOdustani.Name = "actionOdustani";
            this.actionOdustani.Size = new System.Drawing.Size(90, 25);
            this.actionOdustani.TabIndex = 4;
            this.actionOdustani.Text = "Odustani";
            this.actionOdustani.UseVisualStyleBackColor = true;
            this.actionOdustani.Click += new System.EventHandler(this.actionOdustani_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://github.com/foivz/r19046/wiki/3.-Korisni%C4%8Dka-dokumentacija";
            // 
            // NovaDvorana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 153);
            this.Controls.Add(this.actionOdustani);
            this.Controls.Add(this.actionPotvrdiNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNazivDvorane);
            this.Controls.Add(this.label1);
            this.Name = "NovaDvorana";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dvorana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNazivDvorane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button actionPotvrdiNaziv;
        private System.Windows.Forms.Button actionOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}