using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Math;


namespace ConsoleApplication1
{
    public enum ShippingMethod
    {
        AirMail = 1,
        Express = 2,
        RegisteredMail = 3
    }

    public class Program2
    {
        static void Main(string[] args)
        {
            try
            {
                //Use Person class, create a new object and 
                //call the introduce method

                Person john = new Person();
                john.FirstName = "John";
                john.LastName = "Smith";
                john.Introduce();

                //Use Calc Class - create a new object and pass value
                Calculator calculator = new Calculator();
                
                var result = calculator.add(2, 4);
                Console.WriteLine(result);

                //Array Example
                int[] numbers = new int[3];
                numbers[0] = 1;
                Console.WriteLine(numbers[0]);
                Console.WriteLine(numbers[1]);
                Console.WriteLine(numbers[2]);

                //Bool Array
                bool[] flags = new bool[3];
                flags[0] = true;
                Console.WriteLine(flags[0]);
                Console.WriteLine(flags[1]);
                Console.WriteLine(flags[2]);

                //String Usage Example
                var firstName = "Tanvir";
                var lastName = "Alam";
                //Using string.Format
                var fullName = string.Format("This is my full name {0} {1}", firstName, lastName);
                Console.WriteLine(fullName);
                //Using string.Join
                var names = new string[3] {"John", "Jack", "Mary"};
                var formattedNames = string.Join(",", names);
                Console.WriteLine(formattedNames);

                //Verbatim strings
                var text = @"Hello this is a path 
                                C:Windows\System32\Public
                                and look at this other path
                                c:\users\tan";
                Console.WriteLine(text);

                //Enum Example
                Console.WriteLine("Enum Example Below");
                // Add enum at the top because it is a C# type






            }
            catch (Exception)
            {
                Console.WriteLine("The data was too big");
            }
            
        }
    }
}
