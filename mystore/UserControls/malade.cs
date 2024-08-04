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
    public partial class malade : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=gestion_pharmacie");//connection à la bd
        MySqlCommand cmd;// prendre à charge la commande
        public malade()
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
                string Myquery = ("SELECT * FROM malade ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datamal.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnajout_Click(object sender, EventArgs e)
        {
            if (nommal.Text == "" || postnommal.Text == "" || telmal.Text == "" )
            {
                MessageBox.Show("Completez tous les champs svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO malade(nommal,postnommal,tel) VALUES ('" + nommal.Text + "','" + postnommal.Text + "','" + telmal.Text + "')", con);//commande d'insertion
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enregistremment réussi", "Information");
                    con.Close();
                    populate();
                    nommal.Text = "";
                    postnommal.Text = "";
                    telmal.Text = "";
                   
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
            if (nommal.Text == "" || postnommal.Text == "" || telmal.Text == "")
            {
                MessageBox.Show("Informations maquantes ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE malade SET nommal='" + nommal.Text + "',postnommal='" + postnommal.Text + "',tel='" + telmal.Text + "' WHERE idmalade=" + cle + "", con);//commande de modif
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification réussie", "Information");



                    con.Close();
                    populate();
                    
                    nommal.Text = "";
                    postnommal.Text = "";
                    telmal.Text = "";
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
                    MySqlCommand cmd = new MySqlCommand("DELETE  from malade where idmalade= " + cle + "", con);//commande de supprimer
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression réussie", "Information");

                    con.Close();
                    populate();
                    nommal.Text = "";
                    postnommal.Text = "";
                    telmal.Text = "";
                    cle = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        int cle = 0;
        private void datamal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nommal.Text = datamal.SelectedRows[0].Cells[1].Value.ToString();
            postnommal.Text = datamal.SelectedRows[0].Cells[2].Value.ToString();
            telmal.Text = datamal.SelectedRows[0].Cells[3].Value.ToString();
            if (nommal.Text == "")
            {
                cle = 0;
            }
            else
            {
                cle = Convert.ToInt32(datamal.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
