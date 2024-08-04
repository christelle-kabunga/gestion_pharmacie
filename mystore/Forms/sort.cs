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
    public partial class sort : Form
    {
        public sort()
        {
            InitializeComponent();
        }

        private void sort_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'DataSet1.sortie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.sortieTableAdapter.Fill(this.DataSet1.sortie);
            // TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
