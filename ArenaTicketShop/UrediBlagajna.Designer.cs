namespace ArenaTicketShop
{
    partial class UrediBlagajna
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
            this.outputBlagajne = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.actionUredi = new System.Windows.Forms.Button();
            this.actionNovi = new System.Windows.Forms.Button();
            this.actionOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputBlagajne)).BeginInit();
            this.SuspendLayout();
            // 
            // outputBlagajne
            // 
            this.outputBlagajne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputBlagajne.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputBlagajne.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.outputBlagajne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputBlagajne.Location = new System.Drawing.Point(47, 62);
            this.outputBlagajne.Name = "outputBlagajne";
            this.outputBlagajne.RowHeadersVisible = false;
            this.outputBlagajne.RowTemplate.Height = 24;
            this.outputBlagajne.Size = new System.Drawing.Size(444, 293);
            this.outputBlagajne.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Blagajne";
            // 
            // actionUredi
            // 
            this.actionUredi.Location = new System.Drawing.Point(47, 380);
            this.actionUredi.Name = "actionUredi";
            this.actionUredi.Size = new System.Drawing.Size(100, 35);
            this.actionUredi.TabIndex = 25;
            this.actionUredi.Text = "Uredi";
            this.actionUredi.UseVisualStyleBackColor = true;
            this.actionUredi.Click += new System.EventHandler(this.actionUredi_Click);
            // 
            // actionNovi
            // 
            this.actionNovi.Location = new System.Drawing.Point(169, 380);
            this.actionNovi.Name = "actionNovi";
            this.actionNovi.Size = new System.Drawing.Size(100, 35);
            this.actionNovi.TabIndex = 26;
            this.actionNovi.Text = "Novi";
            this.actionNovi.UseVisualStyleBackColor = true;
            this.actionNovi.Click += new System.EventHandler(this.actionNovi_Click);
            // 
            // actionOdustani
            // 
            this.actionOdustani.Location = new System.Drawing.Point(391, 380);
            this.actionOdustani.Name = "actionOdustani";
            this.actionOdustani.Size = new System.Drawing.Size(100, 35);
            this.actionOdustani.TabIndex = 27;
            this.actionOdustani.Text = "Odustani";
            this.actionOdustani.UseVisualStyleBackColor = true;
            this.actionOdustani.Click += new System.EventHandler(this.actionOdustani_Click);
            // 
            // UrediBlagajna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.actionOdustani);
            this.Controls.Add(this.actionNovi);
            this.Controls.Add(this.actionUredi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBlagajne);
            this.Name = "UrediBlagajna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi Blagajne";
            this.Load += new System.EventHandler(this.UrediBlagajna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputBlagajne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView outputBlagajne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actionUredi;
        private System.Windows.Forms.Button actionNovi;
        private System.Windows.Forms.Button actionOdustani;
    }
}