using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Armors
{
    class Armor
    {
        private int resistance;
        private int health;
        private int durability;
        private int stealth;

        public int Resistance { get => resistance; set => resistance = value; }
        public int Health { get => health; set => health = value; }
        public int Durability { get => durability; set => durability = value; }
        public int Stealth { get => stealth; set => stealth = value; }

        public string ArmorStadistics()
        {
            return "Resistance: " + resistance + "Health: " + health + "Durability: " + Durability + "Stealth: " + stealth;
        }
    }
}
