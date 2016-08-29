using Newtonsoft.Json;

namespace YTSDotNet
{
    public class TorrentInfo
    {
        [JsonProperty(PropertyName = "url")]
        public string URL;

        [JsonProperty(PropertyName = "hash")]
        public string InfoHash;

        [JsonProperty(PropertyName = "quality")]
        public string Quality;

        [JsonProperty(PropertyName = "seeds")]
        public int Seeds;

        [JsonProperty(PropertyName = "peers")]
        public int Peers;

        [JsonProperty(PropertyName = "size")]
        public string Size;

        [JsonProperty(PropertyName = "size_bytes")]
        public long SizeInBytes;

        [JsonProperty(PropertyName = "date_uploaded")]
        public string DateUploaded;

        [JsonProperty(PropertyName = "date_uploaded_unix")]
        public int DateUploadedUnix;
    }
}
