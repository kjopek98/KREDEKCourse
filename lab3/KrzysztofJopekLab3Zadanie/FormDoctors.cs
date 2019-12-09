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
    public partial class FormDoctors : Form
    {
        private readonly Func<SqlConnection> dbConnectionHospital = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        
        public FormDoctors()
        {
            InitializeComponent();
            GetDataFromTable();
        }
        /// <summary>
        /// Wyświetlanie w dataGridView dostępnych lekarzy w przychodni
        /// </summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionHospital())
            {
                //Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DoctorsView", connection))
                {
                    //Wynik zapytania do tabeli.
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    // Do datagridview wrzucamy dane z tabeli
                    dataGridViewDoctors.DataSource = table;
                }
            }
        }
    }
}
