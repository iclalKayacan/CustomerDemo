using System.Data.SqlClient;

namespace customerDemo.Classes
{
    public class SqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-PUEU18AE;Initial Catalog=IlkProje;Integrated Security=True");

        public static void CheckConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {

            }

        }
    }
}
