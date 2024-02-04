using SequenceInsights.Application.Core.Interfaces;

namespace SequenceInsights.Application.Parsers.Output;

public class OutputParser : IOutputParser
{
    public string ParseOutput(IEnumerable<int> output)
    {
        var result = string.Join(" ", output);
        return result;
    }
}