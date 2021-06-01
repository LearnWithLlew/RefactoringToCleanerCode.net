public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (IsFirstCondition(st))
        {
            return PairScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        if (IsSecondCondition(st))
        {
            return TwoPairScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        if (IsThirdCondition(st))
        {
            return FullHouseScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        if (IsFourthCondition(st))
        {
            return FiveOfAKindScoreCalculator.Calculate(die1, die2, die3, die4, die5);
        }

        return 0;
    }

    private static bool IsFourthCondition(ScoringType st)
    {
        return st == ScoringType.FiveOfAKind;
    }

    private static bool IsThirdCondition(ScoringType st)
    {
        return st == ScoringType.FullHouse;
    }

    private static bool IsSecondCondition(ScoringType st)
    {
        return st == ScoringType.TwoPair;
    }

    private static bool IsFirstCondition(ScoringType st)
    {
        return st == ScoringType.Pair;
    }
}