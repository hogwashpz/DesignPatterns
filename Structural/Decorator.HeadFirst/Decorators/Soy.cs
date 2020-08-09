using Decorator.HeadFirst.StarBuzzWithSizes.Component;


namespace Decorator.HeadFirst.StarBuzzWithSizes.Decorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(BaseBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get => beverage.Description + ", Soy";
        }

        public override double Cost()
        {
            double cost = beverage.Cost();
            switch (beverage.Size)
            {
                case BeverageSize.Tall:
                    cost += 0.10;
                    break;
                case BeverageSize.Grande:
                    cost += 0.15;
                    break;
                case BeverageSize.Venti:
                    cost += 0.20;
                    break;
                default:
                    break;
            }
            return cost;
        }
    }
}