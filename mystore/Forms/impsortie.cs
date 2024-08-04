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
    public partial class impsortie : Form
    {
        public impsortie()
        {
            InitializeComponent();
        }

        private void impsortie_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'Dssortie.DataTable2'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.DataTable2TableAdapter.Fill(this.Dssortie.DataTable2);
            // TODO: cette ligne de code charge les données dans la table 'Dssortie.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.DataTable1TableAdapter.Fill(this.Dssortie.DataTable1);
            // TODO: cette ligne de code charge les données dans la table 'Dssortie.sortie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.sortieTableAdapter.Fill(this.Dssortie.sortie);

            this.reportViewer1.RefreshReport();
        }
    }
}
