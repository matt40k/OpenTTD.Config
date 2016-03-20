using System.ComponentModel;

namespace OpenTTD.Config.Types.Difficulty
{
    public enum IndustryDensity
    {
        [Description("no industries, only by funding")]
        none = 0,
        [Description("Minimal")]
        minimal = 1,
        [Description("Very Low")]
        verylow = 2,
        [Description("Low")]
        low = 3,
        [Description("Normal")]
        normal = 4,
        [Description("High")]
        high = 5
    }
}
