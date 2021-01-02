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
    public partial class UrediDogadaj : Form
    {
        private Dogadaj odabraniDogadaj;
        public UrediDogadaj(Dogadaj dogadaj)
        {
            InitializeComponent();
            odabraniDogadaj = dogadaj;
        }

        private void UrediDogadaj_Load(object sender, EventArgs e)
        {
            inputVrijeme.Format = DateTimePickerFormat.Custom;
            inputVrijeme.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            inputNaziv.Text = odabraniDogadaj.naziv_dogadaja;
            inputVrijeme.Text = odabraniDogadaj.vrijeme_dogadaja.ToString();
            inputCijena.Text = odabraniDogadaj.cijena.ToString();

            using (var db = new ArenaDB())
            {
                var upit = from d in db.Dvorana
                           select d.naziv_dvorane;

                outputDvorana.DataSource = upit.ToList();

                var query = from s in db.Dvorana
                            where s.dvorana_id == odabraniDogadaj.dvorana_dvorana_id
                            select s.naziv_dvorane;

                outputDvorana.SelectedItem = query.Single();
            }
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actionUredu_Click(object sender, EventArgs e)
        {
            using (var db = new ArenaDB())
            {
                db.Dogadaj.Attach(odabraniDogadaj);
                odabraniDogadaj.naziv_dogadaja = inputNaziv.Text;
                odabraniDogadaj.cijena = int.Parse(inputCijena.Text);
                odabraniDogadaj.vrijeme_dogadaja = DateTime.Parse(inputVrijeme.Text);

                string odabranaDvorana = outputDvorana.SelectedItem.ToString();

                var upit = from d in db.Dvorana
                           where d.naziv_dvorane == odabranaDvorana
                           select d.dvorana_id;

                var provjera = (from r in db.Sjedalo_rez
                                where r.dogadaj_dogadaj_id == odabraniDogadaj.dogadaj_id
                                select r).Count();

                if (provjera == 0)
                {
                    odabraniDogadaj.dvorana_dvorana_id = upit.Single();
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Postoje već kupljene karte za ovaj događaj!");
                    if (MessageBox.Show("Želite li svejedno napraviti promjene?", "Upozorenje!",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        odabraniDogadaj.dvorana_dvorana_id = upit.Single();
                        db.SaveChanges();
                    }
                }
            }
            Close();
        }
    }
}
