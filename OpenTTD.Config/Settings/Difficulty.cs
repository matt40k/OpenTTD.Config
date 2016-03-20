using System;
using System.Runtime.Serialization;

namespace OpenTTD.Config.Settings
{
    [Serializable]
    public class Difficulty
    {
        [DataMember]
        public Types.Difficulty.CompetitorSpeed CompetitorSpeed { get; set; }

        [DataMember]
        public Types.Difficulty.ConstructionCost ConstructionCost { get; set; }

        [DataMember]
        public Types.Difficulty.DiffLevel DiffLevel { get; set; }

        [DataMember]
        public Types.Difficulty.IndustryDensity IndustryDensity { get; set; }

        [DataMember]
        public Types.Difficulty.Initialnterest Initialnterest { get; set; }

    }
}
