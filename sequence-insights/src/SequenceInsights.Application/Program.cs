using SequenceInsights.Application.Strategies;

namespace SequenceInsights.Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter a sequence of integers separated by single whitespace:");
            var input = Console.ReadLine();
            var sequence = input.Split(' ').Select(int.Parse).ToList();

            var subsequenceFinder = new LongestIncreasingSubsequenceForFirstSequenceFinder();


            var longestIncreasingSubsequence = subsequenceFinder.FindSubsequence(sequence);

            Console.WriteLine("Longest Increasing Subsequence: " + string.Join(" ", longestIncreasingSubsequence));
        }
    }
}