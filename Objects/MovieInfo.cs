using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;

namespace YTSDotNet
{
    public class MovieInfo
    {
        [JsonProperty(PropertyName = "id")]
        public int ID;

        [JsonProperty(PropertyName = "url")]
        public string URL;

        [JsonProperty(PropertyName = "imdb_code")]
        public string IMDBCode;

        [JsonProperty(PropertyName = "title")]
        public string Title;

        [JsonProperty(PropertyName = "title_english")]
        public string EnglishTitle;

        [JsonProperty(PropertyName = "title_long")]
        public string LongTitle;

        [JsonProperty(PropertyName = "slug")]
        public string Slug;

        [JsonProperty(PropertyName = "year")]
        public int Year;

        [JsonProperty(PropertyName = "rating")]
        public decimal Rating;

        [JsonProperty(PropertyName = "runtime")]
        public int RuntimeInMinutes;

        [JsonProperty(PropertyName = "genres")]
        public List<string> Genres;

        [JsonProperty(PropertyName = "summary")]
        public string Summary;

        [JsonProperty(PropertyName = "description_full")]
        public string FullDescription;

        [JsonProperty(PropertyName = "synopsis")]
        public string Synopsis;

        [JsonProperty(PropertyName = "yt_trailer_code")]
        public string YoutubeTrailerURL;

        [JsonProperty(PropertyName = "language")]
        public string Language;

        [JsonProperty(PropertyName = "mpa_rating")]
        public string MPAARating;

        [JsonProperty(PropertyName = "background_image")]
        public string BackgroundImageURL;

        [JsonProperty(PropertyName = "background_image_original")]
        public string BackgroundImageOriginalURL;

        [JsonProperty(PropertyName = "small_cover_image")]
        public string SmallCoverImageURL;

        [JsonProperty(PropertyName = "medium_cover_image")]
        public string MediumCoverImageURL;

        [JsonProperty(PropertyName = "large_cover_image")]
        public string LargeCoverImageURL;

        [JsonProperty(PropertyName = "state")]
        public string State;

        [JsonProperty(PropertyName = "torrents")]
        public List<TorrentInfo> Torrents;

        [JsonProperty(PropertyName = "date_uploaded")]
        public string DateUploaded;

        [JsonProperty(PropertyName = "date_uploaded_unix")]
        public int DateUploadedUnix;

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(LongTitle);
            builder.AppendLine(" - Rating: " + Rating + "/10");
            builder.Append(" - Qualities: ");
            builder.AppendLine(string.Join(", ", Torrents.Select(tor => tor.Quality)));
            builder.AppendLine(" - Uploaded: " + DateUploaded);
            return builder.ToString();
        }
    }
}
