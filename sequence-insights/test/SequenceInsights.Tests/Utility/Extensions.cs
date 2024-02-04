using Newtonsoft.Json;

namespace SequenceInsights.Tests.Utility;

public static class Extensions
{
    public static T? FromJsonString<T>(this string value) where T : class
    {
        return JsonConvert.DeserializeObject<T>(value);
    }

    public static string ToJsonString<T>(this T value) where T : class
    {
        return JsonConvert.SerializeObject(value);
    }
}