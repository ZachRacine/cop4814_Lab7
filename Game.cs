//This file was uploaded to and edited through GitHub for Lab 7
//This comment is part of a double modification
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        //Define properties for Game class
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }

        //Public default constructor for Game class
        public Game() { }

        //Constructor to initialize class properties from parameter values
        public Game(string Team1, string Team2, int Team1Score, int Team2Score)
        {
            this.Team1 = Team1;
            this.Team2 = Team2;
            this.Team1Score = Team1Score;
            this.Team2Score = Team2Score;
        }

        //ToString method to override default ToString
        public override string ToString()
        {
            return String.Format(Team1 + " " + "(" + Team1Score + ")" + " - " + Team2 + " " + "(" + Team2Score + ")");
        }

    }
}
