using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class WeaponCreator
    {
        public static IWeaponBehaviour CreateWeapon(string name)
        {
            IWeaponBehaviour newWeapon;
            switch (name)
            {
                case "Sword":
                    newWeapon = new Sword();
                    break;
                case "Bow":
                    newWeapon = new Bow();
                    break;
                case "Dagger":
                    newWeapon = new Dagger();
                    break;
                default:
                    newWeapon = null;
                    break;
            }
            return newWeapon;
        }
    }
}
