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
    public partial class UrediDvorana : Form
    {
        public UrediDvorana()
        {
            InitializeComponent();
            PrikaziDvorane();
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

        private void PrikaziSektore(Dvorana dvorana)
        {
            List<Sektor> sektors;
            using (var db = new ArenaDB())
            {
                db.Dvorana.Attach(dvorana);
                sektors = dvorana.Sektor.ToList();
            }
            outputSektor.DataSource = sektors;
            outputSektor.Columns[0].Visible = false;
            outputSektor.Columns[2].Visible = false;
            outputSektor.Columns[3].Visible = false;
            outputSektor.Columns[4].Visible = false;
            outputSektor.Columns[1].HeaderText = "Naziv sektora";
        }

        private void PrikaziSjedala(Sektor sektor)
        {
            List<Sjedalo> sjedalos;
            using (var db = new ArenaDB())
            {
                db.Sektor.Attach(sektor);
                sjedalos = sektor.Sjedalo.ToList();
            }
            outputSjedala.DataSource = sjedalos;
            outputSjedala.Columns[0].Visible = false;
            outputSjedala.Columns[3].Visible = false;
            outputSjedala.Columns[4].Visible = false;
            outputSjedala.Columns[5].Visible = false;
            outputSjedala.Columns[1].HeaderText = "Red";
            outputSjedala.Columns[2].HeaderText = "Broj";
        }


        private void outputDvorana_SelectionChanged(object sender, EventArgs e)
        {
            Dvorana odabranaDvorana = outputDvorana.CurrentRow.DataBoundItem as Dvorana;
            if (odabranaDvorana != null)
            {
                PrikaziSektore(odabranaDvorana);
            }
        }

        private void actionNovaDvorana_Click(object sender, EventArgs e)
        {
            NovaDvorana forma = new NovaDvorana();
            forma.ShowDialog();
            PrikaziDvorane();
        }

        private void actionNoviSektor_Click(object sender, EventArgs e)
        {
            if (outputDvorana.CurrentRow != null)
            {
                Dvorana odabranaDvorana = outputDvorana.CurrentRow.DataBoundItem as Dvorana;

                using (var db = new ArenaDB())
                {
                    Sektor sektor = new Sektor
                    {
                        naziv_sektora = inputSektor.Text,
                        dvorana_dvorana_id = odabranaDvorana.dvorana_id
                    };
                    db.Sektor.Add(sektor);
                    db.SaveChanges();
                }
                PrikaziDvorane();
            }
        }

        private void actionIzmjeniSektor_Click(object sender, EventArgs e)
        {
            if (outputSektor.CurrentRow != null)
            {
                Sektor odabraniSektor = outputSektor.CurrentRow.DataBoundItem as Sektor;
                Dvorana odabranaDvorana = outputDvorana.CurrentRow.DataBoundItem as Dvorana;
                using (var db = new ArenaDB())
                {
                    db.Sektor.Attach(odabraniSektor);
                    odabraniSektor.naziv_sektora = inputSektor.Text;
                    db.SaveChanges();
                }
                PrikaziSektore(odabranaDvorana);
            }
        }

        private void actionObrisi_Click(object sender, EventArgs e)
        {
            if (outputSektor.CurrentRow != null)
            {
                Sektor odabraniSektor = outputSektor.CurrentRow.DataBoundItem as Sektor;
                Dvorana odabranaDvorana = outputDvorana.CurrentRow.DataBoundItem as Dvorana;
                if (odabraniSektor != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new ArenaDB())
                        {
                            db.Sektor.Attach(odabraniSektor);
                            if (odabraniSektor.Sjedalo.Count == 0)
                            {
                                db.Sektor.Remove(odabraniSektor);
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Nije moguće obrisati sektor koji sadrzi stolice!");
                            }
                        }
                        PrikaziSektore(odabranaDvorana);
                    }
                }
            }
        }

        private void outputSektor_SelectionChanged(object sender, EventArgs e)
        {
            if (outputSektor.CurrentRow != null)
            {
                Sektor odabraniSektor = outputSektor.CurrentRow.DataBoundItem as Sektor;
                if (odabraniSektor != null)
                {
                    PrikaziSjedala(odabraniSektor);
                }
            }
        }

        private void actionNovoSjedalo_Click(object sender, EventArgs e)
        {
            if (outputSektor.CurrentRow != null)
            {
                Sektor odabraniSektor = outputSektor.CurrentRow.DataBoundItem as Sektor;
                Dvorana odabranaDvorana = outputDvorana.CurrentRow.DataBoundItem as Dvorana;
                using (var db = new ArenaDB())
                {
                    int red = int.Parse(inputRed.Text);
                    int broj = int.Parse(inputBroj.Text);
                    Sjedalo sjedalo = new Sjedalo
                    {
                        red = red,
                        broj = broj,
                        sektor_sektor_id = odabraniSektor.sektor_id
                    };

                    var upit = (from s in db.Sjedalo
                                where s.broj == broj && s.red == red && odabraniSektor.sektor_id == s.sektor_sektor_id
                                select s).Count();

                    if (upit == 0)
                    {
                        db.Sjedalo.Add(sjedalo);
                        db.SaveChanges();
                        PrikaziDvorane();
                    }
                    else
                    {
                        MessageBox.Show("Vec postoji to sjedalo!");
                    }
                }
            }
        }

        private void actionIzmjeniSjedalo_Click(object sender, EventArgs e)
        {
            if (outputSjedala.CurrentRow != null)
            {
                Sektor odabraniSektor = outputSektor.CurrentRow.DataBoundItem as Sektor;
                Sjedalo odabranoSjedalo = outputSjedala.CurrentRow.DataBoundItem as Sjedalo;
                using (var db = new ArenaDB())
                {
                    db.Sjedalo.Attach(odabranoSjedalo);
                    odabranoSjedalo.red = int.Parse(inputRed.Text);
                    odabranoSjedalo.broj = int.Parse(inputBroj.Text);
                    db.SaveChanges();
                }
                PrikaziSjedala(odabraniSektor);
            }
        }

        private void actionObrisiSjedalo_Click(object sender, EventArgs e)
        {
            if (outputSjedala.CurrentRow != null)
            {
                Sektor odabraniSektor = outputSektor.CurrentRow.DataBoundItem as Sektor;
                Sjedalo odabranoSjedalo = outputSjedala.CurrentRow.DataBoundItem as Sjedalo;
                if (odabranoSjedalo != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new ArenaDB())
                        {
                            db.Sjedalo.Attach(odabranoSjedalo);
                            db.Sjedalo.Remove(odabranoSjedalo);
                            db.SaveChanges();
                        }
                        PrikaziSjedala(odabraniSektor);
                    }
                }
            }
        }

        private void UrediDvorana_Load(object sender, EventArgs e)
        {
            PrikaziDvorane();
        }

        private void actionBrziUnos_Click(object sender, EventArgs e)
        {
            BrziUnosSjedala forma = new BrziUnosSjedala(outputSektor.CurrentRow.DataBoundItem as Sektor);
            forma.ShowDialog();
            PrikaziDvorane();
        }

        private void actionBrisiSve_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite obrisati sva sjedala?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                do
                {
                    if (outputSjedala.CurrentRow != null)
                    {
                        Sektor odabraniSektor = outputSektor.CurrentRow.DataBoundItem as Sektor;
                        Sjedalo odabranoSjedalo = outputSjedala.CurrentRow.DataBoundItem as Sjedalo;
                        if (odabranoSjedalo != null)
                        {

                            using (var db = new ArenaDB())
                            {
                                db.Sjedalo.Attach(odabranoSjedalo);
                                db.Sjedalo.Remove(odabranoSjedalo);
                                db.SaveChanges();
                            }
                            PrikaziSjedala(odabraniSektor);
                        }
                    }
                } while (outputSjedala.CurrentRow != null);
            }
        }

        private void actionObrisiDvoranu_Click(object sender, EventArgs e)
        {
            Dvorana odabranaDvorana = outputDvorana.CurrentRow.DataBoundItem as Dvorana;
            if (odabranaDvorana != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new ArenaDB())
                    {
                        db.Dvorana.Attach(odabranaDvorana);
                        if (odabranaDvorana.Sektor.Count == 0)
                        {
                            db.Dvorana.Remove(odabranaDvorana);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati dvoranu koja sadrži sektore!");
                        }
                    }
                    PrikaziDvorane();
                }
            }

        }

        private void actionUrediDvoranu_Click(object sender, EventArgs e)
        {
            UrediNazivDvorana forma = new UrediNazivDvorana(outputDvorana.CurrentRow.DataBoundItem as Dvorana);
            forma.ShowDialog();
            PrikaziDvorane();
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
