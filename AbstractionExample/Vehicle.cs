using System;
using static System.Console;

namespace AbstractionExample
{
    public abstract class Vehicle {
        public abstract void Startup();

        public void EngineSound() {
            WriteLine("Engine makes a loud sound...");
        }
    }

    public class Airplane : Vehicle {
        public override void Startup()
        {
            //throw new NotImplementedException();
            WriteLine("Plane takes off...");
        }
    }
}

