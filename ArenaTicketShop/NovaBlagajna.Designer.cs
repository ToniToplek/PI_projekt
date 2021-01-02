namespace ArenaTicketShop
{
    partial class NovaBlagajna
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
            this.inputBlagajnaId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.actionPotvrdi = new System.Windows.Forms.Button();
            this.actionOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNaziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputBlagajnaId
            // 
            this.inputBlagajnaId.Location = new System.Drawing.Point(148, 71);
            this.inputBlagajnaId.Name = "inputBlagajnaId";
            this.inputBlagajnaId.ReadOnly = true;
            this.inputBlagajnaId.Size = new System.Drawing.Size(165, 22);
            this.inputBlagajnaId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(114, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Korisnik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Blagajna ID:";
            // 
            // actionPotvrdi
            // 
            this.actionPotvrdi.Location = new System.Drawing.Point(45, 148);
            this.actionPotvrdi.Name = "actionPotvrdi";
            this.actionPotvrdi.Size = new System.Drawing.Size(100, 35);
            this.actionPotvrdi.TabIndex = 25;
            this.actionPotvrdi.Text = "Potvrdi";
            this.actionPotvrdi.UseVisualStyleBackColor = true;
            this.actionPotvrdi.Click += new System.EventHandler(this.actionPotvrdi_Click);
            // 
            // actionOdustani
            // 
            this.actionOdustani.Location = new System.Drawing.Point(189, 148);
            this.actionOdustani.Name = "actionOdustani";
            this.actionOdustani.Size = new System.Drawing.Size(100, 35);
            this.actionOdustani.TabIndex = 24;
            this.actionOdustani.Text = "Odustani";
            this.actionOdustani.UseVisualStyleBackColor = true;
            this.actionOdustani.Click += new System.EventHandler(this.actionOdustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Naziv Blagajne:";
            // 
            // inputNaziv
            // 
            this.inputNaziv.Location = new System.Drawing.Point(148, 101);
            this.inputNaziv.Name = "inputNaziv";
            this.inputNaziv.Size = new System.Drawing.Size(165, 22);
            this.inputNaziv.TabIndex = 27;
            // 
            // NovaBlagajna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 210);
            this.Controls.Add(this.inputNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actionPotvrdi);
            this.Controls.Add(this.actionOdustani);
            this.Controls.Add(this.inputBlagajnaId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NovaBlagajna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiraj/Uredi Blagajnu";
            this.Load += new System.EventHandler(this.NovaBlagajna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBlagajnaId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actionPotvrdi;
        private System.Windows.Forms.Button actionOdustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNaziv;
    }
}