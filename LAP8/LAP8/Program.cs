using Microsoft.Data.SqlClient;
using System.Data;

namespace LAP8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employee", "Data Source=.;Initial Catalog=Company;Integrated Security=True;Trust Server Certificate=True");

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Employee");

            DataTable dt = ds.Tables["Employee"];



            //--------------------------- Get ---------------------------

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["ID"]}, {row["Name"]}");
            }

            //--------------------------- Insert ---------------------------


            DataRow newRow = dt.NewRow();
            newRow["ID"] = 300;
            newRow["Name"] = "Sara";
            dt.Rows.Add(newRow);

            //--------------------------- Update ---------------------------

            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["ID"] == 2)
                {
                    row["Name"] = "nada";
                }
            }

            //--------------------------- Delete ---------------------------


            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["ID"] == 1)
                {
                    row.Delete();
                }
            }


            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Employee");

        }
    }
}
