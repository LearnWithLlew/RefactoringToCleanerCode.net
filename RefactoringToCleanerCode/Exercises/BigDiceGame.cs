public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        if (scoringType == ScoringType.Pair)
        {
            return DicePairScoreCalculator.ObviousNonsense(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        else if (scoringType == ScoringType.TwoPair)
        {
            return DiceTwoPairScoreCalculator.ObviousNonsenseTwo(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        else if (scoringType == ScoringType.FullHouse)
        {
            return DiceFullHouseScoreCalculator.ObviousNonsenseThree(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        else if (scoringType == ScoringType.FiveOfAKind)
        {
            return DiceFiveOfAKindScoreCalculator.ObviousNonsenseFour(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }
}