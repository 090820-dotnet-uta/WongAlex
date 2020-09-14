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
                choice = RPSHelperMethods.PlayOrQuit(gameCounter);

                if (choice == 2)//if the user chose 2, break out of the game.
                {
                    break;
                }
                
                //check if player is a returning player or a new player
                Player p1 = Player.CheckPlayer(players);

                Game game = new Game();// create a game
                game.Player1 = p1;
                game.Computer = computer;

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
                    //record each round into the game
                    game.rounds.Add(round);//add this round to the games List of rounds

                    //see if anyone has won the game and increment wins and losses
                    game.CheckWinner();  
                }//end of rounds loop
                
                //record the game
                games.Add(game);
                
            } while (choice != 2);//end of game loop
            //on quitting....
            //print out the win.loss record for all players
            RPSHelperMethods.PrintAllCurrentData(games, players, rounds);
        }//end of main
    }//end of program
}//end of namaespace
