using Newtonsoft.Json;
using System.Collections.Generic;

namespace YTSDotNet
{
    public class MovieSuggestionResult
    {
        [JsonProperty(PropertyName = "status")]
        public string Status;

        [JsonProperty(PropertyName = "status_message")]
        public string StatusMessage;

        [JsonProperty(PropertyName = "data")]
        public SuggestionData Data;

        [JsonProperty(PropertyName = "@meta")]
        public Metadata MetaInfo;
    }

    public class SuggestionData
    {
        [JsonProperty(PropertyName = "movie_count")]
        public int SuggestionCount;

        [JsonProperty(PropertyName = "movies")]
        public List<MovieInfo> Suggestions;
    }
}
