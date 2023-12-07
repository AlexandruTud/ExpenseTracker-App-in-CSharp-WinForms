using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class AdaugaCategorieForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int currentUserId;

        public AdaugaCategorieForm(int currentUserId)
        {
            InitializeComponent();
            Text = "Adauga Categorie";
            this.currentUserId = currentUserId;
        }

        private void AdaugaCategorieInBazaDeDate(string denumireCategorie)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                try
                {
                    if (CategorieExists(con, denumireCategorie))
                    {
                        MessageBox.Show("NU s-a putut adauga categoria. Categorie cu acest nume există deja în baza de date!");
                    }
                    else
                    {
                        string query = "INSERT INTO Categorie (DenumireCategorie) " +
                                       "VALUES (@DenumireCategorie)";

                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@DenumireCategorie", denumireCategorie);

                            con.Open(); 

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Categorie adăugată cu succes!");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close(); 
                    }

                    this.Close();
                }
            }
        }

        private bool CategorieExists(OleDbConnection con, string denumireCategorie)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Categorie WHERE DenumireCategorie = @DenumireCategorie";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DenumireCategorie", denumireCategorie);

                    con.Open(); 
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); 
                }
            }
        }



        private void btnAdauga_Click_1(object sender, EventArgs e)
        {
            string denumireCategorie = txtDenumireCategorie.Text;

            if (string.IsNullOrWhiteSpace(denumireCategorie))
            {
                MessageBox.Show("Completati numele categoriei!");
                return;
            }

            AdaugaCategorieInBazaDeDate(denumireCategorie);


            this.Close();
        }
    }
}
