public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        if (IsNonsenseName(scoringType))
        {
            return DicePairScoreCalculator.ObviousNonsense(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (IsNonsenseNameTwo(scoringType))
        {
            return DiceTwoPairScoreCalculator.ObviousNonsenseTwo(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (DiceFullHouseScoreCalculator.IsNonsenseNameThree(scoringType))
        {
            return DiceFullHouseScoreCalculator.ObviousNonsenseThree(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (DiceFiveOfAKindScoreCalculator.IsNonsenseNameFour(scoringType))
        {
            return DiceFiveOfAKindScoreCalculator.ObviousNonsenseFour(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }

    private static bool IsNonsenseNameTwo(ScoringType scoringType)
    {
        return scoringType == ScoringType.TwoPair;
    }

    private static bool IsNonsenseName(ScoringType scoringType)
    {
        return scoringType == ScoringType.Pair;
    }
}