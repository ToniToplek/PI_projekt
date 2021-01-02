namespace ArenaTicketShop
{
    partial class BrziUnosSjedala
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actionUnesi = new System.Windows.Forms.Button();
            this.actionOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.inputRed = new System.Windows.Forms.NumericUpDown();
            this.inputBroj = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite broj redova:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite broj sjedala po redu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(107, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Brzi unos";
            // 
            // actionUnesi
            // 
            this.actionUnesi.Location = new System.Drawing.Point(112, 128);
            this.actionUnesi.Name = "actionUnesi";
            this.actionUnesi.Size = new System.Drawing.Size(90, 25);
            this.actionUnesi.TabIndex = 5;
            this.actionUnesi.Text = "Unesi";
            this.actionUnesi.UseVisualStyleBackColor = true;
            this.actionUnesi.Click += new System.EventHandler(this.actionUnesi_Click);
            // 
            // actionOdustani
            // 
            this.actionOdustani.Location = new System.Drawing.Point(218, 128);
            this.actionOdustani.Name = "actionOdustani";
            this.actionOdustani.Size = new System.Drawing.Size(90, 25);
            this.actionOdustani.TabIndex = 6;
            this.actionOdustani.Text = "Odustani";
            this.actionOdustani.UseVisualStyleBackColor = true;
            this.actionOdustani.Click += new System.EventHandler(this.actionOdustani_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://github.com/foivz/r19046/wiki/3.-Korisni%C4%8Dka-dokumentacija";
            // 
            // inputRed
            // 
            this.inputRed.Location = new System.Drawing.Point(208, 58);
            this.inputRed.Name = "inputRed";
            this.inputRed.Size = new System.Drawing.Size(66, 22);
            this.inputRed.TabIndex = 7;
            // 
            // inputBroj
            // 
            this.inputBroj.Location = new System.Drawing.Point(208, 92);
            this.inputBroj.Name = "inputBroj";
            this.inputBroj.Size = new System.Drawing.Size(66, 22);
            this.inputBroj.TabIndex = 8;
            // 
            // BrziUnosSjedala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 172);
            this.Controls.Add(this.inputBroj);
            this.Controls.Add(this.inputRed);
            this.Controls.Add(this.actionOdustani);
            this.Controls.Add(this.actionUnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BrziUnosSjedala";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brzi Unos Sjedala";
            ((System.ComponentModel.ISupportInitialize)(this.inputRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button actionUnesi;
        private System.Windows.Forms.Button actionOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.NumericUpDown inputRed;
        private System.Windows.Forms.NumericUpDown inputBroj;
    }
}