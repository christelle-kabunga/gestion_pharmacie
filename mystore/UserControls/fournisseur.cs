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
    public partial class fournisseur : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=gestion_pharmacie");//connection à la bd
        MySqlCommand cmd;// prendre à charge la commande
        public fournisseur()
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
                string Myquery = ("SELECT * FROM fournisseurs ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datafour.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // pour faire la recherche
        void filterbycategory()
        {
            try
            {
                con.Open();
                string Myquery = ("SELECT * FROM fournisseur WHERE nomfournisseur='" + nomfour.Text + "' ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datafour.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //requetes pour le remplissage du datagriview
        void populates()
        {
            try
            {
                con.Open();
                string Myquery = ("SELECT * FROM fournisseurs ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datafour.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnajout_Click(object sender, EventArgs e)
        {
            if (nomfour.Text == "" || postnomfour.Text == "" || telfour.Text == "" )
            {
                MessageBox.Show("Completez tous les champs svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO fournisseurs(Date,nomfournisseur,postnom,tel) VALUES (NOW(),'" + nomfour.Text + "','" + postnomfour.Text + "','" + telfour.Text + "')", con);//commande d'insertion
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enregistremment réussi", "Information");



                    con.Close();
                    populate();
                    nomfour.Text = "";
                    postnomfour.Text = "";
                    telfour.Text = "";

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
            if (nomfour.Text == "" || postnomfour.Text == "" || telfour.Text == "" )
            {
                MessageBox.Show("Informations maquantes ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE fournisseurs SET nomfournisseur='" + nomfour.Text + "',postnom='" + postnomfour.Text + "',tel='" + telfour.Text + "' WHERE idfour=" + cle + "", con);//commande de modif
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification réussie", "Information");



                    con.Close();
                    populate();
                    nomfour.Text = "";
                    postnomfour.Text = "";
                    telfour.Text = "";
                   
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
                    MySqlCommand cmd = new MySqlCommand("DELETE  from fournisseurs where idfour= " + cle + "", con);//commande de supprimer
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression réussie", "Information");

                    con.Close();
                    populate();
                    nomfour.Text = "";
                    postnomfour.Text = "";
                    telfour.Text = "";
                    
                    cle = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        int cle = 0;
        private void datafour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomfour.Text = datafour.SelectedRows[0].Cells[2].Value.ToString();
            postnomfour.Text = datafour.SelectedRows[0].Cells[3].Value.ToString();
            telfour.Text = datafour.SelectedRows[0].Cells[4].Value.ToString();

            if (nomfour.Text == "")
            {
                cle = 0;
            }
            else
            {
                cle = Convert.ToInt32(datafour.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void fournisseur_Load(object sender, EventArgs e)
        {

        }
    }
}
