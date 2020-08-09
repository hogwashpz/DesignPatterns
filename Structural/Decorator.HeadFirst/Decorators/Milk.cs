using Decorator.HeadFirst.StarBuzzWithSizes.Component;

namespace Decorator.HeadFirst.StarBuzzWithSizes.Decorators
{
    public class Milk : CondimentDecorator
    {
        public Milk(BaseBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get => beverage.Description + ", Milk";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}