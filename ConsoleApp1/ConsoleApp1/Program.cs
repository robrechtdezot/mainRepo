using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
 
    class MyClass
    {
            // Class members
            string color = "red";        // field
            public int maxSpeed = 200;          // field
            public void fullThrottle()   // method
            {
                Console.WriteLine("The car is going as fast as it can!");
            }
        M
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe snel rijdt ge? ");
            int test = Convert.ToInt32(Console.ReadLine());

            
            if (test == MyClass.maxSpeed) ;
            {
                Console.WriteLine("test");
            } 
            else
            {
                Console.WriteLine();
            }
        }
    }
}

