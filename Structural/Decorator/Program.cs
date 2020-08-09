using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern !!!" + Environment.NewLine);

            BaseDataSource file = new FileDataSource(Environment.CurrentDirectory);
            // Decorate component
            BaseDataSourceDecorator encryptedFile = new EncryptionDecorator(file);
            BaseDataSourceDecorator compressFile = new CompressionDecorator(encryptedFile);

            var resultFile = compressFile.ReadData();
            Console.WriteLine(resultFile);
            Console.WriteLine();

            // Other way
            BaseDataSource stream = new StreamDataSource("www.example.com");
            // Decorate component
            stream = new EncryptionDecorator(stream);
            stream = new CompressionDecorator(stream);

            var resultStream = stream.ReadData();
            Console.WriteLine(resultStream);
        }
    }
}
