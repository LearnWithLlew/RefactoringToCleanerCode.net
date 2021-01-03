using System;
using System.Collections.Generic;
using System.Linq;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [UseReporter(typeof(DiffReporter))]
    [TestClass]
    public class PinningTest
    {
        [TestMethod]
        public void PinEverything()
        {
            var dice = new[] {1, 2, 3, 4, 5, 6};
            var scoringTypes = Utilities.GetEnumValues<ScoringType>().Append((ScoringType) (-1));
            Utilities.VerifyAllCombinations(BigDiceGame.GetScore, scoringTypes, dice, dice, dice, dice, dice);
        }
    }
}

internal static class Utilities
{
    public static IEnumerable<TEnum> GetEnumValues<TEnum>()
    {
        return (TEnum[]) Enum.GetValues(typeof(TEnum));
    }

    public static void VerifyAllCombinations<A, B, C, D, E, F, Result>(Func<A, B, C, D, E, F, Result> processCall,
        IEnumerable<A> aList, IEnumerable<B> bList, IEnumerable<C> cList, IEnumerable<D> dList, IEnumerable<E> eList,
        IEnumerable<F> fList)
    {
        CombinationApprovals.VerifyAllCombinations((a, b, c, d, e, f) => processCall(a, b, c, d, e, f), aList, bList,
            cList, dList, eList, fList);
    }
}