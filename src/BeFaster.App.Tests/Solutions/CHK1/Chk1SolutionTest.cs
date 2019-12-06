using BeFaster.App.Solutions.CHK;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class Chk1SolutionTest
    {
        //[TestCase("", ExpectedResult = -1)]
        //[TestCase("a", ExpectedResult = -1)]
        //[TestCase("Ab", ExpectedResult = -1)]
        //[TestCase("abbA", ExpectedResult = -1)]
        //[TestCase("-", ExpectedResult = -1)]
        [TestCase("AABBC", ExpectedResult = -1)]
        public int ComputePrice(string input)
        {
            return CheckoutSolution.ComputePrice(input);
        }
    }
}
