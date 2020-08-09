namespace Decorator.HeadFirst.StarBuzzWithSizes.Component
{
    public class DarkRoast : BaseBeverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double Cost() => 0.99;
    }
}