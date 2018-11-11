using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPBDD
{
    public partial class FORM_connect : Form
    {
        Random rng = new Random();
        public FORM_connect()
        {
            InitializeComponent();
        }

        private void B_Connect_Click(object sender, EventArgs e)
        {
            
            
            string queryString =
                "SELECT *"
                + "FROM PROFIL"
                ;

            using (SqlConnection connect = new SqlConnection(chaineConnection())) 
            {
                SqlCommand command = new SqlCommand(queryString, connect);
                //command.Parameters.AddWithValue("@PSEUDO", TXT_Pseudo.Text);

                try
                {
                    connect.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show(reader[0].ToString().Trim());
                        MessageBox.Show(TXT_Pseudo.Text);
                        if (reader[0].ToString().Trim() == TXT_Pseudo.Text)
                        {
                            FORM_profil FORM_PROFIL = new FORM_profil();
                            FORM_PROFIL.Show(this);
                        }
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void B_Test_Click(object sender, EventArgs e)
        {
            string _pathMot = @"C:\Users\Pierre-Louis\Documents\GitHub\TPBDD\TPBDD\TPBDD\liste_francais.txt";
            using (SqlConnection connect = new SqlConnection(chaineConnection()))
            {
                String query = "INSERT INTO client (Pseudo,MotDePasse,Nom,Prenom,Email) VALUES (@pseudo,@mdp,@nom,@prenom,@email)";
                B_Test.UseWaitCursor = true;
                for (int i = 0; i < 200; i++)
                {
                    string[] mots = AleaTXT(_pathMot);
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@pseudo", mots[0] + rng.Next(10, 100).ToString());
                        command.Parameters.AddWithValue("@mdp", mots[1]);
                        string nom, prenom;
                        nom = mots[2];
                        prenom = mots[3];
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@prenom", prenom);
                        command.Parameters.AddWithValue("@email", nom + "." + prenom + "@gmail.com");
                        //command.Parameters.AddWithValue("@qs", mots[4]);

                        connect.Open();
                        int result = command.ExecuteNonQuery();
                        if (result < 0) MessageBox.Show("Erreur! :/");
                        connect.Close();
                    }
                }
                B_Test.UseWaitCursor = false;
            }
        }

        private string chaineConnection()
        {
            string connectionString;
            //Initialisation de variable
            connectionString =
                "Data Source=(local); "
                + "Initial Catalog=TPBDD; "
                + "Integrated Security=true;";
            return connectionString;
        }

        private string[] AleaTXT(string chemin)
        {
            string[] mots = new string[5];

            int[] listmot = new int[5];
            int seuil = 1, temp;
            for(int i = 0; i<5; i++)
            {
                temp = rng.Next(seuil, 6000);
                seuil = temp;
                listmot[i] = temp;
            }
            try
            {
                StreamReader stream = new StreamReader(chemin);
                seuil = 0;
                for (int i = 0; i <= listmot[4]+5; i++)
                {
                    if(i == listmot[seuil])
                    {
                        mots[seuil] = stream.ReadLine().Split(' ')[0];
                        seuil++;
                    }
                    else
                    {
                        stream.ReadLine();
                    }
                }
                stream.Close();
            }
            catch(Exception)
            {

            }
            return mots;
        }
    }
}
