using System;
using System.Collections.Generic;

namespace darts.Models
{
    //create the player object template (class)
    public class Player
    {
        public string Name;
        public int Score = 501;

        //write constructor function
        public Player(string name)
        {
            Name = name;
        }

        //method to reduce score by a given amount.
        //returns the current score (int)
        public int throwValue(int throwValue)
        {
            Score = Score - throwValue;
            return Score; 
        }

        public bool isThrowValid(int throwValue)
        {
            List<int> validThrowScores = new List<int>();
            validThrowScores.Add(50);
            validThrowScores.Add(25);
            
            for(int i = 1; i < 21; i++)
            {
                validThrowScores.Add(i);
                validThrowScores.Add(i*2);
                validThrowScores.Add(i*3);
            }

            bool outValue = false;
            foreach(int score in validThrowScores)
            {
                if (score == throwValue)
                {
                    return true; 
                }
            }
            return false;
        }

        public bool isWinner(int throwValue)
        {
            if (Score - throwValue == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}