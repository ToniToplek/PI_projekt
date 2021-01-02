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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UnesiBlagajne();
        }

        private void UnesiBlagajne()
        {
            using (var db = new ArenaDB())
            {
                var upit = from b in db.Blagajna
                           select b.naziv_blagajne;
                selectBlagajna.DataSource = upit.ToList();
            }
        }

        private void actionBlagajna_Click(object sender, EventArgs e)
        {
            string korime, lozinka;

            korime = inputKorime.Text;
            lozinka = inputLozinka.Text;

            using (var db = new ArenaDB())
            {
                int brojac = 0, idUloga=0, idRadi=0;
                var s = db.Korisnik;
                var upit = from b in db.Blagajna
                           where b.naziv_blagajne == selectBlagajna.Text
                           select b.blagajna_id;

                int id = upit.Single();
                DateTime dateTime = DateTime.Now;

                foreach (var item in s)
                { 
                    if (item.korisnicko_ime == korime && item.lozinka == lozinka)
                    {
                        var linq = (from d in db.Radi_na
                                    select d.radi_na_id).Max();
                        idRadi = linq;
                        inputKorime.Text = "";
                        inputLozinka.Text = "";
                        brojac++;
                        idUloga = item.uloga_uloga_id;
                        Radi_na radi_Na = new Radi_na()
                        {
                            korisnik_korisnik_id = item.korisnik_id,
                            blagajna_blagajna_id = id,
                            pocetak_smjene = dateTime,
                            kraj_smjene = dateTime
                        };
                        db.Radi_na.Add(radi_Na);
                        idRadi++;
                    }
                }
                db.SaveChanges();
                if (brojac == 0)
                {
                    MessageBox.Show("Neispravno korisničko ime ili lozinka!");
                }
                else
                {
                    
                    BlagajnaDogadaj forma = new BlagajnaDogadaj(idUloga, idRadi);
                    forma.ShowDialog();
                    UnesiBlagajne();
                }
                
            }
          
        }

    }
}
