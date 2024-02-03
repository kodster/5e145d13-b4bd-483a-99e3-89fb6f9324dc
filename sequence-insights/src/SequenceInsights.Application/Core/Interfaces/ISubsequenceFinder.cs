namespace SequenceInsights.Application.Core.Interfaces;

public interface ISubsequenceFinder
{
    IEnumerable<int> FindSubsequence(IEnumerable<int> numbers);
}