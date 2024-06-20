using projEncapsulation;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;



class MainProgram
{
    public static void Main(string[] args)
    {

        Console.Write("Veuillez entrer le nombre de litres. ");
        string stringVolumeBeer = Console.ReadLine();
        double volumeBeer = double.Parse(stringVolumeBeer);

        // Convertir le volume de litres en centilitres
        decimal volumeBeerInCentilitres = (decimal)(volumeBeer * 100);

        Console.WriteLine(" Veuillez entrer le nombre de bouteilles vides.  ");
        string stringBottles = Console.ReadLine();
        int bottles = Convert.ToInt32(stringBottles);

        Console.WriteLine("Veuillez entrer le nombre de capsules. ");
        string stringCapsules = Console.ReadLine();
        int capsules = Convert.ToInt32(stringCapsules);

        Console.WriteLine("Combien souhaitez vous en faire ? ");
        string stringNumbBottles = Console.ReadLine();
        int numbBottles = Convert.ToInt32(stringNumbBottles);

        BeerEncapsulator beer1 = new BeerEncapsulator(volumeBeerInCentilitres, bottles, capsules);

        int producedBottles = beer1.ProduceEncapsulatedBeer(numbBottles);
        
    }



}