using projEncapsulation;
using System;
using System.Globalization;



class MainProgram
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine(" Combien de bouteilles, voulez vous ? ");
        string stringLitresBeer = Console.ReadLine(); 
        int litresBeer = Math.Abs(Int32.Parse(stringLitresBeer));
        

        Console.WriteLine(" Combien de bouteilles vides, avez vous ? ");
        string stringEmptyBottles = Console.ReadLine();
        int emptyBottles = Math.Abs(Int32.Parse(stringEmptyBottles));

        Console.WriteLine("Combien de capsules, avez vous ? ");
        string stringCapsules = Console.ReadLine();
        int capsulesBottles = Math.Abs(Int32.Parse(stringEmptyBottles));

        Console.WriteLine("Combien vous en voulez ? ");
        string stringNumbBottles = Console.ReadLine();
        int numbBottles = Math.Abs(Int32.Parse(stringEmptyBottles));

        BeerEncapsulator beerEncapsulator = new BeerEncapsulator(litresBeer, emptyBottles, capsulesBottles,numbBottles);

    }



}