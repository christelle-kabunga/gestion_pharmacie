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
    public partial class categorie : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=gestion_pharmacie");//connection à la bd
        MySqlCommand cmd;// prendre à charge la commande
        public categorie()
        {
            InitializeComponent();
            populate();
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //requetes pour le remplissage du datagriview
        void populate()
        {
            try
            {
                con.Open();
                string Myquery = ("SELECT * FROM categorie ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datacat.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (nomcat.Text == "" )
            {
                MessageBox.Show("Completez tous les champs svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO categorie(nomcat) VALUES ('" + nomcat.Text + "')", con);//commande d'insertion
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enregistremment réussi", "Information");



                    con.Close();
                    populate();
                    nomcat.Text = "";
                   
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
            if (nomcat.Text == "" )
            {
                MessageBox.Show("Informations maquantes ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE categorie SET nomcat='" + nomcat.Text + "' WHERE id=" + cle + "", con);//commande de modif
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification réussie", "Information");



                    con.Close();
                    populate();
                    nomcat.Text = "";
                  

                    cle = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (cle == 0)
            {
                MessageBox.Show("Selectionner un élément à effacer svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE  from categorie where id= " + cle + "", con);//commande de supprimer
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression réussie", "Information");

                    con.Close();
                    populate();
                    nomcat.Text = "";
                    
                    cle = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
        int cle=0;
        private void datacat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             nomcat.Text = datacat.SelectedRows[0].Cells[1].Value.ToString();
           

            if (nomcat.Text == "")
            {
                cle = 0;
            }
            else
            {
                cle = Convert.ToInt32(datacat.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
}
}
