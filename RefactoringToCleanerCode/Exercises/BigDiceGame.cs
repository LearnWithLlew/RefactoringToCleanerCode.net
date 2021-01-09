public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        {
            var appleSauce = new Pair();
            if (appleSauce.Matches(scoringType))
            {
                return appleSauce.GetScore(die1, die2, die3, die4, die5);
            }
        }

        {
            var appleSauce = new TwoPair();
            if (appleSauce.Matches(scoringType))
            {
                return appleSauce.GetScore(die1, die2, die3, die4, die5);
            }
        }

        {
            if (new FullHouse().Matches(scoringType))
            {
                return new FullHouse().GetScore(die1, die2, die3, die4, die5);
            }
        }

        {
            if (new FiveOfAKind().Matches(scoringType))
            {
                return new FiveOfAKind().GetScore(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}