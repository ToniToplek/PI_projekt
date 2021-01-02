namespace ArenaTicketShop
{
    partial class Login
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
            this.actionBlagajna = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputKorime = new System.Windows.Forms.TextBox();
            this.inputLozinka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectBlagajna = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // actionBlagajna
            // 
            this.actionBlagajna.BackColor = System.Drawing.Color.CadetBlue;
            this.actionBlagajna.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.actionBlagajna.FlatAppearance.BorderSize = 10;
            this.actionBlagajna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.actionBlagajna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.actionBlagajna.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionBlagajna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actionBlagajna.Location = new System.Drawing.Point(76, 233);
            this.actionBlagajna.Name = "actionBlagajna";
            this.actionBlagajna.Size = new System.Drawing.Size(125, 30);
            this.actionBlagajna.TabIndex = 0;
            this.actionBlagajna.Text = "Prijavi se";
            this.actionBlagajna.UseVisualStyleBackColor = false;
            this.actionBlagajna.Click += new System.EventHandler(this.actionBlagajna_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://github.com/foivz/r19046/wiki/3.-Korisni%C4%8Dka-dokumentacija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(100, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka";
            // 
            // inputKorime
            // 
            this.inputKorime.Location = new System.Drawing.Point(76, 55);
            this.inputKorime.Name = "inputKorime";
            this.inputKorime.Size = new System.Drawing.Size(125, 22);
            this.inputKorime.TabIndex = 3;
            // 
            // inputLozinka
            // 
            this.inputLozinka.Location = new System.Drawing.Point(76, 114);
            this.inputLozinka.Name = "inputLozinka";
            this.inputLozinka.Size = new System.Drawing.Size(125, 22);
            this.inputLozinka.TabIndex = 4;
            this.inputLozinka.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(100, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blagajna";
            // 
            // selectBlagajna
            // 
            this.selectBlagajna.FormattingEnabled = true;
            this.selectBlagajna.Location = new System.Drawing.Point(76, 174);
            this.selectBlagajna.Name = "selectBlagajna";
            this.selectBlagajna.Size = new System.Drawing.Size(125, 24);
            this.selectBlagajna.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 306);
            this.Controls.Add(this.selectBlagajna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputLozinka);
            this.Controls.Add(this.inputKorime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionBlagajna);
            this.Name = "Login";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button actionBlagajna;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputKorime;
        private System.Windows.Forms.TextBox inputLozinka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectBlagajna;
    }
}

