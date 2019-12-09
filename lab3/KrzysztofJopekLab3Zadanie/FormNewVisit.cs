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
using System.Windows;
using System.Windows.Forms;

namespace KrzysztofJopekLab3Zadanie
{
    public partial class FormNewVisit : Form
    {

        private readonly Func<SqlConnection> dbConnectionHospital = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);

        public SqlCommand QuerySql { get; set; }

        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public DateTime VisitDate { get; set; }

        List<string> doctors;
        List<string> patients;

        public FormNewVisit()
        {
            InitializeComponent();
            using (var connection = dbConnectionHospital())
            {
                //Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT DoctorName FROM Doctor;", connection))
                {
                    doctors = new List<string>();
                    //Wynik zapytania do tabeli.
                    DataSet dset = new DataSet();
                    adapter.Fill(dset);
                    DataTable dt = dset.Tables[0];
                    foreach (DataRow row in dt.Rows)
                    {
                        doctors.Add(row.Field<string>("DoctorName"));
                    }
                    // Do datagridview wrzucamy dane z tabeli
                    comboBoxDoctors.DataSource = doctors;
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Patient;", connection))
                {
                    patients = new List<string>();
                    //Wynik zapytania do tabeli.
                    DataSet dset = new DataSet();
                    adapter.Fill(dset);
                    DataTable dt = dset.Tables[0];
                    foreach (DataRow row in dt.Rows)
                    {
                        patients.Add(row.Field<string>("Name"));
                    }
                    // Do datagridview wrzucamy dane z tabeli
                    comboBoxPatients.DataSource = patients;
                }
            }


        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Visit (PatientId,DoctorId, VisitData) VALUES ( @PatientId , @DoctorId, @VisitData)";
            using (var connection = dbConnectionHospital())
            {
                connection.Open();
                SqlCommand QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@PatientId", comboBoxPatients.SelectedIndex + 1));
                QuerySql.Parameters.Add(new SqlParameter("@DoctorId", comboBoxDoctors.SelectedIndex + 1));
                QuerySql.Parameters.Add("@VisitData", SqlDbType.Date);
                QuerySql.Parameters["@VisitData"].Value = dateTimePickerVisit.Value;
                QuerySql.ExecuteNonQuery();
            }
            this.Close();
        }
    }
}
