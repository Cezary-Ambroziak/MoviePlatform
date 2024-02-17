using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePlatform.Runner;

public class Movie
{
    public string Id { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public string Cast { get; set; }
    public string Country { get; set; }
    public string DateAdded { get; set; }
    public string ReleaseYear { get; set; }
    public string Rating { get; set; }
    public string Duration { get; set; }
    public string ListedIn { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return
        $"{Id,-2} | " +
        $"{Type,-5} | " +
        $"{(Title.Length > 20 ? Title.Substring(0, 20) + "..." : Title),-23} | " +
        $"{Director,-20} | " +
        $"{(Cast.Length > 20 ? Cast.Substring(0, 20) + "..." : Cast),-15} | " +
        $"{Country,-5} | " +
        $"{DateAdded,-4} | " +
        $"{ReleaseYear,-7} | " +
        $"{Rating,-10} | " +
        $"{Duration,-10} | " +
        $"{ListedIn,-10} | " +
        $"{Description,-10} | ";
    }
}

