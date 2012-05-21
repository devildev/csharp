using System;
using System.IO;

namespace ReadTextFileWhile
{
    class Test
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "test";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
            Console.ReadLine();

            //Console.WriteLine("Hello");
            //Console.ReadLine();
        }
    }
}
