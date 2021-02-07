public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        if (DicePairScoreCalculator.IsNonsenseName(scoringType))
        {
            return DicePairScoreCalculator.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (DiceTwoPairScoreCalculator.IsNonsenseNameTwo(scoringType))
        {
            return DiceTwoPairScoreCalculator.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
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
}