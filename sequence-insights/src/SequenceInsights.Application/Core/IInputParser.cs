namespace SequenceInsights.Application.Core;

public interface IInputParser
{
    IEnumerable<int> ParseInput(string input);
}