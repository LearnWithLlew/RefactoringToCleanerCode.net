public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        switch (st)
        {
            case ScoringType.Pair:
            {
                return PairScore.Evaluate(die1, die2, die3, die4, die5);
            }

            case ScoringType.TwoPair:
            {
                return TwoPairScore.Evaluate(die1, die2, die3, die4, die5);
            }

            case ScoringType.FullHouse:
            {
                return FullHouseScore.Evaluate(die1, die2, die3, die4, die5);
            }

            case ScoringType.FiveOfAKind:
            {
                return FiveOfKindScore.Evaluate(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}