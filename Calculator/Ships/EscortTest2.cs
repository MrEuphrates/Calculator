using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Ships
{
    class EscortTest2 : Ship
    {
        public EscortTest2()
        {
            this.shipClass = ShipClass.Escort;
            this.maxHull = this.curHull = 400;
            armament.Add(new KeyValuePair<Weapons.Weapon, int>(new Weapons.EscortRailgun(), 2));
            armament.Add(new KeyValuePair<Weapons.Weapon, int>(new Weapons.EscortParticleBeam(), 1));
            this.maxMove = 12;
            this.minMove = 0;
        }
    }
}
