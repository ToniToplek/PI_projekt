namespace ArenaTicketShop
{
    partial class FrmOdabirDogadaja
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
            this.dgvDvorana = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvorana)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi dvoranu";
            // 
            // dgvDvorana
            // 
            this.dgvDvorana.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDvorana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDvorana.Location = new System.Drawing.Point(62, 60);
            this.dgvDvorana.Name = "dgvDvorana";
            this.dgvDvorana.RowTemplate.Height = 24;
            this.dgvDvorana.Size = new System.Drawing.Size(458, 151);
            this.dgvDvorana.TabIndex = 1;
            // 
            // FrmOdabirDogadaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 534);
            this.Controls.Add(this.dgvDvorana);
            this.Controls.Add(this.label1);
            this.Name = "FrmOdabirDogadaja";
            this.Text = "OdabirDogadaja";
            this.Load += new System.EventHandler(this.OdabirDogadaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvorana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDvorana;
    }
}