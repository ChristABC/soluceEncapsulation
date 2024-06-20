using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projEncapsulation
{
    public class BeerEncapsulator
    {

        private decimal _availableBeerVolume;
        private int _availableBottles;
        private int _availableCapsules;

        public BeerEncapsulator(decimal initBeerVolume, int initBottles, int initCapsules)
        {
            decimal _avalaibleBeerVolume = initBeerVolume;
            int _avalaibleBottles = initBottles;
            int _avalaibleCapsules = initCapsules;

        }

        public int AvailableBottles
        {
            get { return _availableBottles; }
            set { _availableBottles = value; }
        }

        public int AvailableCapsules
        {
            get { return _availableCapsules; }
            set { _availableCapsules = value; }
        }

        public decimal AvailableBeerVolume
        {
            get { return _availableBeerVolume; }
            set { _availableBeerVolume = value; }
        }

        public decimal Adbeer(decimal volumeBeer)
        {
            _availableBeerVolume = _availableBeerVolume - 33;
            return _availableBeerVolume;
        }


        public int ProduceEncapsulatedBeer(int wantedBottles)
        {
            int produceBottles = 0;


            while (produceBottles < wantedBottles) //On demande à la boucle while de ne pas dépacer l'ojectif
            {
                if (_availableBottles > 0 && _availableCapsules > 0 && _availableBeerVolume > 33)
                {
                    _availableBeerVolume = _availableBeerVolume - 33;
                    _availableBottles--;
                    _availableCapsules--;
                    produceBottles++;
                }

                else
                {
                    if (_availableBeerVolume < 33)
                    {
                        Console.WriteLine("Il n'a plus assez de bière");
                        Console.WriteLine("Vous avez fabriquer  " + produceBottles + " bouteilles de bières ");
                    }
                    else if (_availableCapsules == 0)
                    {
                        Console.WriteLine("Il n'y a plus de capsules. ");
                        Console.WriteLine("Vous avez fabriquer  " + produceBottles + "de bouteilles de bières ");
                    }

                    else if(_availableBottles == 0)
                    {
                        Console.WriteLine("Il n'y a plus de bouteilles");
                        Console.WriteLine("Vous avez fabriquer " + produceBottles + "de bières ");
                    }
                    else
                    {
                        return produceBottles; 
                    }
                    
                }
            }
        }
    }
}