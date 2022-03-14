using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入數字:");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            else if (2 <= n && n>=5)
            {
                Console.WriteLine("Not weird");
            }
            else if(6 <= n && n >= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
            Console.WriteLine();
        }
    }
}
