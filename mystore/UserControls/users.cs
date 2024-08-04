using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mystore.UserControls
{
    public partial class users : UserControl
        
     
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=gestion_pharmacie");//connection à la bd
        MySqlCommand cmd;// prendre à charge la commande
        public users()
        {
            InitializeComponent();
            populate();
        }
        //requetes pour le remplissage du datagriview
        void populate()
        {
            try
            {
                con.Open();
                string Myquery = ("SELECT * FROM users ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datausers.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (nomuser.Text == "" || teluser.Text == "" || sexeuser.SelectedIndex == -1 || adduser.Text == "" || pwd.Text == "")

            {
                MessageBox.Show("Completez tous les champs svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users(nomuser,teluser,adresse,sexe,password) VALUES ('" + nomuser.Text + "','" + teluser.Text + "','" + sexeuser.SelectedItem.ToString() + "','" + adduser.Text + "','" + pwd.Text + "')", con);//commande d'insertion
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enregistremment réussi", "Information");
                    
                  

                    con.Close();
                    populate();
                    nomuser.Text = "";
                    teluser.Text = "";
                    sexeuser.Text = "";
                    adduser.Text = "";
                    pwd.Text = "";
                    cle = 0;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }
        int cle = 0;
        private void datausers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomuser.Text = datausers.SelectedRows[0].Cells[1].Value.ToString();
            teluser.Text = datausers.SelectedRows[0].Cells[2].Value.ToString();
            sexeuser.Text = datausers.SelectedRows[0].Cells[3].Value.ToString();
            adduser.Text = datausers.SelectedRows[0].Cells[4].Value.ToString();
            pwd.Text = datausers.SelectedRows[0].Cells[5].Value.ToString();
            if (nomuser.Text == "")
            {
                cle = 0;
            }else
            {
                cle = Convert.ToInt32(datausers.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (cle==0)
            {
                MessageBox.Show("Selectionner un élément à effacer svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE  from users where iduser= "+cle+"", con);//commande de supprimer
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression réussie", "Information");
                   
                    con.Close();
                    populate();
                    nomuser.Text = "";
                    teluser.Text = "";
                    sexeuser.Text = "";
                    adduser.Text = "";
                    pwd.Text = "";
                    cle = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (nomuser.Text == "" || teluser.Text == "" || sexeuser.Text == "" || adduser.Text == "" || pwd.Text == "")
            {
                MessageBox.Show("Informations maquantes ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE users SET nomuser='" + nomuser.Text + "',teluser='" + teluser.Text + "',adresse='" + adduser.Text + "',sexe='" + sexeuser.SelectedItem.ToString() + "',password='" + pwd.Text + "' WHERE iduser=" + cle + "", con);//commande de modif
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification réussie", "Information");



                    con.Close();
                    populate();
                    nomuser.Text = "";
                    teluser.Text = "";
                    sexeuser.Text = "";
                    adduser.Text = "";
                    pwd.Text = "";
                    cle = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void users_Load(object sender, EventArgs e)
        {

        }
    }
}
