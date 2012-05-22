using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = superSecretFormular("Bob");
            Console.WriteLine(myValue);

            Console.WriteLine(superSecretFormular("Vasiliy","Pupkin"));

            Console.WriteLine(superSecretFormular());

            Console.ReadLine();
        }

        private static string superSecretFormular()
        {
            return "Hello World";
        }

        private static string superSecretFormular(string name)
        {
            return string.Format("Hello World, {0}", name);
        }

        private static string superSecretFormular(string name, string sername)
        {
            return string.Format("Hello {0} {1}", name, sername);
        }

    }
}
