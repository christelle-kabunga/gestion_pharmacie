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
    public partial class dashboard_chef : Form
    {
        int panelWidith;
        bool isCollapsed;
        public dashboard_chef()
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
            mystore.UserControls.uc_home remplir = new mystore.UserControls.uc_home();

            addelts(remplir);
        }

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

        private void btnusers_Click(object sender, EventArgs e)
        {
            movesidepanel(btnusers);

            mystore.UserControls.users user = new mystore.UserControls.users();

            addelts(user);
        }

        private void btnachArt_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            movesidepanel(btnsetting);
            mystore.UserControls.liste_rap rap = new mystore.UserControls.liste_rap();

            addelts(rap);

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            this.Hide();
            login.Show();
        }

    }
}
