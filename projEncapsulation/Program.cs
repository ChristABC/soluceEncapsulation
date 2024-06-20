using projEncapsulation;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;



class MainProgram
{
    public static void Main(string[] args)
    {

        Console.Write("Veuillez entrer le nombre de litres. ");
        string stringLitresBeer = Console.ReadLine();
        int litresBeer = Convert.ToInt32(stringLitresBeer);

        Console.WriteLine(" Veuillez entrer le nombre de bouteilles vides.  ");
        string stringEmptyBottles = Console.ReadLine();
        int emptyBottles = Convert.ToInt32(stringEmptyBottles);

        Console.WriteLine("Veuillez entrer le nombre de capsules. ");
        string stringCapsules = Console.ReadLine();
        int capsulesBottles = Convert.ToInt32(stringCapsules);

        Console.WriteLine("Combien souhaitez vous en faire ? ");
        string stringNumbBottles = Console.ReadLine();
        int numbBottles = Convert.ToInt32(stringEmptyBottles);

        BeerEncapsulator beer1 = new BeerEncapsulator(litresBeer, emptyBottles, capsulesBottles, numbBottles);

        beer1.ProduceEncapsulatedBeer(1);


    }



}