internal class TwoPairScoreCalculator
{
    public int Calculate(int die1, int die2, int d3, int dieFour, int fifthDie)
    {
        var counts1 = new int[6];
        counts1[die1 - 1]++;
        counts1[die2 - 1]++;
        counts1[d3 - 1]++;
        counts1[dieFour - 1]++;
        counts1[fifthDie - 1]++;
        var n = 0;
        var score = 0;
        for (var i = 0; i < 6; i += 1)
        {
            if (counts1[6 - i - 1] >= 2)
            {
                n++;
                score += 6 - i;
            }
        }

        if (n == 2)
        {
            return score * 2;
        }

        return 0;
    }

    public bool IsSupported(ScoringType st)
    {
        return st == ScoringType.TwoPair;
    }
}