public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        if (Pair.IsConcertPiano(scoringType))
        {
            return Pair.Applesauce(die1, die2, die3, die4, die5);
        }

        if (TwoPair.IsConcertPiano2(scoringType))
        {
            return TwoPair.AppleSauce2(die1, die2, die3, die4, die5);
        }

        if (FullHouse.IsConcertPiano3(scoringType))
        {
            return FullHouse.AppleSauce3(die1, die2, die3, die4, die5);
        }

        if (IsConcertPiano4(scoringType))
        {
            return FiveOfAKind.AppleSauce4(die1, die2, die3, die4, die5);
        }

        return 0;
    }

    private static bool IsConcertPiano4(ScoringType scoringType)
    {
        return scoringType == ScoringType.FiveOfAKind;
    }
}