public class Book  {
    public int BookId { get; set; }
    public string Name { get; set; }
    public int Pages { get; set; }
    public double Price {get; set;}
    public DateTime? PublishedDate {get; set;} //this is custom scalar type
    public Author? Author { get; set; } //this is a navigation property and ? means it is nullable
}