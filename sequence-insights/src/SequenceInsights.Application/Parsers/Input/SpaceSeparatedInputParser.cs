using SequenceInsights.Application.Core.Interfaces;

namespace SequenceInsights.Application.Parsers.Input;

public class SpaceSeparatedInputParser : IInputParser
{
    public IEnumerable<int> ParseInput(string input)
    {
        // Check if the input is not null
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        // Split the input string by spaces and parse each part as an integer
        var result = input.Split(' ').Select(int.Parse);

        return result;
    }
}