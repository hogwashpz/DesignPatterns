using System;

namespace Decorator
{
    /// <summary>
    /// Concrete Components
    /// provide default implementations for the operation/s.
    /// The concrete component is the object we're going to dinamically add new behavio to.
    /// </summary>
    public class FileDataSource : BaseDataSource
    {
        private readonly string filePath;

        public FileDataSource(string filePath)
        {
            Console.WriteLine($"Component {this.GetType().Name}: Constructor");
            this.filePath = filePath;
        }

        public override void WriteData(string data)
        {
            Console.WriteLine($"Concrete Component {this.GetType().Name}: {nameof(WriteData)}");
        }

        public override string ReadData()
        {
            // Read data from file.
            Console.WriteLine($"Concrete Component {this.GetType().Name}: {nameof(ReadData)}");
            return $"File ReadData: {filePath}";
        }
    }
}
