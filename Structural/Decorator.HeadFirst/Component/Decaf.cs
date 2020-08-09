namespace Decorator.HeadFirst.StarBuzzWithSizes.Component
{
    public class Decaf : BaseBeverage
    {
        public Decaf()
        {
            Description = "Decaf Coffee";
        }

        public override double Cost() => 1.05;
    }
}
