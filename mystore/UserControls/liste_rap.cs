using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mystore.UserControls
{
    public partial class liste_rap : UserControl
    {
        public liste_rap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mystore.Forms.impentree frm = new mystore.Forms.impentree();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mystore.Forms.impmed frme = new mystore.Forms.impmed();
            frme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mystore.Forms.impsortie frme = new mystore.Forms.impsortie();
            frme.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mystore.Forms.perimer frmee = new mystore.Forms.perimer();
            frmee.ShowDialog();
        }
    }
}
