
namespace Memento.Services
{
    public class HistoryService<T> where T : class
    {
        private MementoCareTaker<T> _undo;
        private MementoCareTaker<T> _redo;

        public HistoryService(int capacity = 5)
        {
            _undo = new MementoCareTaker<T>(capacity);
            _redo = new MementoCareTaker<T>(capacity);
        }

        public void SaveState(T state)
        {
            _undo.SaveState(state);
        }

        public T Undo()
        {
            var state = _undo.GetPreviousState();

            if (state != null)
                _redo.SaveState(state);

            return state;
        }

        public T Redo()
        {
            return _redo.GetPreviousState();
        }
    }
}
