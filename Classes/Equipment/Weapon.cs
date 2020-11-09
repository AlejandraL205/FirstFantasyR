using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Weapon : IDescribable
    {
        private int gg;

        public int Gg { get => gg; set => gg = value; }

        public string ShowInformation()
        {
            return "This is a weapon";
        }



    }
}
