using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class TerrestrialPlanet : Planet, IHasMoons,IHabitable
    {
        //PRIVATE INSTANCE VARIALBLES+++++++++++++++++++++++++++++++++++++++++++++
       private bool _oxygen;


        public TerrestrialPlanet( string name, double diameter, double mass, bool oxygen)
            :base(name, diameter,mass)
        {
            this._oxygen = oxygen;
            
         }

        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;

        }
        public bool Habitable() 
        {
            return  (_oxygen == true) ? true : false;
            
            
        }
    }




}

