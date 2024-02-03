using Microsoft.Extensions.DependencyInjection;
using SequenceInsights.Application.Core.Interfaces;
using SequenceInsights.Application.Parsers.Input;
using SequenceInsights.Application.Strategies;

namespace SequenceInsights.Application
{
    internal class Program
    {
        static void Main()
        {
            // Set up the DI container
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IInputParser, SpaceSeparatedInputParser>()
                .AddTransient<LongestIncreasingSubsequenceForFirstSequenceFinder>()
                .BuildServiceProvider();

            while (true)
            {
                Console.WriteLine("Enter a sequence of integers separated by a single whitespace (or type 'exit' to quit):");
                var input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }

                // Use DI to get the IInputParser instance
                var inputParser = serviceProvider.GetRequiredService<IInputParser>();
                var sequence = inputParser.ParseInput(input!);

                // Use DI to get the LongestIncreasingSubsequenceForFirstSequenceFinder instance
                var subsequenceFinder = serviceProvider.GetRequiredService<LongestIncreasingSubsequenceForFirstSequenceFinder>();
                var longestIncreasingSubsequence = subsequenceFinder.FindSubsequence(sequence);

                Console.WriteLine("Longest Increasing Subsequence (first): " + string.Join(" ", longestIncreasingSubsequence));
            }
        }
    }
}