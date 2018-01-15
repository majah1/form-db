using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ljudi2
{
    public class DatabaseBroker
    {
        SqlConnection conn;

        public DatabaseBroker()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Persons.mdf;Integrated Security=True");

           
        }

        public int Insert(string FirstName, string LastName, int Age)
        {

            conn.Open();
            SqlCommand sqlCommand = conn.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.CommandText = "INSERT into Employees ( FirstName, LastName, Age) VALUES ( @FirstName, @LastName, @Age)";
            sqlCommand.Parameters.AddWithValue("@FirstName", FirstName );
            sqlCommand.Parameters.AddWithValue("@LastName", LastName);
            sqlCommand.Parameters.AddWithValue("@Age",Age);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            conn.Close();
            return rowsAffected;

        }

        public List<Person> SelectAll()
        {

            conn.Open();
            SqlCommand sqlCommand = conn.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;

            SqlDataReader reader;
            sqlCommand.CommandText = "SELECT ID, LastName, FirstName, Age FROM Employees";
            reader = sqlCommand.ExecuteReader();

            List<Person> selektovanaLista = new List<Person>();

            while (reader.Read())
            {
                Person novaOsosba = new Person((int)(reader[3]), reader[1].ToString(), reader[2].ToString(), (int) (reader[0]));
                selektovanaLista.Add(novaOsosba);
            }
            
            conn.Close();

            return selektovanaLista;

        }

    }
}
