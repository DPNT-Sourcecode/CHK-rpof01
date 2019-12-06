using BeFaster.App.Solutions.HLO;
using BeFaster.App.Solutions.SUM;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class HloSolutionTest
    {
        [TestCase("sam", ExpectedResult = "Hello, sam!")]
        [TestCase("bob", ExpectedResult = "Hello, bob!")]
        [TestCase("franky dean", ExpectedResult = "Hello, franky dean!")]
        [TestCase("franky d'olive", ExpectedResult = "Hello, franky d'olive!")]
        [TestCase("Craftsman", ExpectedResult = "Hello, Craftsman!")]
        [TestCase("Mr. X", ExpectedResult = "Hello, Mr. X!")]
        public string ComputeHello(string input)
        {
            return HelloSolution.Hello(input);
        }
    }
}


