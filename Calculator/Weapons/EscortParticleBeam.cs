using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Weapons
{
    class EscortParticleBeam : ParticleBeam
    {
        public EscortParticleBeam()
        {
            this.damage = 24;
            this.weaponClass = Ship.ShipClass.Escort;
        }
    }
}
