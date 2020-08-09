namespace Decorator
{
    /// <summary>
    /// Component Interface
    /// The component interface defines operations that can be altered by decorators.
    /// </summary>
    public abstract class BaseDataSource
    {
        public abstract void WriteData(string data);
        public abstract string ReadData();
    }
}
