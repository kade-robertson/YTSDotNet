using Newtonsoft.Json;

namespace YTSDotNet
{
    public class CastMember
    {
        [JsonProperty(PropertyName = "Name")]
        public string ActorName;

        [JsonProperty(PropertyName = "character_name")]
        public string CharacterName;

        [JsonProperty(PropertyName = "url_small_image")]
        public string ActorImage;

        [JsonProperty(PropertyName = "imdb_code")]
        public string IMDBCode;
    }
}
