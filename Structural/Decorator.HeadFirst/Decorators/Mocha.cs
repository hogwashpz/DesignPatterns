using Decorator.HeadFirst.StarBuzzWithSizes.Component;

namespace Decorator.HeadFirst.StarBuzzWithSizes.Decorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(BaseBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get => beverage.Description + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}