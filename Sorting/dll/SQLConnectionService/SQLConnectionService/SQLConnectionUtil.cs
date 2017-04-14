using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SQLConnectionUtil
    {
        private SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=myDB;Integrated Security=True");
        private int[,] array2D;
        private SqlCommand command;
        private SqlDataReader reader;

        public int[,] Get2DArrayFromDB()
        {
            ReadTo2DArrayDataFromDB();
            return array2D;            
        }
        
        

        
        private void ReadTo2DArrayDataFromDB()
        {
            try
            {
                connection.Open();

                command = new SqlCommand("SELECT * from array_2d_input;", connection);                         

                int numberOfRows = GetNumberOfRows("array_2d_input");
                reader = command.ExecuteReader();   
                int numberOfColumns = reader.FieldCount;                
                array2D = new int[numberOfRows,numberOfColumns];
                
                int tmpCounterOfRows = 0;                
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        array2D[tmpCounterOfRows, i] = Convert.ToInt32(reader.GetValue(i));
                    }
                    tmpCounterOfRows++;
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //TODO: change logic of below method
        private int GetNumberOfRows(String nameOfTable)
        {
            reader = command.ExecuteReader();    
            int numberOfRows = 0;
            while (reader.Read())
            {
                numberOfRows++;
            }
            reader.Close();              
            return numberOfRows;            
        }
    }
}
