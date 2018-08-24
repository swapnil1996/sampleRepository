using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Delegates are pointer to functions.
 * used when we want to execute multiple functions
 * we hve to ensure that the signatures match
 * only final value returned
 * bundling of functions
 * Can be used for anonymous functions
 */
namespace @delegate
{
    class Program
    {
        delegate int del(int i);
        static void Main(string[] args)
        {

            del mydelegate = y => { Console.WriteLine("Hello"); return y* y; }; //lambda functions
            mydelegate += square;
            mydelegate += add;

            mydelegate += delegate (int x)
            { Console.WriteLine("Anonymous function"); return x * x; };

            int j = mydelegate(5);
            Console.WriteLine(j);
            Console.ReadLine();
        }
        public static int square(int n)
        {
            Console.WriteLine("Square function called");
            return n;
        }
        public static int add(int n)
        {
            Console.WriteLine("Add function called");
            return n+n;
        }
    }
}
