namespace SequenceInsights.Application.Core;

public interface IInputParser
{
    IEnumerable<int> ParseInput(string input);
}

public class SpaceSeparatedInputParser : IInputParser
{
    public IEnumerable<int> ParseInput(string input)
    {
        throw new NotImplementedException();
    }
}

public class CsvInputParser : IInputParser
{
    public IEnumerable<int> ParseInput(string input)
    {
        throw new NotImplementedException();
    }
}