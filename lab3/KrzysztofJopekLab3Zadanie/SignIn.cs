using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab3Zadanie
{
    class SignIn
    {
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);

        public SqlCommand QuerySql { get; set; }

        public  string Username { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        public SignIn(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public string getUsername()
        {
            return Username;
        }
        /// <summary>
        /// Sprawdzanie czy login i hasło jest w bazie
        /// <returns></returns>
        public bool SignInHospital()
        {
            int valueResult;
            bool isTrue = false;
            string query = "SELECT COUNT(UserLogin.UserName) FROM UserLogin WHERE UserName = @Username AND Password = @Password";
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username", Username));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                valueResult = (int) QuerySql.ExecuteScalar();
                
                if(valueResult >= 1)
                {
                    isTrue = true;
                }
            }
            return isTrue;
        }
    }
}
