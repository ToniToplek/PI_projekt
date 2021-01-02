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
    public partial class BrziUnosSjedala : Form
    {
        private Sektor odabraniSektor;
        public BrziUnosSjedala(Sektor sektor)
        {
            InitializeComponent();
            odabraniSektor = sektor;
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actionUnesi_Click(object sender, EventArgs e)
        {
            using (var db = new ArenaDB())
            {
                int red = int.Parse(inputRed.Text);
                int broj = int.Parse(inputBroj.Text);
                for (int i = 1;i<=red;i++) {
                    for (int j = 1; j<=broj;j++) {
                        Sjedalo sjedalo = new Sjedalo
                        {
                            red = i,
                            broj = j,
                            sektor_sektor_id = odabraniSektor.sektor_id
                        };

                        var upit = (from s in db.Sjedalo
                                    where s.broj == j && s.red == i && odabraniSektor.sektor_id == s.sektor_sektor_id
                                    select s).Count();

                        if (upit == 0)
                        {
                            db.Sjedalo.Add(sjedalo);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Vec postoji to sjedalo!");
                        }
                    }
                }
                Close();
            }

        }
    }
}
