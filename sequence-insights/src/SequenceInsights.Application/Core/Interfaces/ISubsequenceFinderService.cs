namespace SequenceInsights.Application.Core.Interfaces;

public interface ISubsequenceFinderService
{
    IEnumerable<int> FindSubsequence(IEnumerable<int> numbers);
}