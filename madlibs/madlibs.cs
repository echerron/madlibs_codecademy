using System;

namespace madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
      This program will generate a Mad Lib story using input from the user
      Author: Eric C. Herron
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Welcome To MadLibs! The Program is Starting...");

      // Give the Mad Lib a title:
      string title = "A Busy Day!";
      Console.WriteLine(title);

      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      Console.Write("Enter an adjective: ");
      string firstAdjective = Console.ReadLine();

      Console.Write("Enter another adjective: ");
      string secondAdjective = Console.ReadLine();

      Console.Write("Enter one more adjective: ");
      string thirdAdjective = Console.ReadLine();

      Console.Write("Enter one verb: ");
      string verb = Console.ReadLine();

      Console.Write("Enter a noun: ");
      string firstNoun = Console.ReadLine();

      Console.Write("Enter another noun: ");
      string secondNoun = Console.ReadLine();

      Console.Write("Your favorite animal: ");
      string animal = Console.ReadLine();

      Console.Write("Your favorite food: ");
      string food = Console.ReadLine();

      Console.Write("Name a fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("Name a Super Hero: ");
      string superHero = Console.ReadLine();

      Console.Write("Name a country: ");
      string country = Console.ReadLine();

      Console.Write("Your favorite dessert: ");
      string dessert = Console.ReadLine();
      
      Console.Write("The Year you were born: ");
      string year = Console.ReadLine();


      // The template for the story:

      string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {animal}s ruled the world";


      // Print the story:
      Console.Write(story);
      
        }
    }
}
