public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        {
            var scoreCalculator = new PairScoreCalculator();
            if (scoreCalculator.IsApplicable(st))
            {
                return scoreCalculator.CalculateScore(die1, die2, die3, die4, die5);
            }
        }

        {
            var scoreCalculator = new TwoPairScoreCalculator();
            if (scoreCalculator.IsApplicable(st))
            {
                return scoreCalculator.CalculateScore(die1, die2, die3, die4, die5);
            }
        }

        {
            if (new FullHouseScoreCalculator().IsApplicable(st))
            {
                return new FullHouseScoreCalculator().CalculateScore(die1, die2, die3, die4, die5);
            }
        }

        {
            if (new FiveOfAKindScoreCalculator().IsApplicable(st))
            {
                return new FiveOfAKindScoreCalculator().CalculateScore(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}