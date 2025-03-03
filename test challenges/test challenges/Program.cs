using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduceFriends();
            }


        public static void IntroduceFriends(string name1, string name2, string name3)
        {
            Console.WriteLine($"These are my friends, {name1} and {name2}!");
            Console.WriteLine($"\"{name1}\", \"{name2}\",\"{name3}\"");
        }
    }
}
    


       
