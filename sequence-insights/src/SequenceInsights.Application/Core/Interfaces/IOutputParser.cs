namespace SequenceInsights.Application.Core.Interfaces;

public interface IOutputParser
{
    string ParseOutput(IEnumerable<int> output);
}