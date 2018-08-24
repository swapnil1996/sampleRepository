using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkClassDemo
{
    class Program
    {
       
        private static void PrintAllInventory()
        {
            using (var context = new EF.Model1())
            {
                foreach (EF.Department c in context.Departments.SqlQuery("Select * from department"))
                    Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            PrintAllInventory();
            Console.ReadLine();
        }
    }
    
}
