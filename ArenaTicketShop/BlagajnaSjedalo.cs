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
    public partial class BlagajnaSjedalo : Form
    {
        List<Sjedalo> sjedalos = new List<Sjedalo>();
        List<Sjedalo_rez> sjedalo_Rezs = new List<Sjedalo_rez>();
        private Dogadaj odabraniDogadaj;
        public BlagajnaSjedalo(Dogadaj dogadaj)
        {
            InitializeComponent();
            odabraniDogadaj = dogadaj;
        }

        private void BlagajnaSjedalo_Load(object sender, EventArgs e)
        {
            outputDogadaj.Text = odabraniDogadaj.naziv_dogadaja;
            outputCijena.Text = odabraniDogadaj.cijena + "kn";
            PrikaziSektore();
        }


        private void PrikaziSektore()
        {
            using (var db = new ArenaDB())
            {
                var upit = from d in db.Sektor
                           where d.dvorana_dvorana_id == odabraniDogadaj.dvorana_dvorana_id
                           select d;
                outputSektor.DataSource = upit.ToList();
                outputSektor.Columns[2].Visible = false;
                outputSektor.Columns[0].Visible = false;
                outputSektor.Columns[3].Visible = false;
                outputSektor.Columns[4].Visible = false;
                outputSektor.Columns[1].HeaderText = "Naziv sektora";
            }
        }

        private void PrikaziSjedala(Sektor sektor)
        {
            using (var db = new ArenaDB())
            {
                if (sektor != null)
                {
                    var prviUpit = (from u in db.Sjedalo_rez
                                   where odabraniDogadaj.dogadaj_id == u.dogadaj_dogadaj_id
                                   select u).Count();

                    if (prviUpit != 0) {
                        var upit = from s in db.Sjedalo
                                   from p in db.Sjedalo_rez
                                   where s.sjedalo_id == p.sjedalo_sjedalo_id && sektor.sektor_id == s.sektor_sektor_id && odabraniDogadaj.dogadaj_id == p.dogadaj_dogadaj_id
                                   select s;

                        var svi = from s in db.Sjedalo
                                  where sektor.sektor_id == s.sektor_sektor_id
                                  select s;

                        var rezultat = svi.ToList().Except(upit.ToList()).ToList();

                        outputSjedala.DataSource = rezultat.ToList();
                        outputSjedala.Columns[0].Visible = false;
                        outputSjedala.Columns[3].Visible = false;
                        outputSjedala.Columns[4].Visible = false;
                        outputSjedala.Columns[5].Visible = false;
                        outputSjedala.Columns[1].HeaderText = "Red";
                        outputSjedala.Columns[2].HeaderText = "Broj";
                    }
                    else
                    {
                        var svi = from s in db.Sjedalo
                                  where sektor.sektor_id == s.sektor_sektor_id
                                  select s;
                        outputSjedala.DataSource = svi.ToList();
                        outputSjedala.Columns[0].Visible = false;
                        outputSjedala.Columns[3].Visible = false;
                        outputSjedala.Columns[4].Visible = false;
                        outputSjedala.Columns[5].Visible = false;
                        outputSjedala.Columns[1].HeaderText = "Red";
                        outputSjedala.Columns[2].HeaderText = "Broj";
                    }
                }
            }
        }

        private void outputSektor_SelectionChanged(object sender, EventArgs e)
        {
            Sektor odabraniSektor = outputSektor.CurrentRow.DataBoundItem as Sektor;
            if(odabraniSektor != null)
            {
                PrikaziSjedala(odabraniSektor);
            }
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            foreach (var item in sjedalo_Rezs)
            {
                using (var db = new ArenaDB())
                {
                    db.Sjedalo_rez.Attach(item);
                    db.Sjedalo_rez.Remove(item);
                    db.SaveChanges();
                }
            }
            sjedalo_Rezs = null;
            Close();
        }

        private void actionOdaberi_Click(object sender, EventArgs e)
        {
            Sjedalo odabranoSjedalo = outputSjedala.CurrentRow.DataBoundItem as Sjedalo;            

            using (var db = new ArenaDB())
            {
                var odabrano = from s in db.Sjedalo
                               where s.sjedalo_id == odabranoSjedalo.sjedalo_id
                               select s;

                var odabranoId = (from s in db.Sjedalo
                               where s.sjedalo_id == odabranoSjedalo.sjedalo_id
                               select s.sjedalo_id).Single();

                Sjedalo_rez sjedalo = new Sjedalo_rez()
                {
                    dogadaj_dogadaj_id = odabraniDogadaj.dogadaj_id,
                    sjedalo_sjedalo_id = odabranoId,
                    racun_racun_id = 2
                };

                sjedalo_Rezs.Add(sjedalo);

                db.Sjedalo_rez.Add(sjedalo);
                db.SaveChanges();

                sjedalos.Add(odabrano.Single());

                int brojSjedala = sjedalos.Count();
                outputUkupnaCijena.Text = (brojSjedala * odabraniDogadaj.cijena).ToString();
            }
            outputOdabranaSjedala.DataSource = null;
            outputOdabranaSjedala.DataSource = sjedalos;
            outputOdabranaSjedala.Columns[0].Visible = false;
            outputOdabranaSjedala.Columns[3].Visible = false;
            outputOdabranaSjedala.Columns[4].Visible = false;
            outputOdabranaSjedala.Columns[5].Visible = false;
            outputOdabranaSjedala.Columns[1].HeaderText = "Red";
            outputOdabranaSjedala.Columns[2].HeaderText = "Broj";

            PrikaziSjedala(outputSektor.CurrentRow.DataBoundItem as Sektor);
        }

        private void actionRacun_Click(object sender, EventArgs e)
        {

            IspisKarte forma = new IspisKarte();
            forma.ShowDialog();

            sjedalo_Rezs = null;
            Close();
        }

        private void BlagajnaSjedalo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sjedalo_Rezs != null)
            {
                foreach (var item in sjedalo_Rezs)
                {
                    using (var db = new ArenaDB())
                    {
                        db.Sjedalo_rez.Attach(item);
                        db.Sjedalo_rez.Remove(item);
                        db.SaveChanges();
                    }
                }
                sjedalo_Rezs = null;
            }
        }
    }
}
