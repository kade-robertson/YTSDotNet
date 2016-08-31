using Newtonsoft.Json;
using System.Collections.Generic;

namespace YTSDotNet
{
    public class SuggestionData
    {
        [JsonProperty(PropertyName = "movie_count")]
        public int SuggestionCount;

        [JsonProperty(PropertyName = "movies")]
        public List<MovieInfo> Suggestions;
    }
}
