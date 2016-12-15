using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Ship;
using static Calculator.Weapons.Weapon;

namespace Calculator.Defenses
{
    public class Defense
    {
        public WeaponType defenseType;
        public ShipClass defenseClass;
        public double defenseEffect;
    }
}
