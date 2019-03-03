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
    public partial class FormNewAccount : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Home\Documents\Développement\GestPlanFormation\GestPlanFormation\GestPlanFormation.mdf;Integrated Security=True");
        SqlDataReader rd;
        public FormNewAccount()
        {
            InitializeComponent();
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (RegularExpression.checkForEmail(textBoxEmail.Text.ToString())) { }
                //labelEmailControl.Text = "Valid";
            else
                MessageBox.Show("Ceci n'est pas un email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtBoxConfPassword_Validating(object sender, CancelEventArgs e)
        {
            //if(textBox4 == txtBoxConfPassword)
            //{
                btnCreateAccount.Enabled = true;
           // }
           // else
           // {
           //     MessageBox.Show("Les deux mot de passe sont différents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           //     btnCreateAccount.Enabled = false;                
           // }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            string rqt = "select * from Utilisateurs where login='" + textBoxLogin.Text + "'";
            SqlCommand cmd = new SqlCommand(rqt, con);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MessageBox.Show("Ce login est déjà utilisé");
                btnCreateAccount.Enabled = false;
            }
            
            con.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            con.Open();

            string rq = "insert into Utilisateurs (login,name,lastName,email,password) values ('" + textBoxLogin.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBoxEmail.Text + "','" + textBox4.Text + "')";
            SqlCommand cmd = new SqlCommand(rq, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Votre compte est créé avec succès !", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //con.Close();
        }
    }
}
