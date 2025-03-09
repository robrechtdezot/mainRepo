using System;

namespace test_challenges
{
    class Class1
    {
        //string[] str1 = { "test", "terras", "kasteel", "goud", "tegel", "tand" };
        public void PrintStrings()
        {
            string[] str1 = { "test", "terras", "kasteel", "goud", "tegel", "tand" };

            foreach (string s in str1)
            {
                Console.WriteLine(s);
                string s1 = s;

            }
        }
    }

 }
