namespace SequenceInsights.Application.Core;

public class RecursiveSubsequenceFinder : ISubsequenceFinderService
{
    public IEnumerable<int> FindSubsequence(IEnumerable<int> numbers)
    {
        var numberList = numbers.ToList();
        var n = numberList.Count;

        var lisLength = new int[n];
        var previousIndices = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            lisLength[i] = 1;
            previousIndices[i] = new List<int>();

            for (var j = 0; j < i; j++)
            {
                if (numberList[i] <= numberList[j] || lisLength[i] > lisLength[j]) continue;
                if (lisLength[i] < lisLength[j] + 1)
                {
                    lisLength[i] = lisLength[j] + 1;
                    previousIndices[i] = new List<int> { j };
                }
                else
                {
                    previousIndices[i].Add(j);
                }
            }
        }

        var maxLisLength = lisLength.Max();
        var earliestIndex = -1;

        for (var i = n - 1; i >= 0; i--)
        {
            if (lisLength[i] != maxLisLength)
            {
                continue;
            }

            earliestIndex = i;
            break;
        }

        var earliestLis = new List<int>();
        if (earliestIndex != -1)
        {
            FindLis(numberList, previousIndices, earliestLis, earliestIndex);
        }

        return earliestLis;
    }

    private static void FindLis(IReadOnlyList<int> numbers, IReadOnlyList<List<int>> previousIndices, IList<int> lis, int currentIndex)
    {
        lis.Insert(0, numbers[currentIndex]);

        foreach (var previousIndex in previousIndices[currentIndex])
        {
            FindLis(numbers, previousIndices, lis, previousIndex);
        }
    }
}