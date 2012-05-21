using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            int[] numbers = { 4, 8, 15, 16, 23 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i].ToString());
            }

            string[] names = { "Bob", "Alex", "Sveve", "Chuck" };

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            string myMass = " 123456789 ";
            char[] charArray = myMass.ToCharArray();
            Array.Reverse(charArray);


            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i].ToString());   
            }


            //string myText = "Пример реверсивного текста!";
            //char[] charArray = myText.ToCharArray();
            //Array.Reverse(charArray);

            //foreach (var item in charArray)
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
        }
    }
}
