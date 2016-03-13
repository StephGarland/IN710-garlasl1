using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Dagger : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            return "I poke with my dagger!";
        }
    }
}
