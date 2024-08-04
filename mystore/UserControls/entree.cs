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
    public partial class entree : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=gestion_pharmacie;ConvertZeroDateTime=True;AllowZeroDateTime=true");//connection à la bd
        MySqlCommand cmd;// prendre à charge la commande
        public entree()
        {
            InitializeComponent();
            populate();
            
            
        }
        
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
            cmd.CommandText = "select * from medicaments";
            MySqlDataAdapter adap = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
               // combo.Items.Add(item[1]);
                catmed.Items.Add(item[1]);
                valeurs.Add(item[0].ToString());
            }
            
        }

        // requete pour remplir le combobox
        List<String> valeurse = new List<String>();
        private void remp()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"server=localhost;uid=root;pwd='';database=gestion_pharmacie";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM entree WHERE medicament='" + lama.Text + "'";
            MySqlDataAdapter adap = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                combo.Items.Add(item[1]);
                
                valeurse.Add(item[0].ToString());
            }

        }
        // requete pour remplir le combobox
        List<String> valeurss = new List<String>();
        private void cleEtrangeres()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"server=localhost;uid=root;pwd='';database=gestion_pharmacie";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from fournisseurs";
            MySqlDataAdapter adap = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                catfour.Items.Add(item[2]);
                valeurss.Add(item[0].ToString());
            }

        }
        //requetes pour le remplissage du datagriview
        void populate()
        {
            try
            {
                con.Open();
                string Myquery = ("SELECT entree.ident,entree.`date_entree`, medicaments.nommed, fournisseurs.nomfournisseur, entree.`prix`, entree.`qte`,entree.datefab,entree.dateexp FROM `entree`,medicaments,fournisseurs WHERE medicaments.idmed=entree.medicament AND entree.fournisseur=fournisseurs.idfour");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataent.DataSource = ds.Tables[0];
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
                string Myquery = ("SELECT * FROM entree WHERE medicament='" + lblmed.Text + "'");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataent.DataSource = ds.Tables[0];
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
                string Myquery = ("SELECT entree.ident entree.`date_entree`, medicaments.nommed, fournisseurs.nomfournisseur, entree.`prix`, entree.`qte`,entree.datefab,entree.dateexp FROM `entree`,medicaments,fournisseurs WHERE medicaments.idmed=entree.medicament AND entree.fournisseur=fournisseurs.idfour ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataent.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //string datefab;
            //DateTime date = DateTime.ParseExact(datefab, "yyyy-MM-dd", System.Globalization.CultureInfo.InstalledUICulture);
            //DateTime date = DateTime.Now;
            //string formattedDate = date.ToString("yyyy-MM-dd");
            if (catmed.Text == "" || catfour.Text == "" || prixmed.Text == "" || qtemed.Text == "" || datefab.Text == "" || dateexp.Text == "")
            {
                MessageBox.Show("Completez tous les champs svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO entree(date_entree,medicament,fournisseur,prix,qte,datefab,dateexp) VALUES (NOW(),'" + lblmed.Text + "','" + lblfour.Text + "','" + prixmed.Text + "','" + qtemed.Text + "','" + datefab.Value.ToString("yyyy-MM-dd") + "','" + dateexp.Value.ToString("yyyy-MM-dd") + "')", con);//commande d'insertion
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enregistremment réussi", "Information");



                    con.Close();
                    populate();
                    catmed.Text = "";
                    catfour.Text = "";
                    prixmed.Text = "";
                    qtemed.Text = "";
                    datefab.Text = "";
                    dateexp.Text = "";
                    
                     cle = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } 
        }
        int cle = 0;
        private void datamed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lab.Text = dataent.SelectedRows[0].Cells[0].Value.ToString();
            catmed.Text = dataent.SelectedRows[0].Cells[2].Value.ToString();
            catfour.Text = dataent.SelectedRows[0].Cells[3].Value.ToString();
            prixmed.Text = dataent.SelectedRows[0].Cells[4].Value.ToString();
            qtemed.Text = dataent.SelectedRows[0].Cells[5].Value.ToString();
            //datefab.Text = dataent.SelectedRows[0].Cells[6].Value.ToString();
            //dateexp.Text = dataent.SelectedRows[0].Cells[7].Value.ToString();
           
            if (catmed.Text == "")
            {
                cle = 0;
            }
            else
            {
                cle = Convert.ToInt32(dataent.SelectedRows[0].Cells[0].Value.ToString());
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
                    MySqlCommand cmd = new MySqlCommand("DELETE  from entree where ident= " + cle + "", con);//commande de supprimer
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression réussie", "Information");

                    con.Close();
                    populate();
                    catmed.Text = "";
                    catfour.Text = "";
                    prixmed.Text = "";
                    qtemed.Text = "";
                    datefab.Text = "";
                    dateexp.Text = "";
                   
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
            if (catmed.SelectedIndex == -1 || catfour.SelectedIndex == -1 || prixmed.Text == "" || qtemed.Text == "" || datefab.Text == "" || dateexp.Text == "")
            {
                MessageBox.Show("Informations maquantes ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE entree SET medicament='" + lblmed.Text + "',fournisseur='" + lblfour.Text + "',prix='" + prixmed.Text + "',qte='" + qtemed.Text + "',datefab='" + datefab.Value.ToString("yyyy-MM-dd") + "',dateexp='" + dateexp.Value.ToString("yyyy-MM-dd") + "' WHERE ident=" + cle + "", con);//commande de modif
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification réussie", "Information");



                    con.Close();
                    populate();
                    catmed.Text = "";
                    catfour.Text = "";
                    prixmed.Text = "";
                    qtemed.Text = "";
                    datefab.Text = "";
                    dateexp.Text = "";
                  
                    cle = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void entree_Load(object sender, EventArgs e)
        {
            cleEtrangere();
            cleEtrangeres();
            
        }

        private void catmed_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblmed.Text = valeurs[catmed.SelectedIndex];
        }

        private void catfour_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblfour.Text = valeurss[catfour.SelectedIndex];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            populates();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           // filterbycategory();
            remp();
        }

        private void comboser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lama.Text = valeurse[catmed.SelectedIndex];
        }
          
 
        }

      
        
    }

