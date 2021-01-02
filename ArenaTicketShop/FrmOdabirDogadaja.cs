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
    public partial class FrmOdabirDogadaja : Form
    {
        public FrmOdabirDogadaja()
        {
            InitializeComponent();
        }

        private void OdabirDogadaja_Load(object sender, EventArgs e)
        {
            PrikaziDvorane();
        }

        private void PrikaziDvorane()
        {
            using (var db = new ArenaDB())
            {
                var dvorana = from t in db.Dvorana
                                  select t;

                dgvDvorana.DataSource = dvorana.ToList();
                dgvDvorana.Columns[3].Visible = false;
            }
        }

    }
}
