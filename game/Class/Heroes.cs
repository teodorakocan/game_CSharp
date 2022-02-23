using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace game.Class
{
    public abstract class Heroes
    {
        public int Health { get; set; }
        public Dictionary<int, string> Backpack { get; set; }
        public int ActiveWeapon { get; set; }

        public Heroes() { }

        public abstract string TakeWeapon(string weapon, int weaponIndex);

        public abstract string DropWeapon(int weaponIndex);

        public abstract string ChangeWeapon();
        
    }
}
