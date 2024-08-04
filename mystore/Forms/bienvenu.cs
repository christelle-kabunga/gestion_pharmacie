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
    public partial class bienvenu : Form
    {
        public bienvenu()
        {
            InitializeComponent();
        }

        private void bienvenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
             start += 1;
            progress.Value = start;
            if (progress.Value == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                 login_form login = new login_form();
                 this.Hide();
                 login.Show();
        }
    }
}
}
