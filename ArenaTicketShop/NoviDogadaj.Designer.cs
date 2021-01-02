namespace ArenaTicketShop
{
    partial class NoviDogadaj
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
            this.inputVrijeme = new System.Windows.Forms.DateTimePicker();
            this.actionOdustani = new System.Windows.Forms.Button();
            this.actionUredu = new System.Windows.Forms.Button();
            this.outputDvorana = new System.Windows.Forms.ComboBox();
            this.inputNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputCijena = new System.Windows.Forms.NumericUpDown();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.inputCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // inputVrijeme
            // 
            this.inputVrijeme.Location = new System.Drawing.Point(155, 95);
            this.inputVrijeme.Name = "inputVrijeme";
            this.inputVrijeme.Size = new System.Drawing.Size(200, 22);
            this.inputVrijeme.TabIndex = 22;
            // 
            // actionOdustani
            // 
            this.actionOdustani.Location = new System.Drawing.Point(266, 198);
            this.actionOdustani.Name = "actionOdustani";
            this.actionOdustani.Size = new System.Drawing.Size(90, 25);
            this.actionOdustani.TabIndex = 21;
            this.actionOdustani.Text = "Odustani";
            this.actionOdustani.UseVisualStyleBackColor = true;
            this.actionOdustani.Click += new System.EventHandler(this.actionOdustani_Click);
            // 
            // actionUredu
            // 
            this.actionUredu.Location = new System.Drawing.Point(170, 198);
            this.actionUredu.Name = "actionUredu";
            this.actionUredu.Size = new System.Drawing.Size(90, 25);
            this.actionUredu.TabIndex = 20;
            this.actionUredu.Text = "U redu";
            this.actionUredu.UseVisualStyleBackColor = true;
            this.actionUredu.Click += new System.EventHandler(this.actionUredu_Click);
            // 
            // outputDvorana
            // 
            this.outputDvorana.FormattingEnabled = true;
            this.outputDvorana.Location = new System.Drawing.Point(155, 158);
            this.outputDvorana.Name = "outputDvorana";
            this.outputDvorana.Size = new System.Drawing.Size(200, 24);
            this.outputDvorana.TabIndex = 19;
            // 
            // inputNaziv
            // 
            this.inputNaziv.Location = new System.Drawing.Point(155, 66);
            this.inputNaziv.Name = "inputNaziv";
            this.inputNaziv.Size = new System.Drawing.Size(200, 22);
            this.inputNaziv.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cijena ulaznice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dvorana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vrijeme događaja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Naziv događaja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(116, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Novi Događaj";
            // 
            // inputCijena
            // 
            this.inputCijena.Location = new System.Drawing.Point(155, 129);
            this.inputCijena.Name = "inputCijena";
            this.inputCijena.Size = new System.Drawing.Size(201, 22);
            this.inputCijena.TabIndex = 23;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://github.com/foivz/r19046/wiki/3.-Korisni%C4%8Dka-dokumentacija";
            // 
            // NoviDogadaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 246);
            this.Controls.Add(this.inputCijena);
            this.Controls.Add(this.inputVrijeme);
            this.Controls.Add(this.actionOdustani);
            this.Controls.Add(this.actionUredu);
            this.Controls.Add(this.outputDvorana);
            this.Controls.Add(this.inputNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NoviDogadaj";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi događaj";
            this.Load += new System.EventHandler(this.NoviDogadaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker inputVrijeme;
        private System.Windows.Forms.Button actionOdustani;
        private System.Windows.Forms.Button actionUredu;
        private System.Windows.Forms.ComboBox outputDvorana;
        private System.Windows.Forms.TextBox inputNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputCijena;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}