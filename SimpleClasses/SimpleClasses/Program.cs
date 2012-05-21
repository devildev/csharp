using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Car myNewCar = new Car();

      myNewCar.Make = "Oldsmobile";
      myNewCar.Model = "Cutlas Suprime";
      myNewCar.Year = 1986;
      myNewCar.Color = "Silver";

      public double DetermineMarketValue()

      {
        return 0.0;
      }

      //Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Color);
      //determineMarketValue(myNewCar);

      double myValue = myNewCar.DetermineMarketValue();

      Console.ReadLine();
    }

    /* */
  }

  internal class Car
  {
    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public string Color { get; set; }

    private static double determineMarketValue(Car car)
    {
      return 100.0;
    }
  }
}