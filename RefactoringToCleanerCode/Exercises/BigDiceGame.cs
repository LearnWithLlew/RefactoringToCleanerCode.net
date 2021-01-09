public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        if (IsConcertPiano(scoringType))
        {
            return Pair.Applesauce(die1, die2, die3, die4, die5);
        }

        if (IsConcertPiano2(scoringType))
        {
            return TwoPair.AppleSauce2(die1, die2, die3, die4, die5);
        }

        if (scoringType == ScoringType.FullHouse)
        {
            return FullHouse.AppleSauce3(die1, die2, die3, die4, die5);
        }

        if (scoringType == ScoringType.FiveOfAKind)
        {
            return FiveOfAKind.AppleSauce4(die1, die2, die3, die4, die5);
        }

        return 0;
    }

    private static bool IsConcertPiano2(ScoringType scoringType)
    {
        return scoringType == ScoringType.TwoPair;
    }

    private static bool IsConcertPiano(ScoringType scoringType)
    {
        return scoringType == ScoringType.Pair;
    }
}