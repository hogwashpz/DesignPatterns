using Decorator.HeadFirst.StarBuzzWithSizes.Component;

namespace Decorator.HeadFirst.StarBuzzWithSizes.Decorators
{
    public abstract class CondimentDecorator : BaseBeverage
    {
        public BaseBeverage beverage;

        public BeverageSize GetSize => beverage.Size;
    }
}