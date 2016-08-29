using Newtonsoft.Json;
using System.Collections.Generic;

namespace YTSDotNet
{
    public class ListMovieData
    {
        [JsonProperty(PropertyName = "movie_count")]
        public int MovieCount;

        [JsonProperty(PropertyName = "limit")]
        public int MovieLimit;

        [JsonProperty(PropertyName = "page_number")]
        public int PageNumber;

        [JsonProperty(PropertyName = "movies")]
        public List<MovieInfo> Movies;
    }
}
