using System.ComponentModel;

namespace OpenTTD.Config.Types.Difficulty
{
    public enum ConstructionCost
    {
        [Description("Low")]
        low = 0,
        [Description("Medium")]
        medium = 1,
        [Description("High")]
        high = 2
    }
}
