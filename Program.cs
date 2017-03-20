using System;
using darts.Models;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //declare varaible to hold numbef of players.
            int num_players = 0;
            Console.Clear();
            Console.WriteLine("How many players?");
            string NumPlayersInput = Console.ReadLine();

            //convert inputed number to interger and store in num_players
            bool validNumPlayers = int.TryParse(NumPlayersInput, out num_players);

            //Create a list to hold the player objects.
            List<Player> players = new List<Player>();

            //loop over number players to create each player object
            for (int i = 0; i < num_players; i++)
            {
                //Read in the name of the player
                Console.WriteLine($"What is the name of player {i}?");
                string playerName = Console.ReadLine();
                //create the new player object with that name.
                var p = new Player(playerName);
                //add the object to the list.
                players.Add(p);
            }

            //loop over the list object and score each throw.
            foreach (var player in players) 
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Net Score for {player.Name} is {player.Score}");
                    Console.WriteLine($"Throw number {i+1} for {player.Name}?");

                    int int_throwValue = 0;
                    string throwValue = Console.ReadLine();
                    bool validThrowValue = int.TryParse(throwValue, out int_throwValue);
                    while (!player.isThrowValid(int_throwValue))
                    {
                        Console.WriteLine("That throw is not valid, reenter.");
                        throwValue = Console.ReadLine();
                        validThrowValue = int.TryParse(throwValue, out int_throwValue);  
                    }
                    player.throwValue(int_throwValue);
                }
            }
        }
    }
}
