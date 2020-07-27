using System;

namespace Decorator
{
    public class StreamDataSource : BaseDataSource
    {
        private readonly string url;

        public StreamDataSource(string url)
        {
            Console.WriteLine($"Component {this.GetType().Name}: Constructor");
            this.url = url;
        }

        public override void WriteData(string data)
        {
            Console.WriteLine($"Concrete Component {this.GetType().Name}: {nameof(WriteData)}");
        }

        public override string ReadData()
        {
            // Read data from file.
            Console.WriteLine($"Concrete Component {this.GetType().Name}: {nameof(ReadData)}");
            return $"Stream ReadData: {url}";
        }
    }
}
