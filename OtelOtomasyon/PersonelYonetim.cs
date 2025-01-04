using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class PersonelYonetim : Form
    {
        private string connectionString = @"Server=MSI;Database=OtelOtomasyonu;Trusted_Connection=True;";

        public PersonelYonetim()
        {
            InitializeComponent();
            LoadPersonelData(); // Load the existing personnel data when the form opens
        }

        // Method to load and display personnel data
        private void LoadPersonelData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                    SELECT TOP (1000) [PersonelID], [Ad], [Soyad], [Pozisyon], [Maas], [Parola]
                    FROM [Personeller]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt; // Bind the data to the DataGridView
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.AllowUserToResizeColumns = false;
                    dgv.AllowUserToAddRows = false;
                    dgv.AllowUserToDeleteRows = false;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.RowHeadersVisible = false;
                    dgv.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel verileri yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        // Method to insert new personnel data
        private void AddPersonel(string ad, string soyad, string pozisyon, decimal maas, string parola)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                    INSERT INTO [Personeller] ([Ad], [Soyad], [Pozisyon], [Maas], [Parola])
                    VALUES (@Ad, @Soyad, @Pozisyon, @Maas, @Parola)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Pozisyon", pozisyon);
                    command.Parameters.AddWithValue("@Maas", maas);
                    command.Parameters.AddWithValue("@Parola", parola);

                    connection.Open();
                    command.ExecuteNonQuery(); // Execute the insert query
                    MessageBox.Show("Personel başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        // Button click handler for adding a new employee
        private void kayitBut_Click(object sender, EventArgs e)
        {
            string ad = adBox.Text;
            string soyad = soyadBox.Text;
            string pozisyon = pozisyonBox.Text;
            decimal maas = decimal.Parse(maasBox.Text);
            string parola = parolaBox.Text;

            // Add new personnel to the database
            AddPersonel(ad, soyad, pozisyon, maas, parola);

            // Reload the DataGridView with updated data
            LoadPersonelData();

            // Clear the input fields
            adBox.Clear();
            soyadBox.Clear();
            pozisyonBox.Clear();
            maasBox.Clear();
            parolaBox.Clear();
        }

        // Back button click handler to navigate to the previous form
        private void geriBut_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Close();
            giris.Show();
        }
    }
}
