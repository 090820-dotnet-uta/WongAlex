using System;
using System.Collections.Generic;

namespace RPS_Game_NoDB
{
    public class RPSHelperMethods
    {
        public static int GetRandomNum() {
            Random rand = new Random();
            return rand.Next();
        }
        public static int GetRandomNum(int x, int y) {
            Random rand = new Random();
            return rand.Next(x, y);
        }
         public static void PrintAllCurrentData(List<Game> games, List<Player> players, List<Round> rounds)
        {
            int gameNum = 1;
            foreach (var game in games)
            {
                Console.WriteLine($"\tGame #{gameNum++}\n");
                System.Console.WriteLine($"Player1 Name => {game.Player1.Name}\ncomputer Name => {game.Computer.Name}\n winner is => {game.winner.Name}");
                System.Console.WriteLine($"\n\t--- Here are the games rounds ---\n ");
                foreach (Round round in game.rounds)
                {
                    System.Console.WriteLine($"\tplayer1 => {round.player1.Name}\n\tp1 choice => {round.p1Choice}");
                    System.Console.WriteLine($"\tplayer2 => {round.Computer.Name}\n\tcomputer choice => {round.ComputerChoice}");
                    System.Console.WriteLine($"\tthe Outcome of this round is => {round.Outcome}\n");
                }
            }
            System.Console.WriteLine("Here is the list of players.");
            foreach (var player in players)
            {
                System.Console.WriteLine($"Player Name: {player.Name}\n\twins: {player.record["wins"]} losses: {player.record["losses"]}");
            }
        }

        public static int PlayOrQuit(int gameCounter) {
            bool inputInt;
            int choice;
                do//prompt loop
                {
                    System.Console.WriteLine("Please choose 1 for Play or 2 for Quit");
                    string input = Console.ReadLine();
                    inputInt = int.TryParse(input, out choice);
                } while (!inputInt || choice <= 0 || choice >= 3);//end of promt loop

                System.Console.WriteLine($"\n\t\tThis is game #{gameCounter++}\n\n");
                return choice;
                //System.Console.WriteLine("made it out of the loop");
        }

    }
}