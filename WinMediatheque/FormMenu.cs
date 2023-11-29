using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormMenu : Form
    {
        string chaineConnexion; //ceci permettra la connexion à la base de données //
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }
        public FormMenu()
        {
            ChaineConnexion = "server = localhost; user id = admincdi;password= nikola;database = cdi";

            InitializeComponent();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutLivre f = new AjoutLivre();
            f.ChaineConnexion = this.chaineConnexion;
            f.Show();

        }
    }
}
