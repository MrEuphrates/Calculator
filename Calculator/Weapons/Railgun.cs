using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Weapons
{
    public class Railgun : Weapon
    {
        public Railgun()
        {
            this.range = 6;
            this.weaponType = WeaponType.Railgun;
        }

        public override void fireWeapon(int batteries, Ship target, double distanceToTarget)
        {
            //TODO Not useful now, but eventually, targeting the damaged ship first might make sense, though killing whole ships first might be better.
            bool isTargetDamaged = !(target.maxHull == target.curHull);

            double hits = distanceToTarget <= this.range ? batteries : Math.Ceiling(Math.Pow(0.5, Math.Floor(distanceToTarget / this.range)) * batteries);

            //TODO This will be more sophisticated when I start doing fleets, but for now, it's simple.
            target.curHull = hits * this.damage > target.curHull ? 0 : target.curHull - hits * this.damage;
        }

        public override double firingSolution(int batteries, Ship target, double distanceToTarget)
        {
            double hits = distanceToTarget <= this.range ? batteries : Math.Ceiling(Math.Pow(0.5, Math.Floor(distanceToTarget / this.range)) * batteries);
            return hits * this.damage;
        }
    }
}