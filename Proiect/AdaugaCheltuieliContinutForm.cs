using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect
{
    public partial class AdaugaCheltuieliContinutForm : Form
    {
        private int currentUserId;

        public AdaugaCheltuieliContinutForm(int currentUserId)
        {
            InitializeComponent();
            Text = "Adauga Cheltuiala Continut";
            this.currentUserId = currentUserId;

            LoadDataIntoComboBoxes();
            LoadComboBoxProduse();
            LoadComboBoxCheltuieli();
        }

        private bool ValidateInputs()
        {
            // Validare pentru preț
            if (!int.TryParse(textBoxPret.Text, out int pret) || pret < 0)
            {
                MessageBox.Show("Te rog să introduci un preț valid (o valoare numerică pozitivă).");
                return false;
            }

            // Validare pentru cantitate
            if (!int.TryParse(textBoxCantitate.Text, out int cantitate) || cantitate <= 0)
            {
                MessageBox.Show("Te rog să introduci o cantitate validă (o valoare numerică pozitivă mai mare decât zero).");
                return false;
            }

            return true;
        }

        private void LoadDataIntoComboBoxes()
        {
            List<int> produsIds = GetProdusIds();
            foreach (int produsId in produsIds)
            {
                comboboxProdus.Items.Add(produsId);
            }

            List<int> cheltuialaIds = GetCheltuialaIds();
            foreach (int cheltuialaId in cheltuialaIds)
            {
                comboboxCheltuiala.Items.Add(cheltuialaId);
            }

        }

        private void LoadComboBoxProduse()
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "SELECT IdProdus, DenumireProdus FROM Produse";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboboxProdus.DisplayMember = "DenumireProdus";
                        comboboxProdus.ValueMember = "IdProdus";

                        // Actualizează sursa de date a combobox-ului
                        comboboxProdus.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la încărcarea produselor în combobox: " + ex.Message);
                    }
                }
            }
        }

        private void LoadComboBoxCheltuieli()
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                // Modificați interogarea SQL pentru a selecta doar cheltuielile asociate utilizatorului curent
                string query = "SELECT IdCheltuiala, Data FROM Cheltuieli WHERE IdUtilizator = @IdUtilizator";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdUtilizator", currentUserId);

                    try
                    {
                        con.Open();

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboboxCheltuiala.DisplayMember = "Data";
                        comboboxCheltuiala.ValueMember = "IdCheltuiala";

                        comboboxCheltuiala.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la încărcarea cheltuielilor în combobox: " + ex.Message);
                    }
                }
            }
        }



        private List<int> GetProdusIds()
        {
            List<int> produsIds = new List<int>();

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "SELECT IdProdus FROM Produse";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            produsIds.Add(reader.GetInt32(0));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la obținerea datelor pentru combobox Produs: " + ex.Message);
                    }
                }
            }

            return produsIds;
        }

        private List<int> GetCheltuialaIds()
        {
            List<int> cheltuialaIds = new List<int>();

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "SELECT IdCheltuiala FROM Cheltuieli";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            cheltuialaIds.Add(reader.GetInt32(0));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la obținerea datelor pentru combobox Cheltuiala: " + ex.Message);
                    }
                }
            }

            return cheltuialaIds;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {

            if (!ValidateInputs())
            {
                return;
            }

            int idProdus = (int)comboboxProdus.SelectedValue;
            int pret = int.Parse(textBoxPret.Text); 
            int cantitate = int.Parse(textBoxCantitate.Text);
            int idCheltuiala = (int)comboboxCheltuiala.SelectedValue;

            AdaugaCheltuialaContinutInBazaDeDate(idProdus, pret, cantitate, idCheltuiala, currentUserId);


        }

        private void AdaugaCheltuialaContinutInBazaDeDate(int idProdus, int pret, int cantitate, int idCheltuiala, int idUtilizator)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "INSERT INTO CheltuieliContinut (IdProdus, Pret, Cantitate, IdCheltuiala, IdUtilizator) " +
                               "VALUES (@IdProdus, @Pret, @Cantitate, @IdCheltuiala, @IdUtilizator)";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdProdus", idProdus);
                    cmd.Parameters.AddWithValue("@Pret", pret);
                    cmd.Parameters.AddWithValue("@Cantitate", cantitate);
                    cmd.Parameters.AddWithValue("@IdCheltuiala", idCheltuiala);
                    cmd.Parameters.AddWithValue("@IdUtilizator", idUtilizator);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cheltuiala Continut a fost adăugată cu succes!");
                        this.Close(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la adăugarea cheltuielii: " + ex.Message);
                    }
                }
            }
        }

    }
}
