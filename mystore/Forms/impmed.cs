using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mystore.Forms
{
    public partial class impmed : Form
    {
        public impmed()
        {
            InitializeComponent();
        }

        private void impmed_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'Dsmed.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.DataTable1TableAdapter.Fill(this.Dsmed.DataTable1);
            // TODO: cette ligne de code charge les données dans la table 'Dsmed.medicaments'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.medicamentsTableAdapter.Fill(this.Dsmed.medicaments);

            this.reportViewer1.RefreshReport();
        }
    }
}
