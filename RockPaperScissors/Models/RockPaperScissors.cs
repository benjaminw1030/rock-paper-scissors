using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class RPSBattle
  {
    public static string RPSWinner(string playerOneInput, string playerTwoInput)
    {
      if ((playerOneInput == "rock" && playerTwoInput == "scissors")
      || (playerOneInput == "paper" && playerTwoInput == "rock")
      || (playerOneInput == "scissors" && playerTwoInput == "paper"))
      {
        return "player 1";
      }
        else if ((playerTwoInput == "rock" && playerOneInput == "scissors")
      || (playerTwoInput == "paper" && playerOneInput == "rock")
      || (playerTwoInput == "scissors" && playerOneInput == "paper"))
      {
        return "player 2";
      }
      else
      {
        return "draw";
      }
    }
  }
}