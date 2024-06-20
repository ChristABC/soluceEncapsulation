using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public double volumeBeer;
        public int caps;
        public int bottlesVide;
        public int fullBottles;
        public BeerEncapsulator(int _avalaibleBottles, double _avalaibleBeerVolume, int _avalaibleCapsules, int wantBottles)
        {
            double avalaibleBeerVolume=_avalaibleBeerVolume;
            int avalaibleBottles=_avalaibleBottles;
            int avalaibleCapsules=_avalaibleCapsules;
            int wantedBottles =wantBottles;
        }

       
        public static double GetAvalaibleBeerVolume(double avalaibleBeerVolume)
        {
            double BeerVolume = avalaibleBeerVolume;
            return BeerVolume;
        }

        public static int GetBouteillesVoulu(int wantedBottles)
        {
            int bouteilleVoulu = wantedBottles;
            return bouteilleVoulu;
        }

        public int GetAvalaibleBottles(int avalaibleBottles)
        {
            int bottlesVide = avalaibleBottles;
            return bottlesVide;
        }

        
        public int GetAvalaibleCapsules(int avalaibleCapsules)
        {
            int caps = avalaibleCapsules;
            return caps;
        }
       
        public double AdBeer()
        {
            volumeBeer = volumeBeer - 0.33;
            volumeBeer = Math.Round(volumeBeer, 2);
            return avalaibleBeerVolume;
            
        }

        public int BottleMoins()
        {
            caps = caps - 1;           
            return avalaibleBottles;
            
        }

        public int CapsulesMoins()
        {
            caps = avalaibleBottles - 1;
            return avalaibleBottles;

        }
        int counter = 0;
        public int ProduceEncapsulatedBeer(int bouteilleVoulu)
        {
            for (int i = 0, i <  bouteilleVoulu, i++)
            {
                AdBeer();
                CapsulesMoins();
                BottleMoins();
                counter++;
                if (AdBeer() < 0.33)
                {
                    Console.WriteLine("Il n'a plus assez de bière");
                    Console.WriteLine("Vous avez fabriquer " + counter + "de bières ");
                    return counter;
                }
                else if (CapsulesMoins() == 0)
                {
                    Console.WriteLine("Il n'y a plus de capsules. ");
                    Console.WriteLine("Vous avez fabriquer " + counter + "de bières ");
                    return counter;
                }
                else if (BottleMoins() == 0)
                        {
                    Console.WriteLine("Il n'y a plus de bouteilles");
                    Console.WriteLine("Vous avez fabriquer " + counter + "de bières ");
                    return counter;
                        }
                else
                {
                    Console.WriteLine("Il n'a pas assez d'éléments pour la fabrication. ");
                    return 0;
                }
    }

}

    



