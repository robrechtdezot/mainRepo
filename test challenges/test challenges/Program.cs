using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace test_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "He World";
            string text2 = text.ToLower();
            var groupedCharacters = text2.GroupBy(c => c)
                                         .Select(g => new { Character = g.Key, Count = g.Count() })
                                         .OrderByDescending(g => g.Count)
                                         .ToList();
            foreach (var item in groupedCharacters)
            {
                if ( item.Count > 1)
                {
                    Console.WriteLine(groupedCharacters.First());
                    break;
                }
                else //if (item.Count <= 1)
                {
                    Console.WriteLine("No repeated characters");
                    break;
                }
            }//hallo
        }
    }
}
    


       
