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
    public partial class UrediKorisnik : Form
    {
        public UrediKorisnik()
        {
            InitializeComponent();
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actionNovi_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
            PrikaziKorisnike();
        }

        private void UrediKorisnik_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();
        }

        private void PrikaziKorisnike()
        {
            List<Korisnik> korisnici;
            using (var db = new ArenaDB())
            {
                korisnici = db.Korisnik.ToList();
            }          
            outputKorisnik.DataSource = korisnici;
            outputKorisnik.Columns[1].Visible = false;
            outputKorisnik.Columns[7].Visible = false;
            outputKorisnik.Columns[8].Visible = false;
            outputKorisnik.Columns[0].HeaderText = "Korisnik ID";
            outputKorisnik.Columns[2].HeaderText = "Ime";
            outputKorisnik.Columns[3].HeaderText = "Prezime";
            outputKorisnik.Columns[4].HeaderText = "Korisnicko ime";
            outputKorisnik.Columns[5].HeaderText = "Lozinka";
            outputKorisnik.Columns[6].HeaderText = "E-mail";
        }

        private void actionUredi_Click(object sender, EventArgs e)
        {
            if (outputKorisnik.CurrentRow != null)
            {
                User forma = new User(outputKorisnik.CurrentRow.DataBoundItem as Korisnik);
                forma.ShowDialog();
                PrikaziKorisnike();
            }
            else
            {
                MessageBox.Show("Niste odabrali korisnika!");
            }
        }
    }
}
