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
    public partial class sortie : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=gestion_pharmacie");//connection à la bd
        MySqlCommand cmd;// prendre à charge la commande
        public sortie()
        {
            InitializeComponent();
        }
        //requetes pour le remplissage du datagriview entree
        void populate()
        {
            try
            {
                con.Open();
                string Myquery = ("SELECT entree.ident,entree.`date_entree`, medicaments.nommed, fournisseurs.nomfournisseur, entree.`prix`, entree.`qte` FROM `entree`,medicaments,fournisseurs WHERE medicaments.idmed=entree.medicament AND entree.fournisseur=fournisseurs.idfour AND entree.dateexp > NOW()");
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

        //requetes pour le remplissage du datagriview client
        void populatemalade()
        {
            try
            {
                con.Open();
                string Myquery = ("SELECT * FROM malade ");
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datamalade.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //requetes pour le remplissage du combobox categorie
        void fillcategory()
        {
            string query = ("SELECT * FROM categorie");
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("nomcat", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                // comboBox1.ValueMember = "nomcat";
                // comboBox1.DataSource = dt;
                combo.ValueMember = "nomcat";
                combo.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        //les variables
        int num = 0, qte;
        double pu, pt;
        string product;
        int flag = 0;
        int stock;
        string datefab,dateexp;
        private void dataent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = dataent.SelectedRows[0].Cells[2].Value.ToString();
            // qte = Convert.ToInt32(numericUpDown1.Text);
            stock = Convert.ToInt32(dataent.SelectedRows[0].Cells[5].Value.ToString());
            pu = Convert.ToDouble(dataent.SelectedRows[0].Cells[4].Value.ToString());
            // pt = qte * pu;
            flag = 1;
            idmed.Text = dataent.SelectedRows[0].Cells[0].Value.ToString();
            med.Text = dataent.SelectedRows[0].Cells[2].Value.ToString();
        }

        // Requêtes pour vérifier le médicament expiré
        void populatess()
        {
            try
            {
                con.Open();
                string Myquery = "SELECT medicaments.nommed, entree.dateexp, fournisseurs.nomfournisseur, entree.prix, entree.dateexp, entree.qte FROM entree, medicaments, fournisseurs WHERE entree.medicament = medicaments.idmed AND entree.fournisseur = fournisseurs.idfour AND entree.dateexp < NOW()";
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataent.DataSource = ds.Tables[0];
                con.Close();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    // Obtenez le nom du médicament
                    string nom = row["nommed"].ToString();

                    // Obtenez la date d'expiration du médicament
                    DateTime dateExpiration = Convert.ToDateTime(row["dateexp"]);

                    // Générez l'alerte
                    MessageBox.Show("Il a expiré depuis le " + dateExpiration, "Veillez  Destocker  " + "Le médicament  " + nom);
                    // MessageBox.Show("Le medicament a expiré veillez le destocker svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortie_Load(object sender, EventArgs e)
        {
            populate();
            populatemalade();
            fillcategory();
           // populatess();


            table.Columns.Add(" Num", typeof(int));//data type int
            table.Columns.Add(" Produit", typeof(string));//data type string
            table.Columns.Add(" Quantité", typeof(int));//data type string
            table.Columns.Add(" PU", typeof(double));//data type string
            table.Columns.Add(" PT", typeof(double));//data type string
            datasortie.DataSource = table;
        }
        DataTable table = new DataTable();

        private void datamalade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idmal.Text = datamalade.SelectedRows[0].Cells[0].Value.ToString();
            nomcl.Text = datamalade.SelectedRows[0].Cells[1].Value.ToString();
            postnomcl.Text = datamalade.SelectedRows[0].Cells[2].Value.ToString();
        }
        //recherche à partir du combobox pour les medicaments 
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
         
        private void datasortie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = dataent.SelectedRows[0].Cells[1].Value.ToString();
            // qte = Convert.ToInt32(numericUpDown1.Text);
            stock = Convert.ToInt32(dataent.SelectedRows[0].Cells[4].Value.ToString());
            pu = Convert.ToDouble(dataent.SelectedRows[0].Cells[3].Value.ToString());
            // pt = qte * pu;
            flag = 1;
            //pour les dates
            //datefab =(dataent.SelectedRows[0].Cells[5].Value.ToString());
            //dateexp = (dataent.SelectedRows[0].Cells[6].Value.ToString());
            
          
        }

        double sum = 0;
        private object idsortie;
        //comment modifier le stock dès que un produit est soldé
        void updateproduct()
        {
            int id = Convert.ToInt32(dataent.SelectedRows[0].Cells[0].Value.ToString());
            int newqte = stock - Convert.ToInt32(qtetxt.Text);
            if (newqte < 0)
            {
                MessageBox.Show("Opération échouée ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                string query = "UPDATE entree SET qte =" + newqte + " WHERE ident=" + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                populate();
            }
           
        }
        //alternatives après le clic du bouton destocker
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (qtetxt.Text == "")
            {
                MessageBox.Show("Entrer une quantité ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                qtetxt.Text = "0";
                
            }
            if (int.Parse(qtetxt.Text.ToString()) < 1)
            {
                MessageBox.Show("La quantité ne doit pas être nulle ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (flag == 0)
            {
                MessageBox.Show("Selectionner un produit ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(qtetxt.Text) > stock)
            {
                MessageBox.Show("Nous n'avons pas assez de stock pour effectuer cette commande ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                num = num + 1;
                qte = Convert.ToInt32(qtetxt.Text);
                pt = qte * pu;
                table.Rows.Add(num, product, qte, pu, pt);
                datasortie.DataSource = table;
                flag = 0;
            }
            sum = sum + pt;
            lbltot.Text = sum.ToString();
            updateproduct();

            //insertion des commandes dans la table commande

            if (nomcl.Text == "" || postnomcl.Text == "" || lbltot.Text == "" || med.Text == "" || int.Parse(qtetxt.Text.ToString()) < 1)
            {
                MessageBox.Show("Remplissez tous les champs ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO sortie(date_sortie,qtesortie,medicament,malade,montant) VALUES (NOW(),'" + qtetxt.Text + "','" + idmed.Text + "','" + idmal.Text + "','" + lbltot.Text + "')", con);//sortie d'insertion
                cmd.ExecuteNonQuery();
                MessageBox.Show("Enregistremment réussi", "Information");
                qtetxt.Text = "";
                nomcl.Text = "";
                postnomcl.Text = "";
                lbltot.Text = "";

                con.Close();
                // populate();  
            }
        
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
    }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
           
        }
}
}

