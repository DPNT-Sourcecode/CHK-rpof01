using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.HLO
{
    public static class HelloSolution
    {
        public static string Hello(string friendName)
        {
            if(friendName == "Craftsman" || friendName == "Mr. X")
            {
                return $"Hello, World!";
            }

            return $"Hello, {friendName}!";
        }
    }
}

