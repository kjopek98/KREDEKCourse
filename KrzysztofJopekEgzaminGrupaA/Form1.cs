using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrzysztofJopekEgzaminGrupaA
{
    public partial class Logowanie : Form
    {

        private readonly Func<SqlConnection> dbConnectionNorthwind = () => new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString);

        public SqlCommand QuerySql { get; set; }

        /// <summary>
        /// Licznik błędnych zalogowań
        /// </summary>
        public int counter = 0;
        /// <summary>
        /// Licznik dla timera
        /// </summary>
        public int timerCounter = 0;
        public Logowanie()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przycisk do logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonA1Zaloguj_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == "admin" && textBoxPassword.Text == "test")
            {
                MessageBox.Show("zalogowano");
                counter = 0;
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło");
                counter++;
            }
            if (counter == 3)
            {
                textBoxLogin.Dispose();
                textBoxPassword.Dispose();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            labelTime.Text = timerCounter.ToString();
            if(timerCounter % 3 == 0)
            {
                buttonA1Zaloguj.Location = new Point(buttonA1Zaloguj.Location.X + 5, buttonA1Zaloguj.Location.Y - 5);

            }
        }
        /// <summary>
        /// Przycisk pokazujący pracowników których imię zaczyna się na "M"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonA3Pracownicy_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionNorthwind())
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employees WHERE FirstName LIKE 'M%' ", connection))
                {
                    //Wynik zapytania wrzucamy do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    // Do datagridview wrzucamy dane z tabeli
                    dataGridViewNorthwind.DataSource = table;
                }
            }
        }
        /// <summary>
        /// Przycisk uruchamiajacy timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonA2Start_Click(object sender, EventArgs e)
        {
            timer.Start();
            timer.Interval = 1000;
        }
        /// <summary>
        /// Przycisk wyświetlający produkty których cena jest pomiędzy 8 a 22
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonA5Produkty_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionNorthwind())
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products WHERE UnitPrice BETWEEN 8 AND 22 ORDER BY UnitPrice DESC ", connection))
                {
                    //Wynik zapytania wrzucamy do tabeli.
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    // Do datagridview wrzucamy dane z tabeli
                    dataGridViewNorthwind.DataSource = table;
                }
            }
        }
    }
}








/*string query = "INSERT INTO Shippers (CompanyName, Phone) VALUES ( @CompanyName, @Phone)";
                using (var connection = dbConnectionNorthwind())
                {
                    connection.Open();
                    SqlCommand QuerySql = new SqlCommand(query, connection);
QuerySql.Parameters.Add(new SqlParameter("@CompanyName", textBoxCompany.Text));
                    QuerySql.Parameters.Add(new SqlParameter("@Phone", textBoxPhone.Text));
                    QuerySql.ExecuteNonQuery();
                    MessageBox.Show("Dodano.");
                }*/