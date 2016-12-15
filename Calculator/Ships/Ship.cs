using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Defenses;
using Calculator.Weapons;

namespace Calculator
{
    public class Ship
    {
        //Enumerators
        public enum ShipClass { Escort };
        public enum MoveRate { Minimum, Maximum};

        //Variables
        public double maxHull;
        public double curHull;
        public ShipClass shipClass;
        public List<KeyValuePair<Weapon, int>> armament = new List<KeyValuePair<Weapons.Weapon, int>>();
        public List<Defense> defenses = new List<Defense>();
        public double minMove;
        public double maxMove;
        
        //Member functions
        //Eventually, I'll pass a fleet, not a single ship.
        public void fireWeapons(Ship target, int numFiringShips, double distanceToTarget)
        {
            int shipsToFire = numFiringShips;
            while (shipsToFire > 0)
            {
                foreach (KeyValuePair<Weapon, int> weapon in armament)
                    weapon.Key.fireWeapon(weapon.Value, target, distanceToTarget);
                --shipsToFire;
            }
        }

        public double firingSolutionAtMoveRate(Ship target, int numFiringShips, double distanceToTarget, MoveRate moveRate)
        {
            int shipsToFire = numFiringShips;
            double firingSolutionOutput = 0;
            while(shipsToFire > 0)
                foreach(KeyValuePair<Weapon, int> weapon in armament)
                {
                    if(moveRate==MoveRate.Minimum) firingSolutionOutput += weapon.Key.firingSolution(weapon.Value, target, distanceToTarget <= this.minMove ? 0 : distanceToTarget - this.minMove);
                    else firingSolutionOutput += weapon.Key.firingSolution(weapon.Value, target, distanceToTarget <= this.minMove ? 0 : distanceToTarget - this.maxMove);
                }
            return firingSolutionOutput;
        }
    }
}
