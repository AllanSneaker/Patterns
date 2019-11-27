using System.Collections.Generic;

namespace Memento.Services
{
    public class MementoCareTaker<T> : Stack<Memento<T>> where T : class
    {
        private int _capacity;

        public MementoCareTaker(int capacity = 5)
        {
            _capacity = capacity;
        }

        public void SaveState(T state)
        {
            if (Count > _capacity)
                Clear();
            if (Count < _capacity)
                Push(new Memento<T>(state));
        }

        public T GetPreviousState()
        {
            if (Count > 0)
                return Pop().GetState();
            else
                return default(T);
        }
    }
}
