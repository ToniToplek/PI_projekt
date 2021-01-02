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
    public partial class BlagajnaDogadaj : Form
    {
        private int idUloga;
        private int idRadi;
        public BlagajnaDogadaj(int uloga, int id)
        {
            InitializeComponent();
            idUloga = uloga;
            idRadi = id;
        }

        private void BlagajnaDogadaj_Load(object sender, EventArgs e)
        {
            PrikaziDvorane();
            if (idUloga > 2)
            {
                actionDvorana.Visible = false;
                actionNoviDogadaj.Visible = false;
                actionProsli.Visible = false;
                actionUrediDogadaj.Visible = false;
                actionBlagajne.Visible = false;
                actionKorisnik.Visible = false;

            }else if(idUloga == 2)
            {
                actionDvorana.Visible = false;
                actionBlagajne.Visible = false;
                actionKorisnik.Visible = false;
            }
        }

        private void PrikaziDvorane()
        {
            List<Dvorana> dvoranas;
            using (var db = new ArenaDB())
            {
                dvoranas = db.Dvorana.ToList();
            }
            outputDvorana.DataSource = dvoranas;
            outputDvorana.Columns[0].Visible = false;
            outputDvorana.Columns[2].Visible = false;
            outputDvorana.Columns[3].Visible = false;
            outputDvorana.Columns[1].HeaderText = "Naziv dvorane";
        }

        private void PrikaziDogadaje(Dvorana dvorana)
        {

            using (var db = new ArenaDB())
            {
                DateTime trenutnoVrijeme = DateTime.Now.AddHours(-1);
                var upit = from d in db.Dogadaj
                           where d.vrijeme_dogadaja >= trenutnoVrijeme && dvorana.dvorana_id == d.dvorana_dvorana_id
                           select d;

                outputDogadaj.DataSource = upit.ToList();
                outputDogadaj.Columns[0].Visible = false;
                outputDogadaj.Columns[3].Visible = false;
                outputDogadaj.Columns[5].Visible = false;
                outputDogadaj.Columns[6].Visible = false;
                outputDogadaj.Columns[1].HeaderText = "Naziv događaja";
                outputDogadaj.Columns[2].HeaderText = "Vrijeme događaja";
                outputDogadaj.Columns[4].HeaderText = "Cijena";
            }
        }



        private void actionOdabir_Click(object sender, EventArgs e)
        {
            if (outputDogadaj.CurrentRow != null)
            {
                BlagajnaSjedalo forma = new BlagajnaSjedalo(outputDogadaj.CurrentRow.DataBoundItem as Dogadaj);
                forma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niste odabrali događaj!");
            }
        }

        private void actionDvorana_Click(object sender, EventArgs e)
        {
            UrediDvorana forma = new UrediDvorana();
            forma.ShowDialog();
            PrikaziDvorane();
        }

        private void actionUrediDogadaj_Click(object sender, EventArgs e)
        {
            if (outputDogadaj.CurrentRow != null) {
                UrediDogadaj forma = new UrediDogadaj(outputDogadaj.CurrentRow.DataBoundItem as Dogadaj);
                forma.ShowDialog();
                PrikaziDvorane();
            }
            else
            {
                MessageBox.Show("Niste odabrali događaj!");
            }
        }

        private void actionNoviDogadaj_Click(object sender, EventArgs e)
        {
            if (outputDogadaj.CurrentRow != null)
            {
                NoviDogadaj forma = new NoviDogadaj(outputDogadaj.CurrentRow.DataBoundItem as Dogadaj);
                forma.ShowDialog();
                PrikaziDvorane();
            }
            else
            {

                NoviDogadaj forma = new NoviDogadaj();
                forma.ShowDialog();
                PrikaziDvorane();
            }
        }

        private void actionProsli_Click(object sender, EventArgs e)
        {
            ProsliDogadaji forma = new ProsliDogadaji();
            forma.ShowDialog();
            PrikaziDvorane();
        }

        private void outputDvorana_SelectionChanged(object sender, EventArgs e)
        {
            Dvorana odabranaDvorana = outputDvorana.CurrentRow.DataBoundItem as Dvorana;
            if (odabranaDvorana != null)
            {
                PrikaziDogadaje(odabranaDvorana);
            }
        }

        private void actionOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BlagajnaDogadaj_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime kraj = DateTime.Now;
            using (var db = new ArenaDB())
            {
                var upit = from r in db.Radi_na
                           where r.radi_na_id == idRadi
                           select r;

                Radi_na radi_Na = upit.Single() as Radi_na;

                db.Radi_na.Attach(radi_Na);
                radi_Na.kraj_smjene = kraj;
                db.SaveChanges();
            }           
        }

        private void actionKorisnik_Click(object sender, EventArgs e)
        {
            UrediKorisnik urediKorisnik = new UrediKorisnik();
            urediKorisnik.ShowDialog();
        }

        private void actionBlagajne_Click(object sender, EventArgs e)
        {
            UrediBlagajna forma = new UrediBlagajna();
            forma.ShowDialog();
        }

    }
}
