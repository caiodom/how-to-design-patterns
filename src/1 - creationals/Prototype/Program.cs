using Prototype.Models;

var author = new Author { Name = "John Doe", Biography = "An experienced writer." };
var book = new Book
{
    Title = "C# Programming",
    PublicationDate = DateTime.Now,
    Id = "B123",
    Author = author,
    Publisher = "TechBooks"
};

var editor = new Editor { Name = "Jane Smith", Experience = "10 years" };
var magazine = new Magazine
{
    Title = "Tech Monthly",
    PublicationDate = DateTime.Now,
    Id = "M456",
    IssueNumber = 42,
    Editor = editor
};

var director = new Director { Name = "Steven Spielberg", Filmography = "Famous films" };
var dvd = new DVD
{
    Title = "Jurassic Park",
    PublicationDate = DateTime.Now,
    Id = "D789",
    Director = director,
    Duration = new TimeSpan(2, 7, 0)
};

//Clones
var bookClone = book.Clone() as Book;
bookClone.Title= "Advanced C# Programming";
bookClone.Author.Name = "Jane Doe";

var magazineClone = magazine.Clone() as Magazine;
magazineClone.Title = "Tech Weekly";
magazineClone.Editor.Name = "John Smith";

var dvdClone = dvd.Clone() as DVD;
dvdClone.Title = "Jurassic World";
dvdClone.Director.Name = "J. A. Bayona";

Console.WriteLine("Originals:");
Console.WriteLine(book);
Console.WriteLine(magazine);
Console.WriteLine(dvd);

Console.WriteLine("\nClones:");
Console.WriteLine(bookClone);
Console.WriteLine(magazineClone);
Console.WriteLine(dvdClone);