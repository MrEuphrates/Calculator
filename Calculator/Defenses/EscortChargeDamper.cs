using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Defenses
{
    public class EscortChargeDamper : Defense
    {
        public EscortChargeDamper()
        {
            this.defenseClass = Ship.ShipClass.Escort;
            this.defenseEffect = -8;
            this.defenseType = Weapons.Weapon.WeaponType.Particle;
        }
    }
}
