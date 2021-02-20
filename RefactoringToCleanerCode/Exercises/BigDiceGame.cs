public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        {
            var scorer = new Pair();
            if (scorer.IsScorable(st))
            {
                return scorer.CalculateScore(die1, die2, die3, die4, die5);
            }
        }

        {
            var scorer = new TwoPair();
            if (scorer.IsScorable(st))
            {
                return scorer.CalculateScore(die1, die2, die3, die4, die5);
            }
        }

        {
            var scorer = new FullHouse();
            if (scorer.IsScorable(st))
            {
                return scorer.CalculateScore(die1, die2, die3, die4, die5);
            }
        }

        {
            if (new FiveOfAKind().IsScorable(st))
            {
                return new FiveOfAKind().CalculateScore(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}