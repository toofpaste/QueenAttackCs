using System;
using System.Collections.Generic;

namespace QueenAttack
{
  public class QueenAttack
  {
    public bool QueenAttackAnalyzer(int queenX, int queenY, int opponentX, int opponentY)
    {
      if (queenX == opponentX || queenY == opponentY)
      {
        return true;
      }
      else if (Math.Abs(queenX - opponentX) == Math.Abs(queenY - opponentY))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
