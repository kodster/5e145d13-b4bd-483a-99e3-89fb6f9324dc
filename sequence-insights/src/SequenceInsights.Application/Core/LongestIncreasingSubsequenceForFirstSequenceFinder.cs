namespace SequenceInsights.Application.Core;

public class LongestIncreasingSubsequenceForFirstSequenceFinder : ISubsequenceFinderService
{
    public IEnumerable<int> FindSubsequence(IEnumerable<int> numbers)
    {
        var sequence = new List<int>();
        var currentSequence = new List<int>();

        foreach (var number in numbers)
        {
            if (currentSequence.Count == 0 || number > currentSequence[^1])
            {
                currentSequence.Add(number);
            }
            else
            {
                if (currentSequence.Count > sequence.Count)
                {
                    sequence = new List<int>(currentSequence);
                }

                currentSequence = new List<int> { number };
            }
        }

        return sequence;
    }
}