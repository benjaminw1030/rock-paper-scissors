using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("ROCK PAPER SCISSORS");
      Console.WriteLine("--------------------------");
      Console.WriteLine("");
      Console.WriteLine("Pick between rock, paper, and scissors to see who wins!");
      Console.WriteLine("");
      Console.WriteLine("Player one's move:");
      string playerOneMove = Console.ReadLine();
      Console.WriteLine("");
      Console.WriteLine("Player two's move:");
      string playerTwoMove = Console.ReadLine();
      string winner = RPSBattle.RPSWinner(playerOneMove, playerTwoMove);
      Console.WriteLine("");
      Console.WriteLine($"The winner is: {winner}!");
    }
  }
}