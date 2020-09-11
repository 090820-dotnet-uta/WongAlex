using System;
using System.Collections.Generic;

namespace RPS_Game_NoDB
{
    public class Player
    {
        public string Name { get; set; } = "null";

        //public string name;
        //private string name;
        // public void SetName(string name){
        //     this.name = name;
        // }



        public List<Game> games = new List<Game>();
        public Dictionary<string, int> record = new Dictionary<string, int>()
        {
            {"wins", 0},
            {"losses", 0}
        };
        //"wins" = 2
        //"losses" = 3
        //record."wins"++;

        public static Player CheckPlayer(List<Player> players) {
             //get the player name
                System.Console.WriteLine("What is your name?");
                string playerName = Console.ReadLine();
                Player p1 = new Player();//p1 is null here.

                // check the list of players to see if this payer is a returning player.
                foreach (Player item in players)
                {
                    if (item.Name == playerName)
                    {
                        p1 = item;
                        System.Console.WriteLine("You are a returning player");
                    }
                }

                if (p1.Name == "null")//means the players name was not found above
                {
                    p1.Name = playerName;
                    players.Add(p1);
                }
                return p1;
        }

    }
}