using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ODBCconnect
{
    class Program
    {
        static void Main(string[] args)
        {


            // updateExcan();
            //createTableExcan();
           insertExcan();
            selectExcan();

            Console.ReadLine();
            deleteExcan();
            selectExcan();
        }
        public static void createTableExcan()
        {
            using (SqlConnection connection = new SqlConnection()) //using closes the connection automatically
            {
                connection.ConnectionString = @"Data Source= ADMIN\SQLEXPRESS;Integrated Security=SSPI;" + "Initial Catalog=CITI";
                connection.Open();
                /*Console.WriteLine("Entercode");
                string code = Console.ReadLine();
                Console.WriteLine("EnterName");
                string name = Console.ReadLine();*/
                string sql = $"CREATE TABLE EMPLOYEEX (EMPID VARCHAR(25) primary key, NAME VARCHAR(50), ADDRESS VARCHAR(100), AGE INT, PHONE VARCHAR(15), SALARY INT, DOB DATETIME2)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void selectExcan()
        {
            using (SqlConnection connection = new SqlConnection()) //using closes the connection automatically
            {
                connection.ConnectionString = @"Data Source= ADMIN\SQLEXPRESS;Integrated Security=SSPI;" + "Initial Catalog=Recruitment";
                connection.Open();
                string sql = "Select cCandidatecode,vfirstname From Externalcandidate";
                SqlCommand myCommand = new SqlCommand(sql, connection);
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        Console.WriteLine($"->Code: {myDataReader["cCandidatecode"]}, " + $"Name: {myDataReader["vfirstname"]}.");

                    }
                    Console.ReadLine();
                }
            }

        }
        public static void insertExcan()
        {
            using (SqlConnection connection = new SqlConnection()) //using closes the connection automatically
            {
                connection.ConnectionString = @"Data Source= ADMIN\SQLEXPRESS;Integrated Security=SSPI;" + "Initial Catalog=Recruitment";
                connection.Open();
                Console.WriteLine("Entercode");
                string code = Console.ReadLine();
                Console.WriteLine("EnterName");
                string name = Console.ReadLine();
                string sql = "Insert into Externalcandidate" + $"(cCandidatecode, vfirstname) " + $"Values ('{code}' , '{name}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void updateExcan()
        {
            using (SqlConnection connection = new SqlConnection()) //using closes the connection automatically
            {
                connection.ConnectionString = @"Data Source= ADMIN\SQLEXPRESS;Integrated Security=SSPI;" + "Initial Catalog=Recruitment";
                connection.Open();
                Console.WriteLine("Enter code for updation");
                string code = Console.ReadLine();
                Console.WriteLine("Enter new Name");
                string name = Console.ReadLine();
                string sql = "UPDATE Externalcandidate SET " + $"vfirstname=" + $"'{name}'" + " WHERE " + $"cCandidatecode=" + $"'{code}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void deleteExcan()
        {
            using (SqlConnection connection = new SqlConnection()) //using closes the connection automatically
            {
                connection.ConnectionString = @"Data Source= ADMIN\SQLEXPRESS;Integrated Security=SSPI;" + "Initial Catalog=Recruitment";
                connection.Open();
                Console.WriteLine("Enter code for deletion");
                string code = Console.ReadLine();
               
                string sql = "DELETE FROM Externalcandidate" + " WHERE " + $"cCandidatecode=" + $"'{code}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
