using Microsoft.Data.SqlClient;

namespace lap7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection sqlConnection= new SqlConnection("Data Source=.;Initial Catalog=Company;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand();

            //Get------------------------------------------
            command.Connection = sqlConnection;
            command.CommandText = "select ID,Name from Employee ";


            //List<Company> companies = new List<Company>();

            sqlConnection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read()) { 
                int id = (int) dataReader["ID"];
                string name = dataReader["Name"].ToString();
                Console.WriteLine($"{id} , {name}");
            
            
            }

            sqlConnection.Close();


            //insert----------------------------------------
            command.CommandText = "insert into Employee values (100,'Mohamed')";
            command.Connection = sqlConnection;
            sqlConnection.Open();
            int n = command.ExecuteNonQuery();
            Console.WriteLine(n);
            sqlConnection.Close();


            //delet------------------------------------------
            command.CommandText = "delet from Employee where ID=1";
            command.Connection = sqlConnection;
            sqlConnection.Open();
            int rowsDeleted = command.ExecuteNonQuery();
            Console.WriteLine(rowsDeleted);
            sqlConnection.Close();

            //Update---------------------------------------------

            command.CommandText = "update Employee set Name = 'Nada' where ID = 2";
            command.Connection = sqlConnection;
            sqlConnection.Open();
            int rowsUpdated = command.ExecuteNonQuery();
            Console.WriteLine(rowsUpdated);
            sqlConnection.Close();

        }
    }
}
