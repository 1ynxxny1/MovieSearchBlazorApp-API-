using MovieSearchBlazorApp.Models;

namespace MovieSearchBlazorApp.Services
{
    public class MovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MovieSearchResult[]> SearchMoviesAsync(string query)
        {
            var response = await _httpClient.GetFromJsonAsync<MovieSearchResult[]>($"api/movies/search?title={query}");
            return response;
        }

        public async Task<MovieDetail> GetMovieDetailAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<MovieDetail>($"https://localhost:7063/api/movies/movie/{id}");
        }

    }
}
