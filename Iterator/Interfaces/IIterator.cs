
namespace Iterator.Interfaces
{
    public interface IIterator
    {
        object First();
        object Next();
        bool IsCompleted { get; }
    }
}
