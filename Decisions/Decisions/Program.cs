﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press Enter");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);
            //Console.ReadLine();

            Console.WriteLine("Would you prefer what is behined door number 1, 2 or 3?");
            string userValue = Console.ReadLine();

            //string message = "";

            //if (userValue == "1")
            //    message = "You won a new car!";

            //else if (userValue == "2")
            //    message = "You won a new boat!";

            //else if (userValue == "3")
            //    message = "You won a new cat!";

            //else
            //    message = "orry, we didn't understand. You lose!";

            string message = (userValue == "1") ? "boat" : "strand of ling";
            //Console.WriteLine("You won a {0}", message);
            Console.WriteLine("You won a {0}! And you typed {1}", message, userValue);
            Console.ReadLine();
        }
    }
}
