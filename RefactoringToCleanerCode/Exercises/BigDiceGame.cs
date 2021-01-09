public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        {
            INonSenseApple appleSauce = new Pair();
            if (appleSauce.Matches(scoringType))
            {
                return appleSauce.GetScore(die1, die2, die3, die4, die5);
            }
        }

        {
            TwoPair appleSauce = new TwoPair();
            if (appleSauce.Matches(scoringType))
            {
                return appleSauce.GetScore(die1, die2, die3, die4, die5);
            }
        }

        {
            FullHouse appleSauce = new FullHouse();
            if (appleSauce.Matches(scoringType))
            {
                return appleSauce.GetScore(die1, die2, die3, die4, die5);
            }
        }

        {
            FiveOfAKind appleSauce = new FiveOfAKind();
            if (appleSauce.Matches(scoringType))
            {
                return appleSauce.GetScore(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}