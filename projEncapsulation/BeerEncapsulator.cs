using System;

namespace projEncapsulation
{
    public class BeerEncapsulator
    {
        // Declaration des variables privée
        private decimal _availableBeerVolume;
        private int _availableBottles;
        private int _availableCapsules;

        //Instantation dans le constructeur
        public BeerEncapsulator(decimal initBeerVolume, int initBottles, int initCapsules)
        {
            _availableBeerVolume = initBeerVolume;
            _availableBottles = initBottles;
            _availableCapsules = initCapsules;
        }
        
        // Mises en places des propriétes
        public int AvailableBottles
        {
            get { return _availableBottles; }//permet d'acceder à la valeur privée sans l'exposé
            set { _availableBottles = value; }//modifie la valeur privée
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

        //Methode AddBeer qui permet d'accedder au volume et pouvoir le modifier

        public decimal AddBeer(decimal volumeBeer)
        {
            _availableBeerVolume += volumeBeer;
            return _availableBeerVolume;
        }

        //Methode qui va chercher a produire les bouteilles
        
        public int ProduceEncapsulatedBeer(int wantedBottles)
        {
            int produceBottles = 0;

            while (produceBottles < wantedBottles)
            {
                if (_availableBottles > 0 && _availableCapsules > 0 && _availableBeerVolume >= 33)
                {
                    _availableBeerVolume -= 33;
                    _availableBottles--;
                    _availableCapsules--;
                    produceBottles++;
                }
                else
                {
                    if (_availableBeerVolume < 33)
                    {
                        Console.WriteLine("Il n'y a plus assez de bière.");
                        Console.WriteLine("Vous avez fabriqué " + produceBottles + " bouteille(s) de bière.");
                    }
                    else if (_availableCapsules == 0)
                    {
                        Console.WriteLine("Il n'y a plus de capsules.");
                        Console.WriteLine("Vous avez fabriqué " + produceBottles + " bouteille(s) de bière.");
                    }
                    else if (_availableBottles == 0)
                    {
                        Console.WriteLine("Il n'y a plus de bouteilles.");
                        Console.WriteLine("Vous avez fabriqué " + produceBottles + " bouteille(s) de bière.");
                    }
                    break;
                }
                Console.WriteLine("vous avez fabriqué " + produceBottles + " bouteille(s) de bière. ");
            }

            return produceBottles;
        }
    }
}
