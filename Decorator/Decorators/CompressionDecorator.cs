using System;

namespace Decorator
{
    // Concrete Decorators call the wrapped object and alter its result in some way.
    public class CompressionDecorator : BaseDataSourceDecorator
    {
        public CompressionDecorator(BaseDataSource source)
            : base(source)
        {
            Console.WriteLine($"{this.GetType().Name}: Constructor");
        }

        public override string GetDescription() => $"Compression Decorator : {base.GetDescription()}";

        public override void WriteData(string data)
        {
            Console.WriteLine($"Call {this.GetType().Name}: {nameof(WriteData)}");
            base.WriteData(data);
        }

        public override string ReadData()
        {
            Console.WriteLine($"Call {this.GetType().Name}: {nameof(ReadData)}");
            return "Compress data from, " + base.ReadData();
        }
    }
}
