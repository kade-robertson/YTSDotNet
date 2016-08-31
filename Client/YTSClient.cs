using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace YTSDotNet
{
    public class YTSClient
    {
        private string m_appkey;
        private bool m_hasappkey = false;
        private JsonSerializer serializer = new JsonSerializer();

        public YTSClient(string appkey = "")
        {
            if (appkey != "")
            {
                m_appkey = appkey;
                m_hasappkey = true;
            }
        }

        public async Task<ListMovieResult> ListMovies(int limit = 20, int page = 1, string quality = "All", int minimum_rating = 0, string query_term = "0", string genre = "", string sort_by = "date_added", string order_by = "desc", bool with_rt_ratings = false)
        {
            var format = "https://yts.ag/api/v2/list_movies.json?limit={0}&page={1}&quality={2}&minimum_rating={3}&query_term={4}&genre={5}&sort_by={6}&order_by={7}&with_rt_ratings={8}";
            using (var client = new HttpClient())
            {
                var data = await client.GetStringAsync(string.Format(format,
                                                                     limit,
                                                                     page,
                                                                     quality,
                                                                     minimum_rating,
                                                                     query_term,
                                                                     genre,
                                                                     sort_by,
                                                                     order_by,
                                                                     with_rt_ratings ? "true" : "false"));
                var info = serializer.Deserialize<ListMovieResult>(new JsonTextReader(new StringReader(data)));
                return info;
            }
        }

        public async Task<MovieDataResult> MovieDetails(int id = 0, bool with_images = false, bool with_cast = false)
        {
            var format = "https://yts.ag/api/v2/movie_details.json?movie_id={0}&with_images={1}&with_cast={2}";
            using (var client = new HttpClient())
            {
                var data = await client.GetStringAsync(string.Format(format, id, with_images ? "true" : "false", with_cast ? "true" : "false"));
                var info = serializer.Deserialize<MovieDataResult>(new JsonTextReader(new StringReader(data)));
                return info;
            }
        }

        public async Task<MovieSuggestionResult> MovieSuggestions(int id = 0)
        {
            var format = "https://yts.ag/api/v2/movie_suggestions.json?movie_id={0}";
            using (var client = new HttpClient())
            {
                var data = await client.GetStringAsync(string.Format(format, id));
                var info = serializer.Deserialize<MovieSuggestionResult>(new JsonTextReader(new StringReader(data)));
                return info;
            }
        }
    }
}
