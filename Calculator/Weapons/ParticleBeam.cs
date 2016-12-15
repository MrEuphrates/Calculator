using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Defenses;

namespace Calculator.Weapons
{
    class ParticleBeam : Weapon
    {
        public ParticleBeam()
        {
            this.range = 30;
            this.weaponType = WeaponType.Particle;
        }

        public override void fireWeapon(int batteries, Ship target, double distanceToTarget)
        {
            //TODO Not useful now, but eventually, targeting the damaged ship first might make sense, though killing whole ships first might be better.
            bool isTargetDamaged = !(target.maxHull == target.curHull);

            double hits = distanceToTarget <= this.range ? batteries : 0;
            double totalTargetDefense = 0;
            foreach(Defense defense in target.defenses)
                if (defense.defenseType == WeaponType.Particle) totalTargetDefense += defense.defenseEffect;
            double damagePerHit = this.damage + totalTargetDefense;
            if (damagePerHit <= 0) return;

            //TODO This will be more sophisticated when I start doing fleets, but for now, it's simple.
            target.curHull = hits * damagePerHit > target.curHull ? 0 : target.curHull - hits * damagePerHit;
        }

        public override double firingSolution(int batteries, Ship target, double distanceToTarget)
        {
            double hits = distanceToTarget <= this.range ? batteries : 0;
            double totalTargetDefense = 0;
            foreach (Defense defense in target.defenses)
                if (defense.defenseType == WeaponType.Particle) totalTargetDefense += defense.defenseEffect;
            double damagePerHit = this.damage + totalTargetDefense;
            if (damagePerHit <= 0) return 0;

            //TODO This will be more sophisticated when I start doing fleets, but for now, it's simple.
            return hits * damagePerHit;
        }
    }
}
