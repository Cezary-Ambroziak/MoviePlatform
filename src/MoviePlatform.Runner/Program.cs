using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace MoviePlatform.Runner;

class Program
{
    static void Main(string[] args)
    {
        string csvPath = @"C:/Users/Czarek/Desktop/MoviePlatform/netflix_titles.csv";

        //string csvPath2 = @"C: \Users\Czarek\Desktop\FullStack - Zasoby\googleplaystore1.csv";

        var moviesNetflix = LoadGoogleAps(csvPath);

        //var moviesnetflix = loadgoogleaps(csvpath);

        Display(moviesNetflix);
    }

    static void Display(IEnumerable<Movie> moviesNetflix)
    {
        foreach (var movie in moviesNetflix)
        {
            Console.WriteLine(movie);
        }
    }

    public static List<Movie> LoadGoogleAps(string csvPath)
    {
        using var reader = new StreamReader(csvPath);
        var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",",
            NewLine = ";;",
            BadDataFound = null

        };
        using var csv = new CsvReader(reader, configuration);
        csv.Context.RegisterClassMap<MoviesMap>();

        var records = csv.GetRecords<Movie>().Take(50).ToList();
        return records;
    }
}
