using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace projEncapsulation
{
    public class BeerEncapsulator
    {
        public BeerEncapsulator(int avalaibleBottles, double avalaibleBeerVolume, int avalaibleCapsules)
        {
        private int _avalaibleBeerVolume;
        int avalaibleBottles;
        private int _avalaibleBottles = 15;
        private int _avalaibleCapsule = 15;
        public string wantedBottle = "";
        public bool myBooleen = false;
        }
    

        public double GetAvalableBeerVolume()
        {
            return _avalaibleBeerVolume;
        }
        public int GetAvailableBottles()
        {  
            return _avalaibleBottles; 
        }

        public double AdBeer()
        {
         Console.WriteLine("Combien de volumes en centililtres, voulez vous ?");
          string stringX=Console.ReadLine();
          double x=double.Parse(stringX);
         _avalaibleBeerVolume = Math.Round(_avalaibleBeerVolume + x*0.33,2);
          return _avalaibleBeerVolume;
          }

        }

 }       
}



