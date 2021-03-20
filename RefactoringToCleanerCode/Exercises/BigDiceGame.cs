public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        {
            if (PairScore.IsSomeCondition(st))
            {
                return PairScore.Evaluate(die1, die2, die3, die4, die5);
            }
        }

        {
            if (new TwoPairScore().IsSomeCondition(st))
            {
                return new TwoPairScore().Evaluate(die1, die2, die3, die4, die5);
            }
        }
        {
            if (new FullHouseScore().IsSomeCondition(st))
            {
                return new FullHouseScore().Evaluate(die1, die2, die3, die4, die5);
            }
        }
        {
            if (new FiveOfKindScore().IsSomeCondition(st))
            {
                return new FiveOfKindScore().Evaluate(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}