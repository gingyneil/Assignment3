using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //PRIVATE INSTANCE VARIABLES++++++++++++++++++++++++++++++++++++++++++
        string _type;
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }


        //METHODS+++++++++++++++++++++++++++++

      
        public bool HasRings()
            {
            return (RingCount > 0) ? true : false;
            
            }

        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;

        }


            
        }
    }
