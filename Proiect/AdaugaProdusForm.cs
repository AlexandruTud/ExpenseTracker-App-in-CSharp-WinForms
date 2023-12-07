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
    public partial class AdaugaProdusForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int currentUserId;

        public AdaugaProdusForm(int currentUserId)
        {
            InitializeComponent();
            Text = "Adauga Produs";
            this.currentUserId = currentUserId;

            PopuleazaComboBoxCategorii();
        }


        private void AdaugaProdusInBazaDeDate(string numeProdus, int pret, string um, int idCategorie)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                try
                {

                    if (ProdusExists(con, numeProdus))
                    {
                        MessageBox.Show("NU s-a putut adauga produsul. Produsul cu acest nume există deja în baza de date!");
                    }
                    else
                    {

                        string query = "INSERT INTO Produse (DenumireProdus, Pret, UM, IdCategorie) " +
                                       "VALUES (@DenumireProdus, @Pret, @UM, @IdCategorie)";

                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@DenumireProdus", numeProdus);
                            cmd.Parameters.AddWithValue("@Pret", pret);
                            cmd.Parameters.AddWithValue("@UM", um);
                            cmd.Parameters.AddWithValue("@IdCategorie", idCategorie);

                            con.Open(); 

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Produsul a fost adăugat cu succes!");
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

        private bool ProdusExists(OleDbConnection con, string numeProdus)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Produse WHERE DenumireProdus = @DenumireProdus";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DenumireProdus", numeProdus);

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



        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string numeProdus = txtNumeProdus.Text;
            string pretStr = txtPret.Text;
            string um = txtUM.Text;
            int idCategorie = Convert.ToInt32(cmbCategorie.SelectedValue);

            if (string.IsNullOrWhiteSpace(numeProdus))
            {
                MessageBox.Show("Completati numele produsului!");
                txtNumeProdus.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(pretStr) || !int.TryParse(pretStr, out int pret))
            {
                MessageBox.Show("Completati pretul produsului cu o valoare numerica valida!");
                txtPret.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(um))
            {
                MessageBox.Show("Completati unitatea de masura a produsului!");
                txtUM.Focus();
                return;
            }

            AdaugaProdusInBazaDeDate(numeProdus, pret, um, idCategorie);



        }


        private void PopuleazaComboBoxCategorii()
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "SELECT IdCategorie, DenumireCategorie FROM Categorie";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    con.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategorie.DisplayMember = "DenumireCategorie";
                    cmbCategorie.ValueMember = "IdCategorie";
                    cmbCategorie.DataSource = dt;
                }
            }
        }
    }

}
