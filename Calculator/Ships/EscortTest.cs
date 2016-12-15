using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Defenses;

namespace Calculator.Ships
{
    public class EscortTest : Ship
    {
        public EscortTest()
        {
            this.shipClass = ShipClass.Escort;
            this.maxHull = this.curHull = 400;
            this.armament.Add(new KeyValuePair<Weapons.Weapon, int>(new Weapons.EscortRailgun(), 3));
            this.defenses.Add(new EscortChargeDamper());
            this.maxMove = 12;
            this.minMove = 0;
        }
    }
}
