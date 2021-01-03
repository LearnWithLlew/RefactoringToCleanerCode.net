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

    public static void VerifyAllCombinations<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> processCall,
        IEnumerable<T1> aList, IEnumerable<T2> bList, IEnumerable<T3> cList, IEnumerable<T4> dList, IEnumerable<T5> eList,
        IEnumerable<T6> fList)
    {
        CombinationApprovals.VerifyAllCombinations((a, b, c, d, e, f) => processCall(a, b, c, d, e, f), aList, bList,
            cList, dList, eList, fList);
    }
}