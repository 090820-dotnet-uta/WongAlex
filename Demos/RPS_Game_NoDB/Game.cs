using System;
using System.Collections.Generic;
using System.Linq;

namespace RPS_Game_NoDB
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Computer { get; set; }
        public List<Round> rounds = new List<Round>();
        public Player winner = new Player();

        public void CheckWinner() {
            //search the game.rounds List<> to see if one player has 2 wins
            //if not loop to another round
            int numP1Wins = this.rounds.Count(x => x.Outcome == 1);
            int numComputerWins = this.rounds.Count(x => x.Outcome == 2);

            //assign the winner to the game and increment wins and losses for both
            System.Console.WriteLine($"\tp1wins => {numP1Wins} \n\tcomputer wins {numComputerWins}");
            if (numP1Wins == 2)
            {
                this.winner = this.Player1;
                this.Player1.record["wins"]++;//increments wins and losses.
                this.Computer.record["losses"]++;//increments wins and losses.
                this.winner = this.Player1;
                Console.WriteLine("\n------------YOU WIN------------\n");
            }
            else if (numComputerWins == 2)
            {
                this.winner = this.Computer;
                this.Player1.record["losses"]++;//increments wins and losses.
                this.Computer.record["wins"]++;//increments wins and losses.
                this.winner = this.Computer;
                Console.WriteLine("\n------------YOU LOSE------------\n");
            }
        }
    }
}