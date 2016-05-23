using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1Karl
{
    public class Program
    {
        //should not compile
       public  static int add(int a, int b)
        {
            return a + b;
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
