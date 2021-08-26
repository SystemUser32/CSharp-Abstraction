using System;
using static System.Console;

namespace AbstractionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Airplane airplane = new Airplane();
            Vehicle vehicle = airplane;

            vehicle.Startup();
            airplane.EngineSound();

            WriteLine("\n----------------\n");

            Su57 su57 = new Su57();
            MiG31 mig31 = new MiG31();

            su57.Startup();
            su57.EngineSound();
            su57.PerformAttack();

            mig31.Startup();
            mig31.EngineSound();
            try {
                mig31.PerformAttack();
            }
            catch(NotImplementedException ex) {
                WriteLine(ex.Message.ToString());
            }

        }
    }
}


