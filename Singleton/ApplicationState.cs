using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class ApplicationState
    {
        private static ApplicationState _instance;
        public int LoginId { get; set; }
        public string Role { get; set; }
        private ApplicationState(){}

        public static ApplicationState GetState()
        {
            if (_instance == null)
                _instance = new ApplicationState();
            return _instance;
        }
    }
}
