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
    public partial class Form2 : Form
    {
        private Form1 parentForm; // Adaugă o referință către Form1
        private int currentUserId;
        private DataGridViewComboBoxColumn colDenumireProdus;
        private DataGridViewComboBoxColumn colData;

        public Form2(Form1 parentForm, int currentUserId)
        {
            InitializeComponent();
            Text = "Bun venit!";
            dataGridViewProduse.Visible = false;
            dataGridViewCategorii.Visible = false;
            dataGridViewCheltuieli.Visible = false;
            dataGridViewCheltuieliContinut.Visible = false;
            lblHello.Visible = true;
            pictureBox1.Visible = false;
            btnAdaugaProdus.Visible = false;
            btnAdaugaCategorie.Visible = false;
            btnAdaugaCheltuiala.Visible = false;
            btnAdaugaCheltuieliContinut.Visible = false;
            btnSalvareCheltuieli.Visible = false;
            btnAnulareCheltuieli.Visible = false;
            btnModificareCheltuiala.Visible = false;
            dataGridViewCheltuieli.ReadOnly = true;
            lblConfirmare.Visible = false;
            btnSalvareCheltuieliContinut.Visible = false;
            btnAnulareCheltuieliContinut.Visible = false;
            btnModificareCheltuialaContinut.Visible = false;
            btnStergeCheltuiala.Visible = false;
            lblAlege.Visible = false;
            comboBoxCheltuieli.Visible = false;

            this.parentForm = parentForm;
            this.currentUserId = currentUserId;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CheltuieliContinut' table. You can move, or remove it, as needed.
            this.cheltuieliContinutTableAdapter.Fill(this.dataSet1.CheltuieliContinut);
            // TODO: This line of code loads data into the 'dataSet1.Cheltuieli' table. You can move, or remove it, as needed.
            this.cheltuieliTableAdapter.Fill(this.dataSet1.Cheltuieli);
            // TODO: This line of code loads data into the 'dataSet1.Categorie' table. You can move, or remove it, as needed.
            this.categorieTableAdapter.Fill(this.dataSet1.Categorie);
            // TODO: This line of code loads data into the 'dataSet1.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataSet1.Produse);

            string currentUserName = GetCurrentUserName();
            lblHello.Text = $"Bun venit, {currentUserName}!";


            DataGridViewComboBoxColumn colDenumireCategorie = new DataGridViewComboBoxColumn();
            colDenumireCategorie.HeaderText = "Denumire Categorie";
            colDenumireCategorie.DataPropertyName = "IdCategorie";
            colDenumireCategorie.DataSource = dataSet1;
            colDenumireCategorie.DisplayMember = "Categorie.DenumireCategorie";
            colDenumireCategorie.ValueMember = "Categorie.IdCategorie";
            dataGridViewProduse.Columns.Add(colDenumireCategorie);

            colDenumireCategorie.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            colDenumireCategorie.DisplayStyleForCurrentCellOnly = true;

            SetupDataGridViewCheltuieliContinut();
            SetupDataaGridViewCheltuieliContinut();

        }


        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewProduse.Visible = true;
            dataGridViewCategorii.Visible = false;
            dataGridViewCheltuieli.Visible = false;
            dataGridViewCheltuieliContinut.Visible = false;
            lblHello.Visible = false;
            pictureBox1.Visible = true;
            btnAdaugaProdus.Visible = true;
            btnAdaugaCategorie.Visible = false;
            btnAdaugaCheltuiala.Visible = false;
            btnAdaugaCheltuieliContinut.Visible = false;
            btnSalvareCheltuieli.Visible = false;
            btnAnulareCheltuieli.Visible = false;
            btnModificareCheltuiala.Visible = false;
            btnSalvareCheltuieliContinut.Visible = false;
            btnAnulareCheltuieliContinut.Visible = false;
            btnModificareCheltuialaContinut.Visible = false;
            btnModificareCheltuiala.Enabled = true;
            btnModificareCheltuialaContinut.Enabled = true;
            btnStergeCheltuiala.Visible = false;
            lblAlege.Visible = false;
            comboBoxCheltuieli.Visible = false;
            LoadDataGridViewProduse();
        }

        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewProduse.Visible = false;
            dataGridViewCategorii.Visible = true;
            dataGridViewCheltuieli.Visible = false;
            dataGridViewCheltuieliContinut.Visible = false;
            lblHello.Visible = false;
            pictureBox1.Visible = false;
            btnAdaugaProdus.Visible = false;
            btnAdaugaCategorie.Visible = true;
            btnAdaugaCheltuiala.Visible = false;
            btnAdaugaCheltuieliContinut.Visible = false;
            btnSalvareCheltuieli.Visible = false;
            btnAnulareCheltuieli.Visible = false;
            btnModificareCheltuiala.Visible = false;
            btnSalvareCheltuieliContinut.Visible = false;
            btnAnulareCheltuieliContinut.Visible = false;
            btnModificareCheltuialaContinut.Visible = false;
            btnModificareCheltuialaContinut.Enabled = true;
            btnModificareCheltuiala.Enabled = true;
            btnStergeCheltuiala.Visible = false;
            lblAlege.Visible = false;
            comboBoxCheltuieli.Visible = false;
            LoadDataGridViewCategorii();
        }

        private void cheltuieliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewProduse.Visible = false;
            dataGridViewCategorii.Visible = false;
            dataGridViewCheltuieli.Visible = true;
            dataGridViewCheltuieliContinut.Visible = false;
            lblHello.Visible = false;
            pictureBox1.Visible = false;
            btnAdaugaProdus.Visible = false;
            btnAdaugaCategorie.Visible = false;
            btnAdaugaCheltuiala.Visible = true;
            btnAdaugaCheltuieliContinut.Visible = false;
            btnSalvareCheltuieli.Visible = false;
            btnAnulareCheltuieli.Visible = false;
            btnModificareCheltuiala.Visible = true;
            btnSalvareCheltuieliContinut.Visible = false;
            btnAnulareCheltuieliContinut.Visible = false;
            btnModificareCheltuialaContinut.Visible = false;
            btnModificareCheltuiala.Enabled = true;
            btnModificareCheltuialaContinut.Enabled = true;
            btnStergeCheltuiala.Visible = false;
            lblAlege.Visible = false;
            comboBoxCheltuieli.Visible = false;
            UpdateCheltuieliForCurrentUser();
        }

        private void cheltuieliContinutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewProduse.Visible = false;
            dataGridViewCategorii.Visible = false;
            dataGridViewCheltuieli.Visible = false;
            dataGridViewCheltuieliContinut.Visible = true;
            lblHello.Visible = false;
            pictureBox1.Visible = false;
            btnAdaugaProdus.Visible = false;
            btnAdaugaCategorie.Visible = false;
            btnAdaugaCheltuiala.Visible = false;
            btnAdaugaCheltuieliContinut.Visible = true;
            btnSalvareCheltuieli.Visible = false;
            btnAnulareCheltuieli.Visible = false;
            btnModificareCheltuiala.Visible = false;
            btnSalvareCheltuieliContinut.Visible = false;
            btnAnulareCheltuieliContinut.Visible = false;
            btnModificareCheltuialaContinut.Visible = true;
            btnModificareCheltuiala.Enabled = true;
            btnModificareCheltuialaContinut.Enabled = true;
            btnStergeCheltuiala.Visible = false;
            lblAlege.Visible = false;
            comboBoxCheltuieli.Visible = false;
            UpdateCheltuieliContinutForCurrentUser();
            this.cheltuieliContinutTableAdapter.Update(this.dataSet1.CheltuieliContinut);

            dataGridViewCheltuieliContinut.Refresh();
            LoadDataGridViewCheltuieliContinut();
        }


        // GET CURRENT USER NAME
        private string GetCurrentUserName()
        {
            string userName = "";

            using (OleDbConnection con = new OleDbConnection())
            {
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb";

                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT Nume FROM Utilizatori WHERE IdUtilizator = @UserId";
                    cmd.Parameters.AddWithValue("@UserId", currentUserId);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            userName = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la obținerea numelui utilizatorului: " + ex.Message);
                    }
                }
            }

            return userName;
        }


        // UPDATE URI
        private void UpdateCheltuieliForCurrentUser()
        {
            DataView dv = new DataView(dataSet1.Cheltuieli);
            dv.RowFilter = $"IdUtilizator = {currentUserId}";

            comboBoxCheltuieli.DataSource = dv;
            comboBoxCheltuieli.DisplayMember = "Data";
            comboBoxCheltuieli.ValueMember = "IdCheltuiala";
            comboBoxCheltuieli.SelectedIndex = -1;

            dataGridViewCheltuieli.DataSource = dv;

            LoadDataGridViewCheltuieli();
        }



        private void UpdateCheltuieliContinutForCurrentUser()
        {
            DataView dv = new DataView(dataSet1.CheltuieliContinut);
            dv.RowFilter = $"IdUtilizator = {currentUserId}";

            dataGridViewCheltuieliContinut.DataSource = dv;
            LoadComboBoxData();
        }


        // LOAD URI
        private void LoadDataGridViewCheltuieli()
        {
            this.cheltuieliTableAdapter.Fill(this.dataSet1.Cheltuieli);
        }

        public void LoadDataGridViewProduse()
        {
            this.produseTableAdapter.Fill(this.dataSet1.Produse);
        }

        private void LoadDataGridViewCategorii()
        {
            this.categorieTableAdapter.Fill(this.dataSet1.Categorie);


        }

        private void LoadDataGridViewCheltuieliContinut()
        {
            this.cheltuieliContinutTableAdapter.Fill(this.dataSet1.CheltuieliContinut);

        }


        // BTN ADAUGA
        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            AdaugaProdusForm adaugaProdusForm = new AdaugaProdusForm(currentUserId);
            adaugaProdusForm.ShowDialog();
            LoadDataGridViewProduse();
        }

        private void btnAdaugaCheltuiala_Click(object sender, EventArgs e)
        {
            AdaugaCheltuialaForm adaugaCheltuialaForm = new AdaugaCheltuialaForm(currentUserId);
            adaugaCheltuialaForm.ShowDialog();
            UpdateCheltuieliForCurrentUser();
            LoadDataGridViewCheltuieli();

        }

        private void btnAdaugaCategorie_Click(object sender, EventArgs e)
        {
            AdaugaCategorieForm adaugaCategorieForm = new AdaugaCategorieForm(currentUserId);
            adaugaCategorieForm.ShowDialog();
            LoadDataGridViewCategorii();
        }

        private void btnAdaugaCheltuieliContinut_Click(object sender, EventArgs e)
        {
            AdaugaCheltuieliContinutForm adaugaCheltuieliContinutForm = new AdaugaCheltuieliContinutForm(currentUserId);
            adaugaCheltuieliContinutForm.ShowDialog();
            UpdateCheltuieliContinutForCurrentUser();
            LoadDataGridViewCheltuieliContinut();

        }


        // BTN MODIFICARE
        private void btnModificareCheltuiala_Click(object sender, EventArgs e)
        {
            dataGridViewCheltuieli.ReadOnly = false;
            dataGridViewCheltuieli.AllowUserToAddRows = true;
            dataGridViewCheltuieli.AllowUserToDeleteRows = true;

            btnSalvareCheltuieli.Visible = true;
            btnAnulareCheltuieli.Visible = true;
            btnModificareCheltuiala.Enabled = false;
            lblConfirmare.Visible = true;
            btnStergeCheltuiala.Visible = true;
            lblAlege.Visible = true;
            comboBoxCheltuieli.Visible = true;

            
        }

        private void btnModificareCheltuialaContinut_Click(object sender, EventArgs e)
        {
            dataGridViewCheltuieliContinut.ReadOnly = false;
            dataGridViewCheltuieliContinut.AllowUserToAddRows = true;
            dataGridViewCheltuieliContinut.AllowUserToDeleteRows = true;

            btnSalvareCheltuieliContinut.Visible = true;
            btnAnulareCheltuieliContinut.Visible = true;
            btnModificareCheltuialaContinut.Enabled = false;
            lblConfirmare.Visible = true;

            foreach (DataGridViewColumn column in dataGridViewCheltuieliContinut.Columns)
            {
                if (column.DataPropertyName == "DenumireCheltuiala" || column.DataPropertyName == "Data")
                {
                    column.ReadOnly = false;
                }
            }

        }


        // BTN ANULARE
        private void btnAnulareCheltuieli_Click(object sender, EventArgs e)
        {
            this.dataSet1.RejectChanges();

            dataGridViewCheltuieli.CancelEdit();
            dataGridViewCheltuieli.ReadOnly = true;

            btnSalvareCheltuieli.Visible = false;
            btnAnulareCheltuieli.Visible = false;
            btnModificareCheltuiala.Enabled = true;
            lblConfirmare.Visible = false;
            btnStergeCheltuiala.Visible = false;
            lblAlege.Visible = false;
            comboBoxCheltuieli.Visible = false;
        }

        private void btnAnulareCheltuieliContinut_Click(object sender, EventArgs e)
        {
            this.dataSet1.RejectChanges();

            dataGridViewCheltuieliContinut.CancelEdit();
            dataGridViewCheltuieliContinut.ReadOnly = true;

            btnSalvareCheltuieliContinut.Visible = false;
            btnAnulareCheltuieliContinut.Visible = false;
            btnModificareCheltuialaContinut.Enabled = true;
            lblConfirmare.Visible = false;

        }


        // BTN SALVARE
        private void btnSalvareCheltuieli_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ești sigur că vrei să salvezi modificările?", "Validare",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Validate();
                this.cheltuieliBindingSource.EndEdit();
                this.cheltuieliTableAdapter.Update(this.dataSet1.Cheltuieli);
                UpdateCheltuieliContinutForCurrentUser();
                LoadDataGridViewCheltuieliContinut();
                cheltuieliContinutTableAdapter.Update(dataSet1.CheltuieliContinut);


                dataGridViewCheltuieliContinut.Refresh();
                dataGridViewCheltuieli.Refresh();
            }
            else
            {
                this.dataSet1.RejectChanges();
            }

            dataGridViewCheltuieli.EndEdit();
            dataGridViewCheltuieli.ReadOnly = true;

            btnSalvareCheltuieli.Visible = false;
            btnAnulareCheltuieli.Visible = false;
            btnModificareCheltuiala.Enabled = true;
            lblConfirmare.Visible = false;
            btnStergeCheltuiala.Visible = false;
            lblAlege.Visible = false;
            comboBoxCheltuieli.Visible = false;
        }

        private void btnSalvareCheltuieliContinut_Click(object sender, EventArgs e)
        {
                        DialogResult result = MessageBox.Show("Ești sigur că vrei să salvezi modificările?", "Validare",
                                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Validate();
                this.cheltuieliContinutBindingSource.EndEdit();
                this.cheltuieliContinutTableAdapter.Update(this.dataSet1.CheltuieliContinut);

                dataGridViewCheltuieliContinut.Refresh();
            }
            else
            {
                this.dataSet1.RejectChanges();
            }

            dataGridViewCheltuieliContinut.EndEdit();
            dataGridViewCheltuieliContinut.ReadOnly = true;

            btnSalvareCheltuieliContinut.Visible = false;
            btnAnulareCheltuieliContinut.Visible = false;
            btnModificareCheltuialaContinut.Enabled = true;
            lblConfirmare.Visible = false;

        }

        // COLOANELE DENUMIRE PRODUS SI DATA SUNT READONLY
        private void dataGridViewCheltuieliContinut_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colDenumireProdus.Index) 
            {
                dataGridViewCheltuieliContinut.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
            }

            if (e.ColumnIndex == colData.Index)
            {
                dataGridViewCheltuieliContinut.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
            }
        }


        // SETAM COLOANELE DENUMIRE PRODUS SI DATA
        private void SetupDataGridViewCheltuieliContinut()
        {

            colDenumireProdus = new DataGridViewComboBoxColumn();
            colDenumireProdus.HeaderText = "Denumire Produs";
            colDenumireProdus.DataPropertyName = "IdProdus"; 
            colDenumireProdus.DataSource = GetProduseDataTable();
            colDenumireProdus.DisplayMember = "DenumireProdus";
            colDenumireProdus.ValueMember = "IdProdus";
            dataGridViewCheltuieliContinut.Columns.Add(colDenumireProdus);

            colDenumireProdus.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            colDenumireProdus.DisplayStyleForCurrentCellOnly = true;


        }

        private void SetupDataaGridViewCheltuieliContinut()
        {
            colData = new DataGridViewComboBoxColumn();
            colData.HeaderText = "Data";
            colData.DataPropertyName = "IdCheltuiala";
            colData.DataSource = GetDataCheltuieliDataTable();
            colData.DisplayMember = "Data";
            colData.ValueMember = "IdCheltuiala";

            colData.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            colData.DisplayStyleForCurrentCellOnly = true;

            dataGridViewCheltuieliContinut.Columns.Add(colData);

        }

        private void LoadComboBoxData()
        {

            colDenumireProdus.DataSource = GetProduseDataTable();
            colDenumireProdus.DisplayMember = "DenumireProdus";
            colDenumireProdus.ValueMember = "IdProdus";

            colData.DataSource = GetDataCheltuieliDataTable();
            colData.DisplayMember = "Data";
            colData.ValueMember = "IdCheltuiala";
        }


        // GET LA PRODUSE
        private DataTable GetProduseDataTable()
        {
            DataTable dataTable = new DataTable();

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "SELECT IdProdus, DenumireProdus FROM Produse";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdUtilizator", currentUserId);

                    try
                    {
                        con.Open();

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        adapter.Fill(dataTable);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la încărcarea produselor în combobox: " + ex.Message);
                    }
                }
            }

            return dataTable;
        }

        // GET LA DATA CHELTUIELI
        private DataTable GetDataCheltuieliDataTable()
        {
            DataTable dataTable = new DataTable();

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "SELECT IdCheltuiala, Data FROM Cheltuieli WHERE IdUtilizator = @IdUtilizator";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdUtilizator", currentUserId);
                    try
                    {
                        con.Open();

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        adapter.Fill(dataTable);

                        colData.DisplayMember = "Data";
                        colData.ValueMember = "IdCheltuiala";

                        colData.DataSource = dataTable;

                        DataColumn dataColumn = dataTable.Columns["Data"];
                        if (dataColumn != null)
                        {
                            Console.WriteLine($"Tip de date pentru coloana 'Data': {dataColumn.DataType}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la încărcarea datelor de cheltuieli în combobox: " + ex.Message);
                    }
                }
            }

            return dataTable;
        }


        // VALIDARE PENTRU CHELTUIELI
        private bool CheltuialaHasContinut(int idCheltuiala)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "SELECT COUNT(*) FROM CheltuieliContinut WHERE IdCheltuiala = @IdCheltuiala";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdCheltuiala", idCheltuiala);

                    try
                    {
                        con.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la verificarea conținutului cheltuielii: " + ex.Message);
                        return true;
                    }
                }
            }
        }

        private void DeleteCheltuiala(int idCheltuiala)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "DELETE FROM Cheltuieli WHERE IdCheltuiala = @IdCheltuiala";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdCheltuiala", idCheltuiala);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        this.cheltuieliTableAdapter.Fill(this.dataSet1.Cheltuieli);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la ștergerea cheltuielii: " + ex.Message);
                    }
                }
            }
        }


        private void btnStergeCheltuiala_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idCheltuialaToDelete;

                if (comboBoxCheltuieli.SelectedValue != null && int.TryParse(comboBoxCheltuieli.SelectedValue.ToString(), out idCheltuialaToDelete))
                {
                    if (CheltuialaHasContinut(idCheltuialaToDelete))
                    {
                        MessageBox.Show("Nu se poate șterge cheltuiala pentru că are conținut înregistrat în tabelul CheltuieliContinut.");
                        return;
                    }

                    DialogResult result = MessageBox.Show("Ești sigur că vrei să ștergi cheltuiala? O data de apesi YES , cheltuiala se va sterge!", "Confirmare ștergere",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteCheltuiala(idCheltuialaToDelete);
                        UpdateCheltuieliForCurrentUser();

                        if (dataSet1.HasChanges())
                        {
                            dataSet1.AcceptChanges();
                        }

                        dataGridViewCheltuieli.Refresh(); 
                    }
                }
                else
                {
                    MessageBox.Show("Selectați o cheltuială pentru a o șterge.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergerea cheltuielii: " + ex.Message);
            }
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }
    }

}
