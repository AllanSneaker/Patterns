using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationState state1 = ApplicationState.GetState();
            state1.LoginId = 1;
            state1.Role = "Admin";

            ApplicationState state2 = ApplicationState.GetState();
            Console.WriteLine($"Login Identifier is {state2.LoginId} and Role is {state2.Role}");

            Console.WriteLine(state1 == state2);

            var state3 = ApplicationState.GetState();
            state3.LoginId = 2;
            state3.Role = "Moderator";
            Console.WriteLine($"Login Identifier is {state1.LoginId} and Role is {state1.Role}");

            Console.WriteLine(state1 == state3);
        }
    }
}
