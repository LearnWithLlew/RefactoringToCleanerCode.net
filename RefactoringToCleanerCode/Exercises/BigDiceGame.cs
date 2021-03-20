public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (PairScore.IsSomeCondition(st))
        {
            return PairScore.Evaluate(die1, die2, die3, die4, die5);
        }

        if (TwoPairScore.IsSomeCondition(st))
        {
            return TwoPairScore.Evaluate(die1, die2, die3, die4, die5);
        }
        if (FullHouseScore.IsSomeCondition3(st))
        {
            return FullHouseScore.Evaluate(die1, die2, die3, die4, die5);
        }
        if (FiveOfKindScore.IsSomeCondition4(st))
        {
            return FiveOfKindScore.Evaluate(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}