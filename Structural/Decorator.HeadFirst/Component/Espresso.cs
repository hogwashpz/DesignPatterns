namespace Decorator.HeadFirst.StarBuzzWithSizes.Component
{
    public class Espresso : BaseBeverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost() => 1.99;
    }
}