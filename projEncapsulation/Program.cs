using projEncapsulation;
using System;
using System.Globalization;



class MainProgram
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine(" Combien de litres de bière, avez vous ? ");
        string stringLitresBeer = Console.ReadLine(); 
        double LitresBeer = Double.Parse(stringLitresBeer);

        Console.WriteLine(" Combien de bouteilles vides, avez vous ? ");
        string stringEmptyBottles = Console.ReadLine();
        double emptyBottles = Double.Parse(stringEmptyBottles);

        Console.WriteLine("Combien de capsules, avez vous ? ");
        string stringCapsules = Console.ReadLine();
        double capsules = Double.Parse(stringEmptyBottles);

        BeerEncapsulator beerEncapsulator = new BeerEncapsulator(LitresBeer,emptyBottles,capsules);

    }



}