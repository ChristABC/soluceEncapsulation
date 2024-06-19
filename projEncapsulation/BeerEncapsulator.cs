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
        private double avalaibleBeerVolume;
        private int avalaibleBottles;
        private int avalaibleCapsules;
        public BeerEncapsulator(int _avalaibleBottles, double _avalaibleBeerVolume, int _avalaibleCapsules)
        {
            double avalaibleBeerVolume=_avalaibleBeerVolume;
            int avalaibleBottles=_avalaibleBottles;
            int avalaibleCapsules=_avalaibleCapsules;
        }
        public double GetAvalableBeerVolume()
        {
            return avalaibleBeerVolume;
        }
        public int GetAvailableBottles()
        {
            return avalaibleBottles;
        }

        public double AdBeer()
        {
            Console.WriteLine("Combien de volumes en centililtres, voulez vous ?");
            string stringX = Console.ReadLine();
            double x = double.Parse(stringX);
            avalaibleBeerVolume = Math.Round(avalaibleBeerVolume + x * 0.33, 2);
            return avalaibleBeerVolume;
        }

        public void ProduceEncapsulatedBeer()
        {
            //Maintenant le plus dire et a faire
            //une partie mise en bouteille et encapule
        }
    }

}

    



