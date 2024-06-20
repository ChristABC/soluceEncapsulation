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
        
        private double _availableBeerVolume;
        private int _availableBottles;
        private int _availableCapsules;
        
        public BeerEncapsulator(double initBeerVolume, int initBottles, int initCapsules)
        {
            double _avalaibleBeerVolume = initBeerVolume;
            int _avalaibleBottles = initBottles;
            int _avalaibleCapsules = initCapsules;
                   
        }


        public static double GetAvalaibleBeerVolume(double avalaibleBeerVolume)
        {
            double volumeBeer = avalaibleBeerVolume;
            return volumeBeer;
        }


        public double AdBeer()
        {
            volumeBeer = volumeBeer - 0.33;
            volumeBeer = Math.Round(volumeBeer, 2);
            return volumeBeer;

        }

        public int BottleMoins()
        {
            bottlesVide = bottlesVide - 1;
            return bottlesVide;

        }

        public int CapsulesMoins()
        {
            caps = caps - 1;
            return caps;

        }
        
        public int ProduceEncapsulatedBeer(int wantedBottles)
        {
            int produceBottles = 0;
            const double beerParBottles = 33.0;
            
            while (_availableBottles > 0 && _availableCapsules > 0 && _availableBeerVolume > beerParBottles)
            {
                _availableBeerVolume -=beerParBottles;// equivaut à faire moins 0.33 a chaque fois
                _availableBottles--;
                _availableCapsules--;
                produceBottles++;
            }

            if (_availableBeerVolume < beerParBottles )
            {
                Console.WriteLine("Il n'a plus assez de bière");
                Console.WriteLine("Vous avez fabriquer  " + produceBottles + " bouteilles de bières ");
                
            }

            else if (_availableCapsules==0)
            {
                Console.WriteLine("Il n'y a plus de capsules. ");
                Console.WriteLine("Vous avez fabriquer  " + produceBottles + "de bouteilles de bières ");
            }

            else if (_availableBottles ==0)
            {
                Console.WriteLine("Il n'y a plus de bouteilles");
                Console.WriteLine("Vous avez fabriquer " + produceBottles + "de bières ");
            }

            else
            {
                Console.WriteLine("Il n'a pas assez d'éléments pour la fabrication. ");
             }
            Console.WriteLine($"Vous avez fabriqué {produceBottles} bouteilles de bière.");
            return produceBottles;
        }
    }

    



