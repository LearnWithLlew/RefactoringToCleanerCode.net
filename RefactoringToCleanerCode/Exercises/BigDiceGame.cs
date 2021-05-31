public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (st == ScoringType.Pair)
        {
            return PairScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        if (st == ScoringType.TwoPair)
        {
            return TwoPairScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }
        if (st == ScoringType.FullHouse)
        {
            return FullHouseScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        if (st == ScoringType.FiveOfAKind)
        {
            return FiveOfAKindScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}