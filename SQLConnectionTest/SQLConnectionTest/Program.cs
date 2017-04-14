using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConnectionTest
{
    class Program
    {        
        static void Main(string[] args)
        {            
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=myDB;Integrated Security=True");
           
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * from array_2d_input ", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("Table column number: {0}", reader.FieldCount);
                Console.WriteLine("Name of columns:");

                for (int i = 0; i < reader.FieldCount; i ++)
                {
                    Console.WriteLine(reader.GetName(i));
                }

                while (reader.Read())
                {
                    Console.WriteLine("Val1: {0}, Val2: {1}", reader.GetInt32(0), reader.GetInt32(9));
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                       
            Console.ReadKey();
        }
    }
}
