using System;

namespace RPS_Game_NoDB
{
    public class Round
    {
        public Player player1 { get; set; }
        public Player Computer { get; set; }
        public Choice p1Choice { get; set; }
        public Choice ComputerChoice { get; set; }
        public int Outcome { get; set; } = 0; //0 == Tie, 1 ==P1 wins, 2 == computer wins
        public Game game { get; set; }

        public static int PlayRound(Round round, int roundCounter, Game game) {
            while (game.winner.Name == "null")
            {
                //get the choices for the 2 players
                //insert the players choices directly into the round
                //round.p1Choice = (Choice)rand.Next(3);//this will give a random number starting at 0 to arg-1;
                //let the player choose thier choice
                bool rpsInput;
                int rpsChoice;
                Random rand = new Random();

                //check to see if user input is a valid response
                do {
                    Console.WriteLine("Choose your move: 0) Rock, 1) Paper, 2) Scissors");
                    string choiceInput = Console.ReadLine();
                    rpsInput = int.TryParse(choiceInput, out rpsChoice );
                } while(!rpsInput|| rpsChoice < 0 || rpsChoice > 2);

                //set player choice to round
                round.p1Choice = (Choice)rpsChoice;
                round.ComputerChoice = (Choice)rand.Next(3);

                Console.WriteLine($"You chose => {round.p1Choice}");
                Console.WriteLine($"The computer chose => {round.ComputerChoice}");
                //check the choices to see who won.
                if (round.p1Choice == round.ComputerChoice)
                {
                    round.Outcome = 0; // it’s a tie . the default is 0 so this line is unnecessary.
                    System.Console.WriteLine("this round was a tie");
                    return 0;
                }
                else if ((int)round.p1Choice == ((int)round.ComputerChoice + 1) % 3)
                { //If users pick is one more than the computer’s, user wins
                    round.Outcome = 1;
                    return 1;
                }
                else
                { //If it’s not a tie and p1 didn’t win, then computer wins.
                    round.Outcome = 2;
                    return 2;
                }
            }
            return 0;
        }
    }
}