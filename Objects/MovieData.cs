using Newtonsoft.Json;

namespace YTSDotNet
{
    public class MovieData
    {
        [JsonProperty(PropertyName = "movie")]
        public MovieInfo Movie;
    }
}
