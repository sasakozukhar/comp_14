using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Func(int n)
        {
            for (int x=1; x<=n; x++)
            {
                
                Console.WriteLine(x);
            }

        }
        static int Input(string message)
        {
            Console.Write(message);
            return int .Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            
            
            int n = Input("n=");
            Func(n);
            Console.Read();
        }
    }
}
