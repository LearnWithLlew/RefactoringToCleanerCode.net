public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        {
            IScorer scorer = new DicePairScoreCalculator();
            if (scorer.IsScorable(scoringType))
            {
                return scorer.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        {
            DiceTwoPairScoreCalculator scorer = new DiceTwoPairScoreCalculator();
            if (scorer.IsScorable(scoringType))
            {
                return scorer.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }
        {
            DiceFullHouseScoreCalculator scorer = new DiceFullHouseScoreCalculator();
            if (scorer.IsScorable(scoringType))
            {
                return scorer.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }
        {
            DiceFiveOfAKindScoreCalculator scorer = new DiceFiveOfAKindScoreCalculator();
            if (scorer.IsScorable(scoringType))
            {
                return scorer.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        return 0;
    }
}