public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        if (new DicePairScoreCalculator().IsScorable(scoringType))
        {
            return new DicePairScoreCalculator().CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (new DiceTwoPairScoreCalculator().IsScorable(scoringType))
        {
            return DiceTwoPairScoreCalculator.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (DiceFullHouseScoreCalculator.IsScorable(scoringType))
        {
            return DiceFullHouseScoreCalculator.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (DiceFiveOfAKindScoreCalculator.IsScorable(scoringType))
        {
            return DiceFiveOfAKindScoreCalculator.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }
}