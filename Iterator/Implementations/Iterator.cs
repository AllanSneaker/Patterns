using Iterator.Interfaces;

namespace Iterator.Implementations
{
    public class Iterator : IIterator
    {
        private Collection _collection;
        private int _current;
        private readonly int _step = 1;

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public bool IsCompleted => _current >= _collection.Count;

        public dynamic First()
        {
            _current = 0;
            return _collection.GetEmployee(_current);

        }

        public dynamic Next()
        {
            _current += _step;

            if (!IsCompleted)
            {
                return _collection.GetEmployee(_current);
            }
            else
            {
                return null;
            }
        }
    }
}
