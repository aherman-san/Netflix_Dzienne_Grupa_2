using Netflix.Dtos;
using Netflix.Models;

namespace Netflix.Mappings;

public static class Mapper
{
    public static MovieMiniDto ToMovieMiniDto(this Movie movie)
    {
        return new MovieMiniDto
        {
           Id = movie.Id,
           Title = movie.Title!
        };
    }
}
