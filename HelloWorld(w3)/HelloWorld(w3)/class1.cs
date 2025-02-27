using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_w3_
{
        class myClass
        { 
        string color;                 // field
        public int maxSpeed = 200;                 // field
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        public void Main(string[] args)
        {
            myClass myObj = new myClass();
            myObj.fullThrottle();  // Call the method
        }
    }
}
