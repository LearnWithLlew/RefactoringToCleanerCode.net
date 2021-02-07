public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        {
            foreach (IScorer scorer in new IScorer[]{ new DicePairScoreCalculator(), new DiceTwoPairScoreCalculator() })
            {
                if (scorer.IsScorable(scoringType))
                {
                    return scorer.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
                }
            }
        }

        {
            IScorer scorer = new DiceFullHouseScoreCalculator();
            if (scorer.IsScorable(scoringType))
            {
                return scorer.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }
        {
            IScorer scorer = new DiceFiveOfAKindScoreCalculator();
            if (scorer.IsScorable(scoringType))
            {
                return scorer.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        return 0;
    }
}