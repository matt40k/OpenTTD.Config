using System.ComponentModel;

namespace OpenTTD.Config.Types.Difficulty
{
    public enum CompetitorSpeed
    {
        [Description("Very Slow")]
        veryslow = 0,
        [Description("Slow")]
        slow = 1,
        [Description("Medium")]
        medium = 2,
        [Description("Fast")]
        fast = 3,
        [Description("Very Fast")]
        veryfast = 4
    }
}
