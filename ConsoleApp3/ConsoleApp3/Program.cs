using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<string> woorden = new List<string> { "zeester", "postbode", "kameel", "psycholoog", "generaal", "sandwich" };
            Random random = new Random();
            int index = random.Next(woorden.Count);
            string GeheimWoord = woorden[index];
            // char[] charArray = GeheimWoord.ToCharArray();

            Console.WriteLine(GeheimWoord);
            Console.WriteLine(GeheimWoord[0]);
            Console.WriteLine(GeheimWoord[1]);
            // Console.WriteLine(charArray[1]);
            // Console.WriteLine(charArray[4]);
            int aantaalLetters = (GeheimWoord.Length);
            int Levens = 10;
            int aantalLevens = Levens;


            char gok = Convert.ToChar(Console.ReadLine());
            if (gok == GeheimWoord[0])
            {
                Console.WriteLine("ok!");
            } 
          
            }
            } 
        }
    }

