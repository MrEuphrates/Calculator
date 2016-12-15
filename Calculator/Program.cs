using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Ships;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship shipA = new EscortTest();
            Ship shipB = new EscortTest2();
            double distanceBetweenFleets = 37;

            //TODO First, each fleet should evaluate whether it's damage ratio is improved or reduced by moving closer at maximum speed, and choose accordingly.
            double aMinMoveFiringSolution = shipA.firingSolutionAtMoveRate(shipB, 1, distanceBetweenFleets, Ship.MoveRate.Minimum);
            double aMaxMoveFiringSolution = shipA.firingSolutionAtMoveRate(shipB, 1, distanceBetweenFleets, Ship.MoveRate.Maximum);
            double bMinMoveFiringSolution = shipB.firingSolutionAtMoveRate(shipA, 1, distanceBetweenFleets, Ship.MoveRate.Minimum);
            double bMaxMoveFiringSolution = shipB.firingSolutionAtMoveRate(shipA, 1, distanceBetweenFleets, Ship.MoveRate.Maximum);
            

            //TODO Fire each fleet's weapons and deal hull damage.
            shipA.fireWeapons(shipB, 1, distanceBetweenFleets);
            shipB.fireWeapons(shipA, 1, distanceBetweenFleets);

            //TODO Remove destroyed ships from each fleet.
            //TODO Determine if the fighting is over and report the results.
            Console.WriteLine("Calculation is done.  Results === \nShipA Hull: " + shipA.curHull + "\tShipB Hull: " + shipB.curHull);
            Console.ReadLine();
        }
    }
}