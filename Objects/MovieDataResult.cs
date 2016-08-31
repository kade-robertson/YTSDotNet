using Newtonsoft.Json;

namespace YTSDotNet
{
    public class MovieDataResult
    {
        [JsonProperty(PropertyName = "status")]
        public string Status;

        [JsonProperty(PropertyName = "status_message")]
        public string StatusMessage;

        [JsonProperty(PropertyName = "data")]
        public MovieData Data;

        [JsonProperty(PropertyName = "@meta")]
        public Metadata MetaInfo;
    }

    public class MovieData
    {
        [JsonProperty(PropertyName = "movie")]
        public MovieInfo Movie;
    }
}
