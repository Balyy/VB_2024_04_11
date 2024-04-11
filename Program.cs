using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB_2024_04_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Melyik nyelv:\n1) angol\n2) orosz");
            string user = Console.ReadLine();

            if (user == "1")
            {
                Console.WriteLine("Hello!");
            }
            else if (user =="2")
            {
                Console.WriteLine("Privijet!");
            }

            Console.ReadKey();
        }
    }
}
