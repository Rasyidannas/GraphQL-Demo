public class Book  {
    public int BookId { get; set; }
    public string Name { get; set; }
    public int Pages { get; set; }
    public double Price {get; set;}
    public DateTime? PublishedDate {get; set;} //this is custom scalar type
    public BookGenre Genre {get; set;} //this is custom enum type
    public Author? Author { get; set; } //this is a navigation property and ? means it is nullable
    public BookReview[]? Reviews { get; set; } //this is a navigation property and [] means it is an Array/List/Collection
}

// enumeration type (often abbreviated as Enum) is a type that is restricted to a particular set of values. 
public enum BookGenre {
    Horor,
    Fantasy,
    Drama,
    Thriller,
    NonFiction
}