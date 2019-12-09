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

namespace KrzysztofJopekLab3Zadanie
{
    public partial class FormHospital : Form
    {
        /// <summary>
        /// Configuration Manager potrzebuje, aby dodad do referencji biblioteki System.Configuration
        /// </summary>
        private readonly Func<SqlConnection> dbConnectionHospital = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);

        public SqlCommand QuerySql { get; set; }

        public string VisitId { get; set; }
        public FormHospital()
        {
            InitializeComponent();
            GetDataFromTable();
        }
        /// <summary>
        /// Metoda połączy dane z datagridview
        /// </summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionHospital())
            {
                //Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Wizyty_VIEW", connection))
                {
                    //Wynik zapytania do tabeli.
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    // Do datagridview wrzucamy dane z tabeli
                    dataGridViewWarehouse.DataSource = table;
                }
            }
        }
        /// <summary>
        /// Filtrowanie wizyt po specjalności "Okulista"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOkulista_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionHospital())
            {
                //Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Wizyty_VIEW WHERE SpecializationName = 'Okulista' ", connection))
                {
                    //Wynik zapytania do tabeli.
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    // Do datagridview wrzucamy dane z tabeli
                    dataGridViewWarehouse.DataSource = table;
                }
            }
        }
        /// <summary>
        /// Filtrowanie wizyt po specjalności "Psychiatra"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPsychiatra_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionHospital())
            {
                //Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Wizyty_VIEW WHERE SpecializationName = 'Psychiatra' ", connection))
                {
                    //Wynik zapytania do tabeli.
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    // Do datagridview wrzucamy dane z tabeli
                    dataGridViewWarehouse.DataSource = table;
                }
            }
        }

        /// <summary>
        /// Filtrowanie wizyt po specjalności "Ginekolog"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGinekolog_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionHospital())
            {
                //Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Wizyty_VIEW WHERE SpecializationName = 'Ginekolog' ", connection))
                {
                    //Wynik zapytania do tabeli.
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    // Do datagridview wrzucamy dane z tabeli
                    dataGridViewWarehouse.DataSource = table;
                }
            }
        }
        /// <summary>
        /// Przycisk usuwający z aplikacji i z bazy zaznaczone wizyty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveRow_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Visit WHERE VisitId= @VisitId";
            using (var connection = dbConnectionHospital())
            {
                //Połączenia


                if (MessageBox.Show("Sure you wanna delete?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dataGridViewWarehouse.SelectedRows)
                    {
                        VisitId = item.Cells[0].Value.ToString();
                        connection.Open();
                        QuerySql = new SqlCommand(query, connection);
                        QuerySql.Parameters.Add(new SqlParameter("@VisitId", VisitId));
                        QuerySql.ExecuteNonQuery();
                        dataGridViewWarehouse.Rows.RemoveAt(item.Index);
                        connection.Close();
                    }
                }
            }
        }
        /// <summary>
        /// Przycisk otwierający okienko do zamówienia nowej wizyty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNewRow_Click(object sender, EventArgs e)
        {
            FormNewVisit newVisit = new FormNewVisit();
            newVisit.Show();
        }
        /// <summary>
        /// Przycisk pokazujący listę dostępnych lekarzy w przychodni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowDoctors_Click(object sender, EventArgs e)
        {
            FormDoctors formDoctors = new FormDoctors();
            formDoctors.Show();
        }
        /// <summary>
        /// Przycisk odświeżający listę po zmianach (usuwanie, dodawanie)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetDataFromTable();
        }
    }
}
