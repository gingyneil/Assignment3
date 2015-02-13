using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class TerrestialPlanet : Planet
    {
        //PRIVATE INSTANCE VARIALBLES+++++++++++++++++++++++++++++++++++++++++++++
        bool _oxygen;


        public TerrestialPlanet(bool oxygen, string name, double diameter, double mass) :base(name, diameter,mass)
        {
            this._oxygen = oxygen;
        }

    }
}
