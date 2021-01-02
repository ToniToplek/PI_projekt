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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private Korisnik odabraniKorisnik;
        public User(Korisnik user)
        {
            InitializeComponent();
            odabraniKorisnik = user;
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actionPotvrdi_Click(object sender, EventArgs e)
        {
            using (var db = new ArenaDB())
            {

                var upit = from u in db.Uloga
                           where u.naziv_uloge == selectUloga.Text
                           select u.uloga_id;
                int id_uloga = Convert.ToInt32(upit.Single());
                if(odabraniKorisnik == null)
                {
                    if (inputLozinka.Text == inputLozinka2.Text)
                    {
                        Korisnik korisnik = new Korisnik
                        {
                            uloga_uloga_id = id_uloga,
                            ime = inputIme.Text,
                            prezime = inputPrezime.Text,
                            korisnicko_ime = inputKorime.Text,
                            lozinka = inputLozinka.Text,
                            email = inputEMail.Text
                        };
                        db.Korisnik.Add(korisnik);
                        db.SaveChanges();                       
                    }
                    else
                    {
                        MessageBox.Show("Lozinke se ne poklapaju!");
                    }
                }
                else
                {
                    if (inputLozinka.Text == inputLozinka2.Text)
                    {
                        db.Korisnik.Attach(odabraniKorisnik);
                        odabraniKorisnik.ime = inputIme.Text;
                        odabraniKorisnik.prezime = inputPrezime.Text;
                        odabraniKorisnik.lozinka = inputLozinka.Text;
                        odabraniKorisnik.uloga_uloga_id = id_uloga;
                        odabraniKorisnik.korisnicko_ime = inputKorime.Text;
                        odabraniKorisnik.email = inputEMail.Text;
                        db.SaveChanges();                        
                    }
                    else
                    {
                        MessageBox.Show("Lozinke se ne poklapaju!");
                    }
                }
            }
            Close();
        }


        private int SljedeciId;
        private void User_Load(object sender, EventArgs e)
        {
            using (var db = new ArenaDB())
            {
                var upit = from b in db.Uloga
                           select b.naziv_uloge;
                selectUloga.DataSource = upit.ToList();

                var upit2 = (from k in db.Korisnik
                             select k.korisnik_id).Max();
                SljedeciId = upit2+1;
            }

            if(odabraniKorisnik != null)
            {
                inputKorisnikId.Text = odabraniKorisnik.korisnik_id.ToString();
                inputIme.Text = odabraniKorisnik.ime.ToString();
                inputPrezime.Text = odabraniKorisnik.prezime.ToString();
                inputLozinka.Text = odabraniKorisnik.lozinka.ToString();
                inputLozinka2.Text = odabraniKorisnik.lozinka.ToString();
                selectUloga.SelectedIndex = odabraniKorisnik.uloga_uloga_id-1;
                inputKorime.Text = odabraniKorisnik.korisnicko_ime.ToString();
                inputEMail.Text = odabraniKorisnik.email.ToString();
            }
            else
            {
                inputKorisnikId.Text = SljedeciId.ToString();
            }

        }




    }
}
