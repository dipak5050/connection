using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Connection
{
    class Program
    {
        static void connection()
        {
            string cs = "Data Source =(LocalDb)MSSQLLocalDB;Initial Catalog =promptpan1;  Integrated Security = true;";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            if(con.State==System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Conneted");
            }
            con.Close();
        }
        static void Main(string[] args)
        {
            Program.connection();
            Console.ReadKey();
        }
    }
}
