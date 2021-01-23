internal class CalculateTwoPairScore : ICalculator
{
    public int Calculate(int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        var counts1 = new int[6];
        counts1[dieOne - 1]++;
        counts1[dieTwo - 1]++;
        counts1[dieThree - 1]++;
        counts1[dieFour - 1]++;
        counts1[dieFive - 1]++;
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

    public bool ShouldCalculate(ScoringType scoringType)
    {
        return scoringType == ScoringType.TwoPair;
    }
}