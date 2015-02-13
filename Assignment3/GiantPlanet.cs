using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class GiantPlanet : Planet
    {
        //PRIVATE INSTANCE VARIABLES++++++++++++++++++++++++++++++++++++++++++
        string _type;
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }


        //METHODS+++++++++++++++++++++++++++++

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public bool HasRings()
            {
            if(RingCount > 0)
            {
            return true;
            }
            else
            {
            return false;
            }




            }
        }
    }
