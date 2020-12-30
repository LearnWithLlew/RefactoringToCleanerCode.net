using System;
using System.Collections.Generic;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yatzy;

namespace Exercises.Tests
{
    [UseReporter(typeof(DiffReporter))]
    [TestClass]
    public class UnitTest1
    {
        private static void VerifyAllCombinations<T1, T2, T3, T4, T5, T6, TResult>(
            Func<T1, T2, T3, T4, T5, T6, TResult> processCall,
            IEnumerable<T1> aList, IEnumerable<T2> bList, IEnumerable<T3> cList, IEnumerable<T4> dList,
            IEnumerable<T5> eList, IEnumerable<T6> fList)
        {
            CombinationApprovals.VerifyAllCombinations((t1, t2, t3, t4, t5, t6) => processCall(t1, t2, t3, t4, t5, t6),
                aList,
                bList, cList, dList, eList, fList);
        }

        private static T[] EnumGetValues<T>()
        {
            return (T[]) Enum.GetValues(typeof(T));
        }


        //[TestMethod]
        public void TestMethod1()
        {
            var diceValues = new[] {1, 2, 3, 4, 5, 6};
            VerifyAllCombinations(
                Yatzy.Yatzy.GetScore,
                EnumGetValues<ScoringType>(),
                diceValues, diceValues, diceValues, diceValues, diceValues
            );
        }


        [TestMethod]
        public void ApproveScorers()
        {
            ApprovalTests.Approvals.VerifyAll(Yatzy.Yatzy.Scorers, _ => _.GetType().Name);
        }

        [TestMethod]
        public void TestYatzy()
        {
            var subject = new ScoreYatzy();
            subject.GetScore(ScoringType.Yatzy, 1, 2, 3, 4, 5)
                .Should().Be(0);
            subject.GetScore(ScoringType.Yatzy, 2, 2, 2, 2, 2)
                .Should().Be(50);
        }

        [TestMethod]
        public void ApplyScorers()
        {
            var result = Yatzy.Yatzy.ApplyScorers(
                ScoringType.Chance, 1, 2, 3, 4, 5,
                new IScorer[] {new NeverRelevant(), new AlwaysRelevant(), new NeverRelevant()});
            Assert.AreEqual(42, result);
        }

        public class NeverRelevant : IScorer
        {
            public bool IsRelevant(ScoringType scoringType)
            {
                return false;
            }

            public int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
            {
                throw new NotImplementedException();
            }
        }

        public class AlwaysRelevant : IScorer
        {
            public bool IsRelevant(ScoringType scoringType)
            {
                return true;
            }

            public int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
            {
                return 42;
            }
        }
    }
}