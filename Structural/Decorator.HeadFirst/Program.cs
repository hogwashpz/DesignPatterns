using System;
using Decorator.HeadFirst.StarBuzzWithSizes.Component;
using Decorator.HeadFirst.StarBuzzWithSizes.Decorators;

namespace Decorator.HeadFirst.StarBuzzWithSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseBeverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " $" + beverage.Cost().ToString("0.##"));

            BaseBeverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost().ToString("0.##"));

            BaseBeverage beverage3 = new HouseBlend();
            beverage3.Size = BaseBeverage.BeverageSize.Venti;
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.Cost().ToString("0.##"));

            Console.ReadKey();
        }
    }
}
