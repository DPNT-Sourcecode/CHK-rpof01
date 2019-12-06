using BeFaster.Runner.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            if (string.IsNullOrEmpty(skus))
                return -1;

            var validCodes = new List<char>() { 'A', 'B', 'C', 'D' };
            var isValid = skus.All(x => validCodes.Contains(x));
            if (!isValid)
                return -1;

            var groupedItems = skus.GroupBy(x => x);

            foreach (var group in groupedItems)
            {

            }



            //id = CHK_R1_003, req = checkout("A"), resp = 0
            //id = CHK_R1_004, req = checkout("B"), resp = 0
            //id = CHK_R1_005, req = checkout("C"), resp = 0
            //id = CHK_R1_006, req = checkout("D"), resp = 0
            //id = CHK_R1_007, req = checkout("a"), resp = 0
            //id = CHK_R1_008, req = checkout("-"), resp = 0
            //id = CHK_R1_009, req = checkout("ABCa"), resp = 0
            //id = CHK_R1_010, req = checkout("AxA"), resp = 0
            //id = CHK_R1_011, req = checkout("ABCD"), resp = 0
            //id = CHK_R1_012, req = checkout("A"), resp = 0
            //id = CHK_R1_013, req = checkout("AA"), resp = 0
            //id = CHK_R1_014, req = checkout("AAA"), resp = 0
            //id = CHK_R1_015, req = checkout("AAAA"), resp = 0
            //id = CHK_R1_016, req = checkout("AAAAA"), resp = 0
            //id = CHK_R1_017, req = checkout("AAAAAA"), resp = 0
            //id = CHK_R1_018, req = checkout("B"), resp = 0
            //id = CHK_R1_019, req = checkout("BB"), resp = 0
            //id = CHK_R1_020, req = checkout("BBB"), resp = 0
            //id = CHK_R1_021, req = checkout("BBBB"), resp = 0
            //id = CHK_R1_022, req = checkout("ABCDABCD"), resp = 0
            //id = CHK_R1_023, req = checkout("BABDDCAC"), resp = 0
            //id = CHK_R1_024, req = checkout("AAABB"), resp = 0
            //id = CHK_R1_001, req = checkout("ABCDCBAABCABBAAA"), resp = 0
            return 0;
        }
    }
}
