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
    public partial class NovaBlagajna : Form
    {
        public NovaBlagajna()
        {
            InitializeComponent();
        }

        private Blagajna odabranaBlagajna;
        public NovaBlagajna(Blagajna blagajna)
        {
            InitializeComponent();
            odabranaBlagajna = blagajna;
        }


        private int SljedeciId;

        private void NovaBlagajna_Load(object sender, EventArgs e)
        {
            using (var db = new ArenaDB())
            {
                var upit2 = (from k in db.Blagajna
                             select k.blagajna_id).Max();
                SljedeciId = upit2 + 1;
            }

            if(odabranaBlagajna != null)
            {
                inputBlagajnaId.Text = odabranaBlagajna.blagajna_id.ToString();
                inputNaziv.Text = odabranaBlagajna.naziv_blagajne;
            }
            else
            {
                inputBlagajnaId.Text = SljedeciId.ToString();
            }
        }

        private void actionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actionPotvrdi_Click(object sender, EventArgs e)
        {
            using (var db = new ArenaDB())
            {

                if (odabranaBlagajna == null)
                {
                    Blagajna blagajna = new Blagajna
                    {
                        naziv_blagajne = inputNaziv.Text
                    };
                    db.Blagajna.Add(blagajna);
                    db.SaveChanges();
                }
                else
                {
                    db.Blagajna.Attach(odabranaBlagajna);
                    odabranaBlagajna.naziv_blagajne = inputNaziv.Text;
                    db.SaveChanges();
                }

            }
            Close();
        }

    }
}
