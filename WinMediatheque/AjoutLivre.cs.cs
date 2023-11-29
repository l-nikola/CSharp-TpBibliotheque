using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
namespace WinMediatheque
{
    public partial class AjoutLivre : Form
    {
        string chaineConnexion; //ceci permettra la connexion à la base de données //
        public string ChaineConnexion
        {
            get => chaineConnexion; set => chaineConnexion = value;
        }
        public AjoutLivre()
        {
            InitializeComponent();
        }
        public void RAZ()
        {
            txb_ref.Text = "";
            txb_titre.Text = "";
            txb_auteur.Text = "";
            txb_nbpages.Text = "";
        }
        private void btn_ajouter_Click(object sender, System.EventArgs e)
        {
            if (txb_ref.Text == "" || txb_auteur.Text == "" || txb_nbpages.Text == "" || txb_titre.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs ", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dresult = MessageBox.Show("Etes vous sur ? ", "Alert",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dresult == DialogResult.OK)
                {
                    string etatLivre = "D";
                    CURSEUR cs = new CURSEUR(ChaineConnexion);
                    string requete = "insert into Livre values ('";
                    requete += txb_ref.Text;
                    requete += "','";
                    requete += txb_titre.Text;
                    requete += "','";
                    requete += txb_auteur.Text;
                    requete += "',";
                    requete += Convert.ToInt32(txb_nbpages.Text);
                    requete += ",'";
                    requete += etatLivre;
                    requete += "');";
                    cs.ReqAdmin(requete);
                    cs.fermer();
                    RAZ();
                }
                else
                {
                    RAZ();
                }
            }
        }
    }
}