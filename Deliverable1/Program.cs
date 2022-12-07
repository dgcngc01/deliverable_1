// Author: Doug Coffey
// Bootcamp Prework Unit 1
// 12/7/2022
// C# program to figure out quanity of food needed to make PBJs for a given number of people

using System;
using System.IO;

class PBJ
{
    // Main Method
    public static void Main()
    {

        // initialize variables
        int numPeople;
        int numSlices;
        int numLoaves;
        int remainder; 
        int numTbspPB;
        int numJarsOfPB;
        int numTspJelly;
        int numJarsOfJelly;
        string restart;

        // measurements for incredients
        const int oneLoaf = 28;
        const int slicesPerSandwich = 2;
        const int tbspPerPBJar = 32;
        const int tspPerJellyJar = 48;
        const int tbspPerPBSandwhich = 2;
        const int tspPerJellySandwhich = 4;
        const string indent = "     ";

        // Ask for number of people and do the calculations
        Console.WriteLine("How many people are we making PB&J sandwiches for? ");
        numPeople = int.Parse(Console.ReadLine());
        numSlices = numPeople * slicesPerSandwich;             // 2 slices per sandwhich    
        numTbspPB = numPeople * tbspPerPBSandwhich;            // 1 sandwhich per person
        numTspJelly = numPeople * tspPerJellySandwhich;
        numLoaves = numSlices / oneLoaf;
        remainder = numSlices % oneLoaf;                       // see if there is a remainder, if so add 1.
        if (remainder != 0);
        {
            numLoaves = numLoaves + 1;
            remainder = 0;  
        }

        numJarsOfPB = numTbspPB / tbspPerPBJar;
        remainder = numTbspPB % tbspPerPBJar;                   // see if there is a remainder, if so add 1.
        if (remainder != 0) ;
        {
            numJarsOfPB = numJarsOfPB + 1;
            remainder = 0;
        }

        numJarsOfJelly = numTspJelly / tspPerJellyJar;
        remainder = numTspJelly % tspPerJellyJar;              // see if there is a remainder, if so add 1.
        if (remainder != 0)
        {
            numJarsOfJelly = numJarsOfJelly + 1;
            remainder = 0;
        }

        // write out initial numbers - sandwhich level details
        Console.WriteLine("\n" + "You need: " + "\n");
        Console.WriteLine( indent + numSlices + " slices of bread");
        Console.WriteLine(indent + numTbspPB + " tablespoons of peanut butter");
        Console.WriteLine(indent + numTspJelly + " tablespoons of jelly");

        // write out final numbers - bulk details
        Console.WriteLine("\n" + indent + "which is... " + "\n");
        Console.WriteLine(indent + numLoaves + " loaves of bread");
        Console.WriteLine(indent + numJarsOfPB + " jars of peanut butter");
        Console.WriteLine(indent + numJarsOfJelly + " jars of jelly");


        // Logic to close the console or restart.
        Console.WriteLine("\n" + "Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
        restart = Console.ReadLine();

        if (restart == "yes" || restart == "y")
        {
            Console.Clear();
            Main();
        }
        else
        { 
            Console.WriteLine("\n" + "Goodbye");
            Environment.Exit(0);
        }       
    }
}
