using System.ComponentModel;

namespace OpenTTD.Config.Types.Difficulty
{
    public enum DiffLevel
    {
        [Description("easy-mode")]
        easymode = 0,
        [Description("normal-mode")]
        normalmode = 1,
        [Description("hard-mode")]
        hardmode = 2,
        [Description("custom")]
        custom = 3
    }
}
