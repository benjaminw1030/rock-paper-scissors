using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissors
  {
    [TestMethod]
    public void RPSWinner_OutputsWinningPlayer_String()
    {
      string playerOneInput = "rock";
      string playerTwoInput = "scissors";
      string winner = RPSBattle.RPSWinner(playerOneInput, playerTwoInput);
      Assert.AreEqual("player 1", winner);
    }

    [TestMethod]
    public void RPSWinner_OutputsOtherWinningPlayer_String()
    {
      string playerOneInput = "paper";
      string playerTwoInput = "scissors";
      string winner = RPSBattle.RPSWinner(playerOneInput, playerTwoInput);
      Assert.AreEqual("player 2", winner);
    }

    [TestMethod]
    public void RPSWinner_OutputsTie_String()
    {
      string playerOneInput = "paper";
      string playerTwoInput = "paper";
      string winner = RPSBattle.RPSWinner(playerOneInput, playerTwoInput);
      Assert.AreEqual("draw", winner);
    }
  }
}