public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (PairScoreCalculator.IsFirstCondition(st))
        {
            return PairScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        if (TwoPairScoreCalculator.IsSecondCondition(st))
        {
            return TwoPairScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        if (FullHouseScoreCalculator.IsThirdCondition(st))
        {
            return FullHouseScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        if (FiveOfAKindScoreCalculator.IsFourthCondition(st))
        {
            return FiveOfAKindScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}