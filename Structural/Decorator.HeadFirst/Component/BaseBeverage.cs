namespace Decorator.HeadFirst.StarBuzzWithSizes.Component
{
    public abstract class BaseBeverage
    {
        public enum BeverageSize
        {
            Tall,
            Grande,
            Venti
        }

        public virtual string Description { set; get; } = "Unknown Beverage";

        public BeverageSize Size { set; get; } = BeverageSize.Tall;

        public abstract double Cost();
    }
}
