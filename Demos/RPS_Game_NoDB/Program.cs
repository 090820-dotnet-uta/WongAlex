using System;
using System.Collections.Generic;
using System.Linq;

namespace RPS_Game_NoDB
{
    public enum Choice
    {
        Rock,//can be accessed with a 0
        Paper,//can be accessed with a 1
        Scissors//can be accessed with a 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            List<Game> games = new List<Game>();
            List<Round> rounds = new List<Round>();
            Player computer = new Player() { Name = "Computer" };//instantiate a Player and give a value to the Name all at once.
            players.Add(computer);
            int choice;
            int gameCounter = 1;

            do//game loop
            {
                //get a choice from the user (play or quit)
                choice = PlayOrQuit(gameCounter);

                if (choice == 2)//if the user chose 2, break out of the game.
                {
                    break;
                }

                Player p1 = Player.CheckPlayer(players);
                Game game = new Game();// create a game
                game.Player1 = p1;//
                game.Computer = computer;//

                Random rand = new Random();

                int roundCounter = 1;
                //play rounds till one player has 2 wins
                //assign the winner to the game and check that property to break out of the loop.
                while (game.winner.Name == "null")
                {
                    Round round = new Round();//declare a round for this iteration
                    System.Console.WriteLine($"\n\t\tThis is round #{roundCounter++}\n");
                    round.game = game;// add the game to this round
                    round.player1 = p1;// add user (p1) to this round
                    round.Computer = computer;// add computer to this round

                    //play a single round and set the round outcome                  
                    round.Outcome = Round.PlayRound(round, roundCounter, game);

                    game.rounds.Add(round);//add this round to the games List of rounds

                    //see if anyone has won the game
                    game.CheckWinner();  
                }//end of rounds loop

                games.Add(game);



                //play rounds till one player has 2 wins
                //record each round into the game

                //record the game

                //increment wins/losses for each player

                //print out the game results - rounds data



            } while (choice != 2);//end of game loop


            PrintAllCurrentData(games, players, rounds);




            //on quitting....
            //print out the win.loss record for all players

        }//end of main

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

    }//end of program
}//end of namaespace
