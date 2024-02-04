using SequenceInsights.Application.Core.Interfaces;

namespace SequenceInsights.Application.Strategies;

// This is Implementation that works with all tests
public class LongestIncreasingSubsequenceForFirstSequenceFinder : ISubsequenceFinder
{
    public IEnumerable<int> FindSubsequence(IEnumerable<int> numbers)
    {
        var sequence = new List<int>();
        var currentSequence = new List<int>();

        // Define the minimum length for a valid subsequence
        const int sequenceLength = 2;

        foreach (var number in numbers)
        {
            // Check if the current number > than the current potential subsequence
            if (currentSequence.Count == 0 || number > currentSequence[^1])
            {
                // Add the number to the current potential subsequence
                currentSequence.Add(number);
            }
            else
            {
                // Check if the current potential subsequence is longer than the previous ones and longer than the defined sequence length
                if (currentSequence.Count > sequenceLength && currentSequence.Count > sequence.Count)
                {
                    // Update the overall increasing subsequence
                    sequence = new List<int>(currentSequence);
                }

                // Start a new potential subsequence with the current number
                currentSequence = new List<int> { number };
            }
        }

        // Check the last potential subsequence after the loop
        if (currentSequence.Count > sequenceLength && currentSequence.Count > sequence.Count)
        {
            // Update the overall increasing subsequence
            sequence = new List<int>(currentSequence);
        }

        // Return the overall increasing subsequence
        return sequence;
    }
}