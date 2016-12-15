using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Weapons
{
    public class EscortRailgun : Railgun
    {
        public EscortRailgun()
        {
            this.damage = 48;
            this.weaponClass = Ship.ShipClass.Escort;
        }
    }
}
