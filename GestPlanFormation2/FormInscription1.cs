using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPlanFormation
{
    public partial class FormInscription1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Home\Documents\Développement\GestPlanFormation\GestPlanFormation\GestPlanFormation.mdf;Integrated Security=True");
        DataSet ds = new DataSet();
        DataTable dt;
        bool connecter = false;

        //public bool Connecter { get => connecter; set => connecter = value; }

        private void FormInscription1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adap = new SqlDataAdapter("select * from Utilisateurs", con);
            adap.Fill(ds, "Utilisateurs");
            dt = ds.Tables["Utilisateurs"];
        }

        public FormInscription1()
        {
            InitializeComponent();
        }

        private void btnEnvoyer1_Click(object sender, EventArgs e)
        {
            
            for(int i=0; i<ds.Tables["Utilisateurs"].Rows.Count; i++)
            {
                if (textBoxLogin.Text.Equals(ds.Tables["Utilisateurs"].Rows[i][5]) && textBoxPassword.Text.Equals(ds.Tables["Utilisateurs"].Rows[i][4]))
                {
                   
                    connecter = true;
                    break;                    
                }
            }
            if (connecter == true)
            {
                MessageBox.Show("Bienvenue");
                
            }
            else
            {
                MessageBox.Show("Login ou Mot de passe incorrect !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxLogin.Focus();
                
            }
        }
        
        private void btnNewAccount_Click(object sender, EventArgs e)
        {            
            FormNewAccount newAccount = new FormNewAccount();
            newAccount.ShowDialog();
        }

        public bool retunCo()
        {
            return connecter;
        }

        public static implicit operator FormInscription1(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
