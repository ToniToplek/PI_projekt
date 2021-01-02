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
    public partial class ProsliDogadaji : Form
    {
        public ProsliDogadaji()
        {
            InitializeComponent();
        }

        private void ProsliDogadaji_Load(object sender, EventArgs e)
        {
            PrikaziProsleDogadaje();
        }

        private void PrikaziProsleDogadaje()
        {
            using (var db = new ArenaDB())
            {
                DateTime trenutnoVrijeme = DateTime.Now.AddHours(-1);
                var upit = from d in db.Dogadaj
                           where d.vrijeme_dogadaja <= trenutnoVrijeme
                           select d;

                outputProsloDogadaji.DataSource = upit.ToList();
                outputProsloDogadaji.Columns[0].Visible = false;
                outputProsloDogadaji.Columns[3].Visible = false;
                outputProsloDogadaji.Columns[5].Visible = false;
                outputProsloDogadaji.Columns[6].Visible = false;
                outputProsloDogadaji.Columns[1].HeaderText = "Naziv događaja";
                outputProsloDogadaji.Columns[2].HeaderText = "Vrijeme događaja";
                outputProsloDogadaji.Columns[4].HeaderText = "Cijena";
            }
        }

        private void actionUrediDogadaj_Click(object sender, EventArgs e)
        {
            if (outputProsloDogadaji.CurrentRow != null)
            {
                UrediDogadaj forma = new UrediDogadaj(outputProsloDogadaji.CurrentRow.DataBoundItem as Dogadaj);
                forma.ShowDialog();
                PrikaziProsleDogadaje();
            }
            else
            {
                MessageBox.Show("Niste odabrali događaj!");
            }
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actionObrisi_Click(object sender, EventArgs e)
        {
            if (outputProsloDogadaji.CurrentRow != null)
            {
                Dogadaj odabraniDogadaj = outputProsloDogadaji.CurrentRow.DataBoundItem as Dogadaj;
                if (odabraniDogadaj != null)
                {
                    if (MessageBox.Show("Obrisat ćete događaj zauvijek! Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new ArenaDB())
                        {
                            db.Dogadaj.Attach(odabraniDogadaj);

                            var upit = from r in db.Sjedalo_rez
                                       where r.dogadaj_dogadaj_id == odabraniDogadaj.dogadaj_id
                                       select r;

                            foreach (var item in upit.ToList())
                            {
                                db.Sjedalo_rez.Remove(item);
                            }

                            db.Dogadaj.Remove(odabraniDogadaj);
                            db.SaveChanges();
                        }
                        PrikaziProsleDogadaje();
                    }
                }
            }
        }

    }
}
