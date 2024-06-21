using projEncapsulation;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;



class MainProgram
{
    public static void Main(string[] args)
    {

        Console.Write("Veuillez entrer le volume en centilitres. ");
        decimal volumeBeer = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine(" Veuillez entrer le nombre de bouteilles vides.  ");
        int bottles = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Veuillez entrer le nombre de capsules. ");
        int capsules = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Combien souhaitez vous en faire ? ");
        int numbBottles = Convert.ToInt32(Console.ReadLine());

        BeerEncapsulator beer1 = new BeerEncapsulator(volumeBeer, bottles, capsules);

        int producedBottles = beer1.ProduceEncapsulatedBeer(numbBottles);
        
    }



}