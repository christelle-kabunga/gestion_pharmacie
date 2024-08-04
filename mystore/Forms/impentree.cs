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
    public partial class impentree : Form
    {
        public impentree()
        {
            InitializeComponent();
        }

        private void impentree_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'Dsentree.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.DataTable1TableAdapter.Fill(this.Dsentree.DataTable1);
            // TODO: cette ligne de code charge les données dans la table 'Dsentree.entree'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.entreeTableAdapter.Fill(this.Dsentree.entree);

            this.reportViewer1.RefreshReport();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
