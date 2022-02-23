using System;
using System.Collections.Generic;
using System.Text;

namespace game.Class
{
    public class Swordsman : Heroes
    {
        public Swordsman()
        {
            Health = 100;
            Backpack = new Dictionary<int, string>();
            ActiveWeapon = 0;
        }

        public override string TakeWeapon(string weapon, int weaponIndex)
        {
            try
            {
                if (Backpack.Count >= 2)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    try
                    {
                        if (weapon.Contains("magic"))
                        {
                            throw new ArgumentException();
                        }
                        else
                        {
                            Backpack.Add(weaponIndex, weapon);
                        }
                    }
                    catch (ArgumentException)
                    {
                        return "Swordsman cannot take magic.";
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                return "Wizard backpak is full";
            }

            return "Taken";
        }

        public override string DropWeapon(int weaponIndex)
        {
            string weaponName = "";
            try
            {
                if (Backpack.Count == 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    foreach (KeyValuePair<int, string> weapon in Backpack)
                    {
                        if (weapon.Key == weaponIndex)
                        {
                            Backpack.Remove(weaponIndex);
                            return weapon.Value;
                        }
                    }
                }
            }
            catch (ArgumentException)
            {
                return "Empty";
            }

            return weaponName;

        }

        public override string ChangeWeapon()
        {
            try
            {
                if (Backpack.Count == 0)
                {
                    throw new ArgumentException();
                }
                foreach (KeyValuePair<int, string> weapon in Backpack)
                {
                    if (weapon.Key != ActiveWeapon)
                    {
                        ActiveWeapon = weapon.Key;
                        return weapon.Value;
                    }
                }
            }
            catch (ArgumentException)
            {
                return "NoWeapon";
            }

            return null;
        }
    }
}
