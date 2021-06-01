﻿public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        {
            ICalculator calculator = new PairScoreCalculator();
            if (calculator.IsSupported(st))
            {
                return calculator.Calculate(die1, die2, die3, die4, die5);
            }
        }

        {
            TwoPairScoreCalculator calculator = new TwoPairScoreCalculator();
            if (calculator.IsSupported(st))
            {
                return calculator.Calculate(die1, die2, die3, die4, die5);
            }
        }

        {
            FullHouseScoreCalculator calculator = new FullHouseScoreCalculator();
            if (calculator.IsSupported(st))
            {
                return calculator.Calculate(die1, die2, die3, die4, die5);
            }
        }

        {
            FiveOfAKindScoreCalculator calculator = new FiveOfAKindScoreCalculator();
            if (calculator.IsSupported(st))
            {
                return calculator.Calculate(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}