using Netflix.Dtos;
using Netflix.Mappings;
using Netflix.Models;
using System.Net.Http.Json;

namespace Netflix.Service
{
    public class MovieService(HttpClient http)
    {
        private readonly HttpClient http = http;
        private readonly Random random = new Random();

        public async Task <List<Category>?> GetAllCategories()
        {
            var result = await http.GetFromJsonAsync<List<Category>>("movie-data/categories.json");
            if (result is not null)
            {
                return result.OrderBy(x => x.Name).ToList();
            }
            return null;
        }

        public async Task<List<MovieMiniDto>?> GetRandomMoviesOnMainPage()
        {
            var data = await http.GetFromJsonAsync<List<Movie>>("movie-data/movies.json");
            if (data is not null)
            {
                var result = new List<MovieMiniDto>();
                var rnd = random.Next(0, 94);
                for (int idx = 0; idx < 6; idx++)
                    result.Add(data[rnd + idx].ToMovieMiniDto());

                return result;
            }
            
            return null;
        }
    }
}
