﻿public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (PairScoreCalculator.IsNonsense1(st))
        {
            return PairScoreCalculator.CalculateScore(die1, die2, die3, die4, die5);
        }

        if (TwoPairScoreCalculator.IsNonsense2(st))
        {
            return TwoPairScoreCalculator.CalculateScore(die1, die2, die3, die4, die5);
        }

        if (FullHouseScoreCalculator.IsNonsense3(st))
        {
            return FullHouseScoreCalculator.CalculateScore(die1, die2, die3, die4, die5);
        }

        if (FiveOfAKindScoreCalculator.IsNonsense4(st))
        {
            return FiveOfAKindScoreCalculator.CalculateScore(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}