﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;

            //x = 7;
            //y = x + 3;

            //Console.WriteLine(y);

            //string myFirstName;
            //myFirstName = "Bob";

            //var myFirstName = "Bob";
            //Console.WriteLine(myFirstName);

            int x = 7;
            string y = "5";
            string myFirstTry = x.ToString() + y;
            //Console.WriteLine(myFirstTry);
            int mySecondTry = x + int.Parse(y);
            Console.WriteLine(mySecondTry);

            Console.ReadLine();



        }
    }
}
