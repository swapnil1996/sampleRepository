using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FunWithAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with Data Adapters*********");
            string connectionString = "Integrated security=SSPI;Initial Catalog=Recruitment;" + @"Data source=ADMIN\SQLEXPRESS";
            DataSet ds = new DataSet("Recruitment");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from ExternalCandidate", connectionString);
            adapter.Fill(ds);
            printDataset(ds);
            Console.ReadLine();

        }
        static void printDataset(DataSet ds)

        {
            foreach(DataTable dt in ds.Tables)
            {
                Console.WriteLine($"=>{dt.TableName} Table:");

                for(int curCol = 0;curCol < dt.Columns.Count; curCol++)
                {
                    Console.Write(dt.Columns[curCol].ColumnName + "\t");

                }
                Console.WriteLine("\n---------------------------------------");
                for(int curRow = 0;curRow < dt.Rows.Count; curRow++)
                {
                    for(int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Console.WriteLine(dt.Rows[curRow][curCol].ToString().Trim() + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
