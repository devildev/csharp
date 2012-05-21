using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCSharpAppB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            Console.ReadLine();
            
            //ShowEnvironmentDetails();

            //// Wait for the Enter key to be pressed.
            //Console.ReadLine();

            //// Return an arbitrary error code.
            //return -1;

            ////вывод простого сообщения пользователю
            //Console.WriteLine("***** My First C# App *****");
            //Console.WriteLine("Hello World!");
            //Console.WriteLine();

            ////Ожидание нажатия клавиши Enter перед завершением работы
            //Console.ReadLine();
            //return -1;
        }

        static void GetUserData()
        {
            // Получение информации об имени и возрасте. 
            Console.Write("Please enter your name: "); // Запрос на ввод имени 
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: "); // Запрос на ввод возраста 
            string userAge = Console.ReadLine();
            // Изменение цвета изображения, просто ради интереса. 
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Отображение полученных сведений в окне консоли. 
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
            // Восстановление предыдущего цвета. 
            Console.ForegroundColor = prevColor;
        } 

        //static void ShowEnvironmentDetails()
        //{
        //    // Print out the drives on this machine,
        //    // and other interesteing details.
        //    foreach (string drive in Environment.GetLogicalDrives())
        //        Console.WriteLine("Drive: {0}", drive);

        //    Console.WriteLine("OS: {0}", Environment.OSVersion);
        //    Console.WriteLine("Number of processors: {0}",
        //        Environment.ProcessorCount);
        //    Console.WriteLine(".NET Version: {0}",
        //        Environment.Version);
        //}
    }
}
