namespace SequenceInsights.Application.Core.Interfaces;

public interface IInputParser
{
    IEnumerable<int> ParseInput(string input);
}