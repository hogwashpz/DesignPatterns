using Decorator.HeadFirst.StarBuzzWithSizes.Component;

namespace Decorator.HeadFirst.StarBuzzWithSizes.Decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(BaseBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get => beverage.Description + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}