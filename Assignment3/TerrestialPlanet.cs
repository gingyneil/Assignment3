using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class TerrestrialPlanet : Planet
    {
        //PRIVATE INSTANCE VARIALBLES+++++++++++++++++++++++++++++++++++++++++++++
       private bool _oxygen;


        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass) :base(name, diameter,mass)
        {
            this._oxygen = oxygen;
        
    
    
    
    
        }

    
    
    }




}

