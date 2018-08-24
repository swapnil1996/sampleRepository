using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ems
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the no of employees whose data you want to store");
            //int n = int.Parse(Console.ReadLine());
            //Employee[] arr = new Employee[n];
            int i = 0;
            do
            {
                Console.WriteLine("Enter your choice: \n1. Enter Employee Details \n2. Display Employee \n3. Count of Employees\n 4. Exit");
                string ch = Console.ReadLine();
                int Flag = 0;
                switch (ch)
                {
                    case "1":
                        // arr[i++] = EnterEmp();
                        //if (Employee.getCount() >= n)
                        //  Console.WriteLine("You are entering more number of employees than specified\n");
                        //else
                        //{
                        Employee e = new Employee();
                        e.accept();
                        insertExcan(e);
                        //arr[i++] = e;

                        break;
                    case "2":
                       /* Console.WriteLine("Enter the empid of the emp to be displayed:");
                        string emp = Console.ReadLine();
                        int f = 0;
                        for (int j = 0; j < i; j++)
                        {
                            if (arr[j].getEmpid().Equals(emp))
                            {
                                f = 1;
                                DisplayEmp(arr[j]);
                                break;
                            }
                        }
                        if (f == 0)
                            Console.WriteLine("Not Found");*/
                        break;
                    case "3":
                        Console.WriteLine("The count of Employees: {0}", Employee.getCount());
                        break;
                    case "4":
                        Flag = 1;
                        break;
                }
            
                if (Flag == 1)
                    break;
            } while (true);
        }
        public static void insertExcan(Employee e)
        {
            using (SqlConnection connection = new SqlConnection()) //using closes the connection automatically
            {
                connection.ConnectionString = @"Data Source= ADMIN\SQLEXPRESS;Integrated Security=SSPI;" + "Initial Catalog=Recruitment";
                connection.Open();

                string sql = "Insert into EMPLOYEEX" + $"(EMPID,NAME,ADDRESS,AGE,PHONE,SALARY,DOB) " + $"Values ('{e.empid}' , '{e.name}','{e.address}','{e.age}','{e.salary},'{e.dt}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        
        /* static Employee EnterEmp()
         {
             Console.WriteLine("Enter empid");
             string empid = Console.ReadLine();
             Console.WriteLine("Enter name");
             string name = Console.ReadLine();
             Console.WriteLine("Enter address");
             string address = Console.ReadLine();
             Console.WriteLine("Enter age");
             int age = 0;
             try
             {
                 age = int.Parse(Console.ReadLine());
             }
             catch(Exception)
             {
                 Console.WriteLine("!!!Enter the age in the correct format plz!!!");
             }
             //bool a = int.TryParse(int.Parse(Console.ReadLine()), out age);
             Console.WriteLine("Enter salary");
             int salary = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter phone no");
             string phone = Console.ReadLine();
             Console.WriteLine("Enter DOB in format DD/MM/YYYY");
             DateTime dt = DateTime.Parse(Console.ReadLine());
             Employee e = new Employee(empid, name, address, age, phone , salary, dt);
             return e;

         }*/

        static void DisplayEmp(Employee e)
        {
            e.display();
        }
    }
}

    class Employee
    {
    
        public static int count = 0;
        public string empid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string phone { get; set; }
        public int salary { get; set; }
        public DateTime dt { get; set; }



    public Employee()
        {
            Console.WriteLine("Inside the Employee C");
            count++;
        }
        public Employee(string empid, string name)
        {
            this.empid = empid;
            this.name = name;
            count++;
        }
        /*public Employee(string empid,string name,string address, int age, string phone, int salary,DateTime dt)
        {
            this.empid = empid;
            this.name = name;
            this.address = address;
            this.age = age;
            this.phone = phone;
            this.salary = salary;
            this.dt = dt;
        }*/
        public static int getCount()
        {
            return count;
        }
        public void accept()
        {
        
            Console.WriteLine("Enter empid");
            empid = Console.ReadLine();
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter address");
            address = Console.ReadLine();
            Console.WriteLine("Enter age");
            //int age = 0;
            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("!!!Enter the age in the correct format plz!!!");
            }
            //bool a = int.TryParse(int.Parse(Console.ReadLine()), out age);
            Console.WriteLine("Enter salary");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone no");
            phone = Console.ReadLine();
            Console.WriteLine("Enter DOB in format DD/MM/YYYY");
            dt = DateTime.Parse(Console.ReadLine());
            //Employee e = new Employee(empid, name, address, age, phone, salary, dt);

        }
        /*public string getEmpid()
        {
            return empid;
        }*/
        public void display()
        {
            Console.WriteLine(" empid: {0}\n name: {1}\n address: {2}\n age: {3}\n phone:{4}\n salary:{5}\n DOB: {6}", empid, name, address, age, phone, salary, dt);
        }
    }

