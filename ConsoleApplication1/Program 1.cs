using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program1
    {
        static void Main1(string[] args)
        {
            try
            {
                var number = "1234";
                Console.WriteLine(number);
                Console.WriteLine("{0},{1}", byte.MinValue, byte.MaxValue);
                const float pi = 3.14f;
                Console.WriteLine(Convert.ToString(pi));
                int i = Convert.ToByte(number);
                Console.WriteLine(i);
            }
            catch (Exception)
            {
                Console.WriteLine("The data was too big");
            }
            
        }
    }
}
