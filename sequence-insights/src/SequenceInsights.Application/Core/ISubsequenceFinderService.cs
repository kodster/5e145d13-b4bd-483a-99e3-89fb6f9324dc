namespace SequenceInsights.Application.Core;

public interface ISubsequenceFinderService
{
    IEnumerable<int> FindSubsequence(IEnumerable<int> numbers);
}