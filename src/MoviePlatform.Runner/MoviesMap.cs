using CsvHelper.Configuration;

namespace MoviePlatform.Runner;

public sealed class MoviesMap : ClassMap<Movie>
{
    public MoviesMap()
    {
        Map(m => m.Id).Name(nameof(Movie.Id));
        Map(m => m.Type).Name(nameof(Movie.Type));
        Map(m => m.Title).Name(nameof(Movie.Title));
        Map(m => m.Director).Name(nameof(Movie.Director));
        Map(m => m.Cast).Name(nameof(Movie.Cast));
        Map(m => m.Country).Name(nameof(Movie.Country));
        Map(m => m.DateAdded).Name(nameof(Movie.DateAdded));
        Map(m => m.ReleaseYear).Name(nameof(Movie.ReleaseYear));
        Map(m => m.Rating).Name(nameof(Movie.Rating));
        Map(m => m.Duration).Name(nameof(Movie.Duration));
        Map(m => m.ListedIn).Name(nameof(Movie.ListedIn));
        Map(m => m.Description).Name(nameof(Movie.Description));
    }
}
