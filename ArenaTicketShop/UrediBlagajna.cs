using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaTicketShop
{
    public partial class UrediBlagajna : Form
    {
        public UrediBlagajna()
        {
            InitializeComponent();
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UrediBlagajna_Load(object sender, EventArgs e)
        {
            PrikaziBlagajne();
        }

        private void PrikaziBlagajne()
        {
            List<Blagajna> blagajnas;
            using (var db = new ArenaDB())
            {
                blagajnas = db.Blagajna.ToList();
            }
            outputBlagajne.DataSource = blagajnas;
            outputBlagajne.Columns[0].HeaderText = "ID";
            outputBlagajne.Columns[1].HeaderText = "Ime";
            outputBlagajne.Columns[2].Visible = false;
            outputBlagajne.Columns[3].Visible = false;

        }

        private void actionNovi_Click(object sender, EventArgs e)
        {
            NovaBlagajna user = new NovaBlagajna();
            user.ShowDialog();
            PrikaziBlagajne();
        }

        private void actionUredi_Click(object sender, EventArgs e)
        {
            if (outputBlagajne.CurrentRow != null)
            {
                NovaBlagajna forma = new NovaBlagajna(outputBlagajne.CurrentRow.DataBoundItem as Blagajna);
                forma.ShowDialog();
                PrikaziBlagajne();
            }
            else
            {
                MessageBox.Show("Niste odabrali blagajnu!");
            }
        }
    }
}
