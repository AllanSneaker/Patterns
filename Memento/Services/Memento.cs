using Newtonsoft.Json;
using System;

namespace Memento.Services
{
    public class Memento<T> where T : class
    {
        private readonly string _internalState;

        public Memento(T internalState)
        {
            _internalState = JsonConvert.SerializeObject(internalState);
        }

        public T GetState()
        {
            if (string.IsNullOrEmpty(_internalState))
            {
                throw new Exception("State is null");
            }
            return JsonConvert.DeserializeObject<T>(_internalState);
        }
    }
}
