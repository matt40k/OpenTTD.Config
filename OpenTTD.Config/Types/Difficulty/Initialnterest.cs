using System.ComponentModel;

namespace OpenTTD.Config.Types.Difficulty
{
    public enum Initialnterest
    {
        [Description("2% interest")]
        TwoPercentInterest = 2,
        [Description("3% interest")]
        ThreePercentInterest = 3,
        [Description("4% interest")]
        FourPercentInterest = 4
    }
}
