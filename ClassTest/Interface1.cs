using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    interface IWeapon
    {
        string Hit(string target);
    }


    class Shuriken : IWeapon
    {
        public string Hit(string target)
        {
            string action;
            action = string.Format("Pierced {0}'s armor", target);
            return action;
        }
    }
    class Sword:IWeapon
    {
        public string Hit(string target)
        {
            string action;
            action=string.Format("Chopped {0} clean in half", target);
            return action;
        }
    }
    class Samurai
    {
        readonly IWeapon weapon;
        public Samurai(IWeapon weapon) // using weapon as iWeapon
        {
         this.weapon = weapon; //This is my Constructor
        }
        public string Attack(string target)
        {
            return this.weapon.Hit(target);
        }
    }

}
