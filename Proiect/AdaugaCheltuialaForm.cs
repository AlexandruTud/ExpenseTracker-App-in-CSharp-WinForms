using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect
{
    public partial class AdaugaCheltuialaForm : Form
    {
        private int currentUserId;

        public AdaugaCheltuialaForm(int currentUserId)
        {
            InitializeComponent();
            Text = "Adauga Cheltuiala";
            this.currentUserId = currentUserId;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            DateTime dataCheltuiala = dateTimePickerData.Value.Date;

            AdaugaCheltuialaInBazaDeDate(dataCheltuiala, currentUserId);

            MessageBox.Show("Cheltuiala a fost adaugată cu succes!");


            this.Close();
        }


        private void AdaugaCheltuialaInBazaDeDate(DateTime data, int idUtilizator)
        {

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Info III\\Proiect TAP\\Database.accdb"))
            {
                string query = "INSERT INTO Cheltuieli (Data, IdUtilizator) VALUES (@Data, @IdUtilizator)";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Data", data);
                    cmd.Parameters.AddWithValue("@IdUtilizator", idUtilizator);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
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
