using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Knight : Character
    {
        public Knight(string name) : base(name)
        {
            Weapon = new Dagger();
        }

        public override string Declaim()
        {
            return "I am a chivalrous Knight!";
        }
    }
}
