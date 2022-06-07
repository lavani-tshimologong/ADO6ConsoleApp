using System.Data.SqlClient;
namespace AccessLayer
{
    public class Access
    {
        // method grabs string input
        //create a method that would connect to the database
        public static void Connect(string connectionString)
        {
            //create connection
            SqlConnection con = new SqlConnection(connectionString);
          



            //create query that writes to database
            string sql = "Insert Into Department( Dept_Name, Dept_Location) values ('Finance', 'Fourth Floor')";
            
            //open connection
            con.Open();

            //create a sql command referencing the connection
            SqlCommand cmd = new SqlCommand(sql, con);
            
        


            cmd.ExecuteNonQuery();

            //close connection
            con.Close();

            //open connection
            con.Open();
            //create query that reads from database
            string sql2 = "SELECT * FROM Department";
            //create a sql command referencing the connection
            SqlCommand cmd2 = new SqlCommand(sql2, con);

            //create sql data reader
            SqlDataReader dataReader = cmd2.ExecuteReader();

            //while its reading
            while (dataReader.Read())
            {
                
                 //write to console
                
                var Dept_ID = dataReader.GetInt32(0);
                var Dept_Name = dataReader["Dept_Name"].ToString();
                var Location = dataReader["Dept_Location"].ToString();


                Console.WriteLine(Dept_ID + " " + Dept_Name + " " + Location);


            }
            //close connection
            con.Close();
            //dispose of connection
            con.Dispose();




        }
    }
}