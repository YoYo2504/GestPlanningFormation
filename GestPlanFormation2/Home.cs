using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestPlanFormation
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        bool connecter = false;
        


        private void Connect_Click(object sender, EventArgs e)
        {           
            
            if ( Connect.Text == "Se connecter")
            {
                FormInscription1 inscription = new FormInscription1();
                inscription.ShowDialog();
                if (inscription.retunCo() == true)
                {
                   
                    cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Home\Documents\Développement\GestPlanFormation\GestPlanFormation\GestPlanFormation.mdf;Integrated Security=True");
                    try
                    {
                        if (cn.State == ConnectionState.Closed) { cn.Open(); }
                        Connect.Text = "Se déconnecter";

                        connecter = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
            else //se déconnecter
            {
                cn.Close();
                Connect.Text = "Se connecter";                
                connecter = false;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestPlanFormationDataSet1.Formations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.formationsTableAdapter1.Fill(this.gestPlanFormationDataSet1.Formations);
            // TODO: cette ligne de code charge les données dans la table 'gestPlanFormationDataSet.Formations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.formationsTableAdapter.Fill(this.gestPlanFormationDataSet.Formations);

        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            if(txtBxNom.Text == "")
            {
                MessageBox.Show("Veuiller rentrer votre Nom");
            }
            else if(txtBxPrenom.Text == "")
            {
                MessageBox.Show("Veuiller rentrer votre Prénom");
            }
            else
            {
                if (connecter)
                {
                    bool error = false;
                    SqlCommand WarningLimit = new SqlCommand("Select * from Formations Where Name = @listBox1", cn);
                    WarningLimit.Parameters.AddWithValue("@listBox1", listBox1.SelectedValue);
                    using (SqlDataReader Limit = WarningLimit.ExecuteReader())
                    {
                        while (Limit.Read())
                        {
                            
                            int LimitParticipants = Convert.ToInt32(Limit["LimitParticipants"]);
                            int NbParticipants = Convert.ToInt32(Limit["NbParticipants"]);
                            DateTime Date = Convert.ToDateTime(Limit["Date"]);
                            if (NbParticipants == LimitParticipants)
                            {
                                error = true;
                                MessageBox.Show("Désolé mais il n'y a plus de place pour cette formation ...");
                            }
                            else if (Date < DateTime.Now)
                            {
                                error = true;
                                MessageBox.Show("Désolé mais cette formation à déjà eu lieu ...");
                            }
                        }                       
                    }
                    if (error == false)
                    {
                        //try
                        //{
                            SqlCommand cmd = new SqlCommand("Update Formations Set NbParticipants = NbParticipants + 1 Where Name = @listBox1 ", cn);
                            cmd.Parameters.AddWithValue("@listBox1", listBox1.SelectedValue);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            MessageBox.Show("Vous êtes inscrit à la formation !");
                        //}
                        //catch (Exception exe)
                        //{
                        //    Console.WriteLine(exe.Message);
                        //}
                    }

                }
                else
                {
                    MessageBox.Show("Vous n'êtes pas connecter");
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (connecter)
            {
                
                listView1.Items.Clear();
                SqlCommand cmd = new SqlCommand("Select * from Formations ", cn);
                using(SqlDataReader Lire = cmd.ExecuteReader())
                {
                    while (Lire.Read())
                    {
                        string Name = Lire["Name"].ToString();
                        string LimitParticipants = Lire["LimitParticipants"].ToString();
                        string NbParticipants = Lire["NbParticipants"].ToString();
                        string Date = Lire["Date"].ToString();

                        listView1.Items.Add(new ListViewItem(new[] { Name , LimitParticipants , NbParticipants, Date }));
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecter");
            }
        }
    }
}
