using System;


public class Function 
{
    //every 1h of cycling drink 0.5l of water
    public static int Liters(double time) => (int)(time * 0.5);
   

}

    public class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Input how much time have youe spent: ");
        double time = Double.Parse(Console.ReadLine());
        Console.WriteLine("You have dranked " + Function.Liters(time) + " liters of water");
    }
    }

