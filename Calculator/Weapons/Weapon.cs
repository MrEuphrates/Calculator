using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Weapons
{
    public class Weapon
    {
        //Enumerators
        public enum WeaponType { Particle, Railgun};

        //Variables
        public WeaponType weaponType;
        public Ship.ShipClass weaponClass;
        public double range;
        public double damage;

        //Member variables
        public virtual void fireWeapon(int totalBatteries, Ship target, double distanceToTarget) { throw new NotImplementedException(); }
        public virtual double firingSolution(int totalBatteries, Ship target, double distanceToTarget) { throw new NotImplementedException(); }
    }
}
