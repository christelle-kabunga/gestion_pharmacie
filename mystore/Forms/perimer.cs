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
    public partial class perimer : Form
    {

        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=gestion_pharmacie");//connection à la bd
        MySqlCommand cmd;// prendre à charge la commande
        public perimer()
        {
            InitializeComponent();
        }
        //requetes pour verifier le medicament expiré
        void populates()
        {
            try
            {
                con.Open();
                string Myquery = "SELECT medicaments.nommed,fournisseurs.nomfournisseur, entree.prix,entree.datefab, entree.dateexp, entree.qte FROM entree, medicaments, fournisseurs WHERE entree.medicament = medicaments.idmed AND entree.fournisseur = fournisseurs.idfour AND entree.dateexp < NOW()";
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataper.DataSource = ds.Tables[0];
                con.Close();
                
            }
            catch (Exception A)
            {
                MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
            
        // Requêtes pour vérifier le médicament expiré
void populatess()
{
    try
    {
        con.Open();
        string Myquery = "SELECT medicaments.nommed,fournisseurs.nomfournisseur, entree.prix,entree.datefab, entree.dateexp, entree.qte FROM entree, medicaments, fournisseurs WHERE entree.medicament = medicaments.idmed AND entree.fournisseur = fournisseurs.idfour AND entree.dateexp <  NOW()";
        MySqlDataAdapter da = new MySqlDataAdapter(Myquery, con);
        MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
        var ds = new DataSet();
        da.Fill(ds);
        //dataper.DataSource = ds.Tables[0];
        con.Close();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            // Obtenez le nom du médicament
            string nom = row["nommed"].ToString();

            // Obtenez la date d'expiration du médicament
            DateTime dateExpiration = Convert.ToDateTime(row["dateexp"]);

            // Générez l'alerte
            MessageBox.Show("Il a expiré depuis le " + dateExpiration, "Veillez  Destocker  " + "Le médicament  " + nom );
           // MessageBox.Show("Le medicament a expiré veillez le destocker svp! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    catch (Exception A)
    {
        MessageBox.Show("Erreur" + A.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void perimer_Load(object sender, EventArgs e)
        {
            populates();
           populatess();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dashboard_chef per = new dashboard_chef();
            this.Hide();
            per.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
