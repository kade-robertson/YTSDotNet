using Newtonsoft.Json;
using System.Collections.Generic;

namespace YTSDotNet
{
    public class ParentalGuide
    {
        [JsonProperty(PropertyName = "type")]
        public string Type;

        [JsonProperty(PropertyName = "parental_guide_text")]
        public string GuideText;
    }

    public class ParentalGuideData
    {
        [JsonProperty(PropertyName = "parental_guide_count")]
        public int GuideCount;

        [JsonProperty(PropertyName = "parental_guides")]
        public List<ParentalGuide> Guides;
    }
}
