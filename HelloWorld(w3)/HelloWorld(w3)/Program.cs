using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_w3_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ik ben aan het leren
             hier typ ik nog wat meer*/

            Console.WriteLine("Hello World!");
            Console.WriteLine("I am learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);

            Console.Write("\nHello Sven! ");
            Console.Write("I will print on the same line.");

            Console.Write("\nZe willen wel graag\n dat ik me hier heel goed over voel precies..\n\n"); // waarom kan ik hier niet gewoon WriteLine gebruiken?

            string firstName = "Wout ";
            string lastName = "Servaes";
            string fullName = firstName + lastName;
            string myText = "Hello"; // String
            string greeting = "Hello world";
            string greeting2 = "Nice to meet you!";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const int myNum = 15; // const makes value unchangeable
            double myDoubleNum = 5.99D; // Floating point number (8bytes eindigen met D) (float 4bytes Eindigen met F)
            char myLetter = 'D'; // Character
            bool myBool = true; // Boolean


            int x, y, z; // integer (whole number) 
            long myNum2 = 15000000000L;
            float f1 = 35e3F;
            double d1 = 12E4D;
            bool isCsharpFun = true;
            bool isFishTasty = false;

            double myDouble = 9.78;
            int myInt = (int)myDouble;  //<-explicit casting converting large to smaller
                                        //Implicit Casting(automatically) -converting a smaller type to a larger type size (double .. int )
                                        // int minutesPerHour = 60; Good | int m = 60;  Ok, but not so easy to understand what m actually is
            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            x = y = z = 50;

            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
            Console.WriteLine(firstName);
            Console.WriteLine(myNum);
            Console.WriteLine(myNum2);
            Console.WriteLine(myText);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine("Hello " + fullName);
            Console.WriteLine(x + y + z);
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine("Is C# Fun ? " + isCsharpFun);
            Console.WriteLine("Is fish Tasty? " + isFishTasty);
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            Console.WriteLine(Convert.ToString(myInt2)); // convert int into string
            Console.WriteLine(Convert.ToDouble(myInt2)); // convert int into double
            Console.WriteLine(Convert.ToInt32(myDouble2)); // convert double to int
            Console.WriteLine(Convert.ToString(myBool2)); // convert bool to string

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            if (age == 29)
            {
                Console.WriteLine("Bijna 30. hahaha");
            }
            else if (age < 29)
            {
                Console.WriteLine("Groentje!");
            }
            else
            {
                Console.WriteLine("Ouwe!");
            }


            Console.WriteLine("\nAlphabet: " + alphabet);
            Console.WriteLine("\nThe lenght of the alphabeth string is: " + alphabet.Length);
            Console.WriteLine(alphabet.ToUpper());
            Console.WriteLine(alphabet.ToLower());
            string wout = "wout";
            Console.WriteLine(wout[0]);



            Console.WriteLine("current speed? ");
            int currentSpeed = Convert.ToInt32(Console.ReadLine());

            myClass myObj = new myClass();

            if (currentSpeed == myObj.maxSpeed)
            {
                myObj.fullThrottle();
            }
            else
            {
                Console.WriteLine(currentSpeed);
            }

            Console.ReadLine();        
        }

        
    }
}