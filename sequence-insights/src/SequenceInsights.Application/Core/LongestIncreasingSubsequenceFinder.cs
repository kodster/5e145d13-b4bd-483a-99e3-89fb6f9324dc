namespace SequenceInsights.Application.Core;

public class LongestIncreasingSubsequenceFinder : ISubsequenceFinderService
{
    public IEnumerable<int> FindSubsequence(IEnumerable<int> inputNumbers)
    {
        var inputList = inputNumbers.ToList();
        var totalNumbers = inputList.Count;

        var subSequences = new List<int>[totalNumbers];

        for (var currentIndex = 0; currentIndex < totalNumbers; currentIndex++)
        {
            subSequences[currentIndex] = new List<int> { inputList[currentIndex] };
        }

        // Build sub sequences based on the LIS algorithm
        for (var currentIndex = 1; currentIndex < totalNumbers; currentIndex++)
        {
            for (var previousIndex = 0; previousIndex < currentIndex; previousIndex++)
            {
                // Check if the current element can be added to the existing subsequence
                if (inputList[currentIndex] > inputList[previousIndex] &&
                    subSequences[currentIndex].Count <= subSequences[previousIndex].Count)
                {
                    // Update the subsequence at the current index with a longer subsequence
                    subSequences[currentIndex] = new List<int>(subSequences[previousIndex]) { inputList[currentIndex] };
                }
            }
        }

        // Find the longest subsequence among all sub sequences
        var longestSubsequence = subSequences.MaxBy(subSeq => subSeq.Count);

        return longestSubsequence ?? new List<int>();
    }
}