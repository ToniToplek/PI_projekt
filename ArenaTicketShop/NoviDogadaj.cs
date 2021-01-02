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
    public partial class NoviDogadaj : Form
    {
        private Dogadaj odabraniDogadaj;
        public NoviDogadaj(Dogadaj dogadaj)
        {
            InitializeComponent();
            odabraniDogadaj = dogadaj;
        }

        public NoviDogadaj()
        {
            InitializeComponent();
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actionUredu_Click(object sender, EventArgs e)
        {
            using (var db = new ArenaDB())
            {
                string odabranaDvorana = outputDvorana.SelectedItem.ToString();

                var upit = from d in db.Dvorana
                           where d.naziv_dvorane == odabranaDvorana
                           select d.dvorana_id;

                Dogadaj dogadaj = new Dogadaj
                {
                    naziv_dogadaja = inputNaziv.Text,
                    vrijeme_dogadaja = DateTime.Parse(inputVrijeme.Text),
                    dvorana_dvorana_id = upit.Single(),
                    cijena = int.Parse(inputCijena.Text)
                };
                db.Dogadaj.Add(dogadaj);
                db.SaveChanges();
            }
            Close();
        }

        private void NoviDogadaj_Load(object sender, EventArgs e)
        {
            inputVrijeme.Format = DateTimePickerFormat.Custom;
            inputVrijeme.CustomFormat = "yyyy-MM-dd HH:mm:ss";

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
    }
}
