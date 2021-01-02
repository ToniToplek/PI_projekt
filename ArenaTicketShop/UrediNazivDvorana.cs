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
    public partial class UrediNazivDvorana : Form
    {
        private Dvorana odabranaDvorana;
        public UrediNazivDvorana(Dvorana dvorana)
        {
            InitializeComponent();
            odabranaDvorana = dvorana;
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UrediNazivDvorana_Load(object sender, EventArgs e)
        {
            inputNazivDvorane.Text = odabranaDvorana.naziv_dvorane;
        }

        private void actionPotvrdiNaziv_Click(object sender, EventArgs e)
        {
            using (var db = new ArenaDB())
            {

                db.Dvorana.Attach(odabranaDvorana);
                odabranaDvorana.naziv_dvorane = inputNazivDvorane.Text;
                db.SaveChanges();
            }
            Close();
        }
    }
}
