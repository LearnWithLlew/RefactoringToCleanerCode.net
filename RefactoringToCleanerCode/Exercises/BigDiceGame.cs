public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (new PairScoreCalculator().IsApplicable(st))
        {
            return new PairScoreCalculator().CalculateScore(die1, die2, die3, die4, die5);
        }

        if (new TwoPairScoreCalculator().IsApplicable(st))
        {
            return new TwoPairScoreCalculator().CalculateScore(die1, die2, die3, die4, die5);
        }

        if (new FullHouseScoreCalculator().IsApplicable(st))
        {
            return FullHouseScoreCalculator.CalculateScore(die1, die2, die3, die4, die5);
        }

        if (FiveOfAKindScoreCalculator.IsApplicable(st))
        {
            return FiveOfAKindScoreCalculator.CalculateScore(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}