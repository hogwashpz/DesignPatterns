namespace Decorator.HeadFirst.StarBuzzWithSizes.Component
{
    public class HouseBlend : BaseBeverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost() => 0.89;
    }
}