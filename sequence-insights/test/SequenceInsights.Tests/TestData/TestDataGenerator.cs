using SequenceInsights.Tests.Models;
using SequenceInsights.Tests.Utility;
using System.Diagnostics;

namespace SequenceInsights.Tests.TestData;

public class TestDataGenerator
{
    /// <summary>
    /// Load test case from a file.
    /// </summary>
    /// <returns>Tests</returns>
    public static IEnumerable<object[]> GetTestCaseGenerator()
    {
        // Load test cases from the JSON file
        const string jsonFilePath = "TestData/testcases.json";

        var testCases = LoadTestCasesFromJson(jsonFilePath);

        foreach (var testCase in testCases!)
        {
            Debug.Assert(testCase.TestName != null, "testCase.TestName != null");
            Debug.Assert(testCase.Input != null, "testCase.Input != null");
            Debug.Assert(testCase.Output != null, "testCase.Output != null");

            yield return new object[] { testCase.TestName, testCase.Input, testCase.Output };
        }
    }

    private static IEnumerable<TestCase>? LoadTestCasesFromJson(string filePath)
    {
        // Read JSON file and deserialize it into a list of TestCase objects
        var testCases = (File.ReadAllText(filePath)).FromJsonString<IEnumerable<TestCase>>();
        return testCases;
    }
}