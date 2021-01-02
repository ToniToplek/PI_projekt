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
    public partial class NovaDvorana : Form
    {
        public NovaDvorana()
        {
            InitializeComponent();
        }

        private void actionPotvrdiNaziv_Click(object sender, EventArgs e)
        {
            using (var db = new ArenaDB())
            {
                Dvorana dvorana = new Dvorana
                {
                    naziv_dvorane = inputNazivDvorane.Text
                };
                db.Dvorana.Add(dvorana);
                db.SaveChanges();
            }
            Close();
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
