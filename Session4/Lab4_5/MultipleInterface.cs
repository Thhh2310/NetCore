using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    internal class MultipleInterface
    {
        //define the IDrivable interface
        public interface IDrivable
        {
            //method declarations
            void Start();
            void Stop();
            //property declaration
            bool Started { get; }
        }
        
        //Define the ISteerable interface
        public interface ISteerable
        {
            void TurnLeft();
            void TurnRight();
        }

        //define the IMovable interface
        public interface IMovable : IDrivable, ISteerable
        {
            //methhod declarations
            void Accelerate();
            void Brake();
        }
    }
}
