using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mystore.Forms
{
    public partial class admin : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=gestion_pharmacie");//connection à la bd
        MySqlCommand cmd;// prendre à charge la commande
        public admin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtusername.Text))
            {
                MessageBox.Show("Entrer votre nom d'utilisateur!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtusername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtpwd.Text))
            {
                MessageBox.Show("Entrer votre Mot de passe!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpwd.Focus();
                return;
            }
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  `username`,  `password` FROM `admin`  where username=@username AND password=@password";
            cmd.Parameters.Add("username", MySqlDbType.VarChar).Value = txtusername.Text;
            cmd.Parameters.Add("password", MySqlDbType.VarChar).Value = txtpwd.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    dashboard_chef frmacc = new dashboard_chef();
                    frmacc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            finally
            {
                con.Close();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtpwd.UseSystemPasswordChar = true;
            }
        }
    }
}
