public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        {
            if (new DicePairScoreCalculator().IsScorable(scoringType))
            {
                return new DicePairScoreCalculator().CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        {
            if (new DiceTwoPairScoreCalculator().IsScorable(scoringType))
            {
                return new DiceTwoPairScoreCalculator().CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }
        if (new DiceFullHouseScoreCalculator().IsScorable(scoringType))
        {
            return new DiceFullHouseScoreCalculator().CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (new DiceFiveOfAKindScoreCalculator().IsScorable(scoringType))
        {
            return new DiceFiveOfAKindScoreCalculator().CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }
}