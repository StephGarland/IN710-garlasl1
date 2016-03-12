using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class CharacterCreater
    {
        public static Character CreateCharacter(string name, string type)
        {
            Character newCharacter;
            switch (type)
            {
                case "King":
                    newCharacter = new King(name);
                    break;
                case "Queen":
                    newCharacter = new Queen(name);
                    break;
                case "Knight":
                    newCharacter = new Knight(name);
                    break;
                case "Troll":
                    newCharacter = new Troll(name);
                    break;
                default:
                    newCharacter = null;
                    break;
            }
            return newCharacter;
        }
    }
}
