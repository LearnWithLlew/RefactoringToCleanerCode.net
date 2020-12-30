using System;
using System.Collections.Generic;
using System.Linq;

namespace Yatzy
{
    public static class Yatzy
    {
        public static readonly IScorer[] Scorers = {
            new ScoreChance(),
            new ScoreTwoPair(),
            new ScoreFullHouse(),
            new ScoreYatzy(),
            new ScoreSmallStraight(),
            new ScoreLargeStraight(),
            new ScoreNumber(),
            new ScoreOfAKind(),
        };

        public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
        {
            return ApplyScorers(scoringType, die1, die2, die3, die4, die5, Scorers);
        }

        public static int ApplyScorers(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5,
            IScorer[] scorers)
        {
            return scorers.Where(scorer => scorer.IsRelevant(scoringType))
                .Select(scorer => scorer.GetScore(scoringType, die1, die2, die3, die4, die5)).SingleOrDefault();
        }
    }


    public enum ScoringType
    {
        Chance,

        Ones,
        Twos,
        Threes,

        Pair,
        TwoPair,
        FullHouse,
        FourOfAKind,
        ThreeOfAKind,

        SmallStraight,
        LargeStraight,

        Fours,
        Sixes,
        Fives,

        Yatzy,
    }
}