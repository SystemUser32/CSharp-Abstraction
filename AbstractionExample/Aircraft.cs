using System;
using static System.Console;

namespace AbstractionExample
{
    public abstract class Aircraft {
        public abstract void Startup();
        public abstract void EngineSound();
        public abstract void PerformAttack();
    }

    public class Su57 : Aircraft {
        public override void Startup()
        {
            //throw new NotImplementedException();
            WriteLine("Su-57 takes off...");
        }

        public override void EngineSound()
        {
            //throw new NotImplementedException();
            WriteLine("Engine makes a loud sound...");
        }

        public override void PerformAttack()
        {
            //throw new NotImplementedException();
            WriteLine("Su-57 fires misiles...");
        }
    }

    public class MiG31 : Aircraft {
        public override void Startup()
        {
            //throw new NotImplementedException();
            WriteLine("MiG-31 takes off...");
        }

        public override void EngineSound()
        {
            //throw new NotImplementedException();
            WriteLine("Engine makes a louder sound...");
        }

        public override void PerformAttack()
        {
            throw new NotImplementedException("Ex: Method overriden from the parent class has not been implemented.");
            //WriteLine("MiG-31 fires intercontinental misile...");
        }
    }
}

