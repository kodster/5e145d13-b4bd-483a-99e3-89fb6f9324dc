namespace SequenceInsights.Application.Core;

public interface IOutputParser
{
    string ParseOutput(IEnumerable<int> output);
}

public class OutputParser : IOutputParser
{
    public string ParseOutput(IEnumerable<int> output)
    {
        var result = string.Join(" ", output);
        return result;
    }
}