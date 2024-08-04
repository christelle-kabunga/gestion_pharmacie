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
    public partial class medicament : UserControl
    {

        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=gestion_pharmacie");//connection à la bd
        MySqlCommand cmd;// prendre à charge la commande
        public medicament()
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
                string Myquery = ("SELECT medicaments.idmed,medicaments.nommed,medicaments.dose,categorie.nomcat FROM medicaments,categorie Where medicaments.categorie=categorie.id ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datamedic.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //alerte
                  
       

        // requete pour remplir le combobox
        List<String> valeurs = new List<String>();
        private void cleEtrangere()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"server=localhost;uid=root;pwd='';database=gestion_pharmacie";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from categorie";
            MySqlDataAdapter adap = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                comboser.Items.Add(item[1]);
                catmed.Items.Add(item[1]);
                valeurs.Add(item[0].ToString());
            }

        }
        // pour faire la recherche
        void filterbycategory()
        {
            try
            {
                con.Open();
                string Myquery = ("SELECT * FROM medicaments WHERE categorie='" + lbl.Text + "'");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datamedic.DataSource = ds.Tables[0];
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
                string Myquery =  ("SELECT medicaments.idmed,medicaments.nommed,medicaments.dose,categorie.nomcat FROM medicaments,categorie Where medicaments.categorie=categorie.id ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datamedic.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnajout_Click(object sender, EventArgs e)
        {
            if (nommedic.Text == "" || dose.Text == "" )
            {
                MessageBox.Show("Completez tous les champs svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO medicaments(nommed,dose,categorie) VALUES ('" + nommedic.Text + "','" + dose.Text + "','" + lbl.Text + "')", con);//commande d'insertion
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enregistremment réussi", "Information");
                    con.Close();
                    populate();
                    nommedic.Text = "";
                    dose.Text = "";
                    catmed.Text = "";
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
            if (nommedic.Text == "" || dose.Text == "")
            {
                MessageBox.Show("Informations maquantes ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE medicaments SET nommed='" + nommedic.Text + "',dose='" + dose.Text + "',categorie='" + lbl.Text + "' WHERE idmed=" + cle + "", con);//commande de modif
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification réussie", "Information");



                    con.Close();
                    populate();
                    nommedic.Text = "";
                    dose.Text = "";
                    catmed.Text = "";

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
                    MySqlCommand cmd = new MySqlCommand("DELETE  from medicaments where idmed= " + cle + "", con);//commande de supprimer
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression réussie", "Information");

                    con.Close();
                    populate();
                    nommedic.Text = "";
                    dose.Text = "";
                    catmed.Text = "";

                    cle = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        int cle = 0;
        private void datamedic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nommedic.Text = datamedic.SelectedRows[0].Cells[1].Value.ToString();
            dose.Text = datamedic.SelectedRows[0].Cells[2].Value.ToString();
            catmed.Text = datamedic.SelectedRows[0].Cells[3].Value.ToString();


            if (nommedic.Text == "")
            {
                cle = 0;
            }
            else
            {
                cle = Convert.ToInt32(datamedic.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void catmed_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl.Text = valeurs[catmed.SelectedIndex];
        }

        private void medicament_Load(object sender, EventArgs e)
        {
            cleEtrangere();
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            populates();
        }

        private void comboser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
