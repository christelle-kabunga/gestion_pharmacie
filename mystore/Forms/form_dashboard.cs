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
    public partial class form_dashboard : Form
    {
        int panelWidith;
        bool isCollapsed;
        public form_dashboard()
        {
            InitializeComponent();
           // timerTime.Start();
            labeltime.Text = Date;
            panelWidith = panelLeft.Width;
            isCollapsed = false;
            movesidepanel(btnacc);
            mystore.UserControls.uc_home remplir = new mystore.UserControls.uc_home();
        }
        public string Date { get; set; }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= panelWidith)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void movesidepanel(Control btn)
        {
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }
        private void addelts(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelcontrols.Controls.Clear();
            panelcontrols.Controls.Add(c);
        }
        private void btnacc_Click(object sender, EventArgs e)
        {
            movesidepanel(btnacc);
            mystore.UserControls.uc_home remplir =new mystore.UserControls.uc_home();

            addelts(remplir);
        }

        private void btnvente_Click(object sender, EventArgs e)
        {
            movesidepanel(btnvente);
            mystore.UserControls.entree ventedash = new mystore.UserControls.entree();

            addelts(ventedash);
        }

        private void btnachArt_Click(object sender, EventArgs e)
        {
            movesidepanel(btnachArt);
            mystore.UserControls.medicament up = new mystore.UserControls.medicament();

            addelts(up);
        }

        private void btndep_Click(object sender, EventArgs e)
        {
            movesidepanel(btndep);
            mystore.UserControls.categorie cat = new mystore.UserControls.categorie();

            addelts(cat);
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            movesidepanel(btnfour);
            mystore.UserControls.fournisseur four = new mystore.UserControls.fournisseur();

            addelts(four);

           
        }

        private void btnvoirvente_Click(object sender, EventArgs e)
        {
            movesidepanel(btnvoirvente);
            mystore.UserControls.sortie sortie = new mystore.UserControls.sortie();

            addelts(sortie);
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
           // movesidepanel(btnsetting);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labeltime.Text = dt.ToString("HH:MM:SS");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            this.Hide();
            login.Show();
        }

        private void btnma_Click(object sender, EventArgs e)
        {
           
        }

        private void btnma_Click_1(object sender, EventArgs e)
        {
            movesidepanel(btnma);
            mystore.UserControls.malade ma = new mystore.UserControls.malade();

            addelts(ma);
        }
       
    }
}
