using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public abstract class Character
    {
        public string Name { get; }
        public IWeaponBehaviour Weapon { get; set; }

        public Character(string name)
        {
            this.Name = name;
        }

        public string StateName()
        {
            return "My name is " + Name;
        }

        public abstract string Declaim();

    }
}
