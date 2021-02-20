public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        {
            foreach (var scorer in new IScorer[] {new Pair(), new TwoPair(), new FullHouse(), new FiveOfAKind()})
            {
                if (scorer.IsScorable(st))
                {
                    return scorer.CalculateScore(die1, die2, die3, die4, die5);
                }
            }
        }


        return 0;
    }
}