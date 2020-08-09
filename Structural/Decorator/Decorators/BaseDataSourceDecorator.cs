using System;

namespace Decorator
{
    /// <summary>
    /// Base Decorator
    /// Base decorators implement the same interface or abstract class as the component they are going to deocrate.
    /// </summary>
    public abstract class BaseDataSourceDecorator : BaseDataSource
    {
        protected BaseDataSource component;

        public BaseDataSourceDecorator(BaseDataSource component)
        {
            this.component = component;
        }

        // Optional - could add other abstract/virtual method
        public virtual string GetDescription() => "Base Decorator";

        // Optional - could add other abstract/virtual method
        // The Decorator delegates all work to the wrapped component.
        public override void WriteData(string data)
        {
            Console.WriteLine($"Base Decorator {this.GetType().Name}: {nameof(WriteData)}");
            component.WriteData(data);
        }

        // Optional - could add other abstract/virtual method
        // The Decorator delegates all work to the wrapped component.
        public override string ReadData()
        {
            Console.WriteLine($"Base Decorator { this.GetType().Name}: {nameof(ReadData)}");
            return component.ReadData();
        }
    }
}
