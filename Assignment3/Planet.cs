using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*NEIL READING
 STUDENT NUMBER: 300793474
 COMP123 ASSIGNMENT#3
 Work History: 
 Feb/12/2015*/

namespace Assignment3
{
   abstract class Planet
    {
       //PRIVATE INSTANCE VARIABLES+++++++++++++++++
       private double _diameter;
       private double _mass;
       private int _moonCount;
       private string _name;
       private double _orbitalPeriod;
       private int _ringCount;
       private double _rotationPeriod;


       //PUBLIC PROPERTIES++++++++++++++++++++++++++++
       public double Diameter
       {
           get
           {
               return this._diameter; //Returns value of instance variable, (Read-only)
           }
       }

       public double Mass
       {
           get
           {
               return this._mass; //(Read-only)
           }
       }


       public int MoonCount
       {
           get
           {
               return this._moonCount;
           }

           set
           {
               this._moonCount = value; //Sets instance variable, accessed through MoonCount Property.
           }
       }

       public double OrbitalPeriod
       {
           get
           {
               return this._orbitalPeriod;
           }
           set
           {
               this._orbitalPeriod = value;
           }
       }

       public int RingCount
       {
           get
           {
               return this._ringCount;
           }
           set
           {
               this._ringCount = value;
           }
       }

       public double RotationPeriod
       {
           get
           {
               return this._rotationPeriod;
           }
           set
           {
               this._rotationPeriod = value;
           }
       }
       public string Name
       {
           get
           {
               return this._name; //(Read-Only)
           }
       }
       //CONSTRUCTOR+++++++++++++++++++++++++++++++++
       public Planet(string name, double diameter, double mass)
       {
           this._name = name;
           this._diameter = diameter;
           this._mass = mass;
       }
      
      
       // OVERRIDDEN METHODS+++++++++++++++++++++++++++++
       public override string ToString()
       {
           return this.Name + " is the name and " + this.Diameter + " is the Diameter and " + this.Mass + " is the mass. ";
           
       }
   }
}
