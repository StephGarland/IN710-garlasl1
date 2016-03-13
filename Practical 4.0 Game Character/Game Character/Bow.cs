using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Bow : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            return "I shoot with my bow!";
        }
    }
}
