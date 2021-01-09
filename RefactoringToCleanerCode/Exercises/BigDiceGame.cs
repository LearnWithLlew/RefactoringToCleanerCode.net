public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        if (new Pair().Matches(scoringType))
        {
            return Pair.GetScore(die1, die2, die3, die4, die5);
        }

        if (new TwoPair().Matches(scoringType))
        {
            return TwoPair.GetScore(die1, die2, die3, die4, die5);
        }

        if (FullHouse.Matches(scoringType))
        {
            return FullHouse.GetScore(die1, die2, die3, die4, die5);
        }

        if (FiveOfAKind.Matches(scoringType))
        {
            return FiveOfAKind.GetScore(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}