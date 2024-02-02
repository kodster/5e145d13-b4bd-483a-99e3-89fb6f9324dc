using FluentAssertions;
using SequenceInsights.Application.Core;
using SequenceInsights.Tests.TestData;
using Xunit;

namespace SequenceInsights.Tests.UnitTests
{
    public class LongestIncreasingSubsequenceFinderTests
    {
        private readonly IInputParser _inputParser = new SpaceSeparatedInputParser();
        private readonly IOutputParser _outputParser = new OutputParser();
        private readonly ISubsequenceFinderService _subsequenceFinderService = new LongestIncreasingSubsequenceFinder();


        [Theory]
        [MemberData(nameof(TestDataGenerator.GetTestCasesFromGenerator), MemberType = typeof(TestDataGenerator))]
        public void Given_TestCase_When_Process_Then_ShouldHaveExpectedResult(string testCase, string input, string expectedOutput)

        {
            var output = _subsequenceFinderService.FindSubsequence(_inputParser.ParseInput(input));
            var result = _outputParser.ParseOutput(output);
            result.Should().BeEquivalentTo(expectedOutput, testCase);
        }
    }
}