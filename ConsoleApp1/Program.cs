using System;

namespace ConsoleApp1
{
    public static class Game
    {
        static string myCharacter = "Levi";

        public static void StartGame()
        {
          Console.WriteLine("Welcome to my adventure :)");

          Console.WriteLine("I hope it's fun.");
          NameCharacter();
          Choice();
        }
        static void NameCharacter()
        {
          Console.WriteLine("What is the name of your character?");
          myCharacter = Console.ReadLine();

            Console.WriteLine("Ok. Your character is " + myCharacter + ". Good luck!");
         }
        static void Choice()
        {
            string input = "";
            Console.WriteLine(myCharacter + " comes to a fork in the road. Left or right?");
            input = Console.ReadLine();
            input = input.ToLower();
            if (input == "left")
            {
                Console.WriteLine(myCharacter + " heads to the left.");
            }
            else
            {
                Console.WriteLine(myCharacter + " heads to the right.");
            }
            Console.WriteLine("They walk past an old building with peeling paint and colorful graffiti. There is a sign flickering weakly above the awning that reads");
            Console.WriteLine("///////");
            Console.WriteLine("Ottobar");
            Console.WriteLine("///////");
            Console.WriteLine("They can't see anything through the dark windows.");
            Console.WriteLine("Go inside, yes or no?");
            string walkIn = "";
            walkIn = Console.ReadLine();
            walkIn = walkIn.ToLower();
            if (walkIn == "yes")
            {
                Console.WriteLine(myCharacter + " pulls open the door and steps inside, waiting for their eyes to adjust. The bouncer looks over bored. " + myCharacter + " walks past the bouncer and into the bar. They see a sign on the wall that tells them a band called MS Paint is playing. The mosh pit is going strong.");
                Console.WriteLine("Join the mosh, yes or no?");
                var moshIn = "";
                moshIn = Console.ReadLine();
                moshIn = moshIn.ToLower();
                if (moshIn == "yes")
                {
                    Console.WriteLine(myCharacter + " pushes into the mosh. Bodies surround them, and someone kicks them in the head. Everything feels right in the world.");
                }
                else
                {
                    Console.WriteLine(myCharacter + " walks out of the bar and back down the street. Snow has just fallen, it's a little past dusk, and a dense fog clouds the view far into the distance. Cars drive past. A dying streetlight flashes three times before finally going out. " + myCharacter + " no longer remembers why they came out here in the first place. They turn around and start the long walk home, winter closing in on them from all sides.");
                }    
            }
            else
            {
                Console.WriteLine(myCharacter + " walks down the dark street. Snow has just fallen, it's a little past dusk, and a dense fog clouds the view far into the distance. Cars drive past. A dying streetlight flashes three times before finally going out. " + myCharacter + " no longer remembers why they came out here in the first place. They turn around and start the long walk home, winter closing in on them from all sides.");
            }


        }
        
       
    

    }
    class Item
    {

    }
    class Program
    {
        static void Main()
        {
        Game.StartGame();
        Console.ReadKey(); 
        }
    }
}
