namespace ArenaTicketShop
{
    partial class BlagajnaSjedalo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.outputDogadaj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputCijena = new System.Windows.Forms.Label();
            this.outputSektor = new System.Windows.Forms.DataGridView();
            this.outputSjedala = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.actionOdustani = new System.Windows.Forms.Button();
            this.actionRacun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputOdabranaSjedala = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.outputUkupnaCijena = new System.Windows.Forms.Label();
            this.actionOdaberi = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.outputSektor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputSjedala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputOdabranaSjedala)).BeginInit();
            this.SuspendLayout();
            // 
            // outputDogadaj
            // 
            this.outputDogadaj.AutoSize = true;
            this.outputDogadaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputDogadaj.Location = new System.Drawing.Point(21, 23);
            this.outputDogadaj.Name = "outputDogadaj";
            this.outputDogadaj.Size = new System.Drawing.Size(111, 29);
            this.outputDogadaj.TabIndex = 0;
            this.outputDogadaj.Text = "Događaj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sektor";
            // 
            // outputCijena
            // 
            this.outputCijena.AutoSize = true;
            this.outputCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputCijena.Location = new System.Drawing.Point(22, 52);
            this.outputCijena.Name = "outputCijena";
            this.outputCijena.Size = new System.Drawing.Size(63, 24);
            this.outputCijena.TabIndex = 4;
            this.outputCijena.Text = "Cijena";
            // 
            // outputSektor
            // 
            this.outputSektor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputSektor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputSektor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outputSektor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.outputSektor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputSektor.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.outputSektor.Location = new System.Drawing.Point(26, 114);
            this.outputSektor.Name = "outputSektor";
            this.outputSektor.RowHeadersVisible = false;
            this.outputSektor.RowTemplate.Height = 24;
            this.outputSektor.Size = new System.Drawing.Size(231, 305);
            this.outputSektor.TabIndex = 5;
            this.outputSektor.SelectionChanged += new System.EventHandler(this.outputSektor_SelectionChanged);
            // 
            // outputSjedala
            // 
            this.outputSjedala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputSjedala.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputSjedala.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputSjedala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputSjedala.Location = new System.Drawing.Point(303, 114);
            this.outputSjedala.Name = "outputSjedala";
            this.outputSjedala.RowHeadersVisible = false;
            this.outputSjedala.RowTemplate.Height = 24;
            this.outputSjedala.Size = new System.Drawing.Size(305, 305);
            this.outputSjedala.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(300, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sjedalo";
            // 
            // actionOdustani
            // 
            this.actionOdustani.Location = new System.Drawing.Point(867, 442);
            this.actionOdustani.Name = "actionOdustani";
            this.actionOdustani.Size = new System.Drawing.Size(90, 25);
            this.actionOdustani.TabIndex = 8;
            this.actionOdustani.Text = "Odustani";
            this.actionOdustani.UseVisualStyleBackColor = true;
            this.actionOdustani.Click += new System.EventHandler(this.actionOdustani_Click);
            // 
            // actionRacun
            // 
            this.actionRacun.Location = new System.Drawing.Point(771, 442);
            this.actionRacun.Name = "actionRacun";
            this.actionRacun.Size = new System.Drawing.Size(90, 25);
            this.actionRacun.TabIndex = 9;
            this.actionRacun.Text = "Račun";
            this.actionRacun.UseVisualStyleBackColor = true;
            this.actionRacun.Click += new System.EventHandler(this.actionRacun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(649, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Odabrana sjedala";
            // 
            // outputOdabranaSjedala
            // 
            this.outputOdabranaSjedala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputOdabranaSjedala.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputOdabranaSjedala.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputOdabranaSjedala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputOdabranaSjedala.Location = new System.Drawing.Point(652, 114);
            this.outputOdabranaSjedala.Name = "outputOdabranaSjedala";
            this.outputOdabranaSjedala.RowHeadersVisible = false;
            this.outputOdabranaSjedala.RowTemplate.Height = 24;
            this.outputOdabranaSjedala.Size = new System.Drawing.Size(305, 282);
            this.outputOdabranaSjedala.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(758, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ukupna cijena:";
            // 
            // outputUkupnaCijena
            // 
            this.outputUkupnaCijena.AutoSize = true;
            this.outputUkupnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputUkupnaCijena.Location = new System.Drawing.Point(909, 399);
            this.outputUkupnaCijena.Name = "outputUkupnaCijena";
            this.outputUkupnaCijena.Size = new System.Drawing.Size(19, 20);
            this.outputUkupnaCijena.TabIndex = 13;
            this.outputUkupnaCijena.Text = "0";
            // 
            // actionOdaberi
            // 
            this.actionOdaberi.Location = new System.Drawing.Point(518, 442);
            this.actionOdaberi.Name = "actionOdaberi";
            this.actionOdaberi.Size = new System.Drawing.Size(90, 25);
            this.actionOdaberi.TabIndex = 14;
            this.actionOdaberi.Text = "Odaberi";
            this.actionOdaberi.UseVisualStyleBackColor = true;
            this.actionOdaberi.Click += new System.EventHandler(this.actionOdaberi_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://github.com/foivz/r19046/wiki/3.-Korisni%C4%8Dka-dokumentacija";
            // 
            // BlagajnaSjedalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 485);
            this.Controls.Add(this.actionOdaberi);
            this.Controls.Add(this.outputUkupnaCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputOdabranaSjedala);
            this.Controls.Add(this.actionRacun);
            this.Controls.Add(this.actionOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputSjedala);
            this.Controls.Add(this.outputSektor);
            this.Controls.Add(this.outputCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputDogadaj);
            this.Name = "BlagajnaSjedalo";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir sjedala";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlagajnaSjedalo_FormClosing);
            this.Load += new System.EventHandler(this.BlagajnaSjedalo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputSektor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputSjedala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputOdabranaSjedala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputDogadaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputCijena;
        private System.Windows.Forms.DataGridView outputSektor;
        private System.Windows.Forms.DataGridView outputSjedala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button actionOdustani;
        private System.Windows.Forms.Button actionRacun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView outputOdabranaSjedala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputUkupnaCijena;
        private System.Windows.Forms.Button actionOdaberi;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}