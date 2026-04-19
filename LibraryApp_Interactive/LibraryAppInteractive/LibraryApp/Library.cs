namespace LibraryAppInteractive;

/// <summary>
/// Defines the Library class used to manage the library books and assets.
///
/// NOTE: A single object/instance of this class (called a "singleton") is created and shared automatically
/// with the two pages in the application through the process of Dependency Injection handled and configured
/// in MauiProgram class.  
/// </summary>
public class Library
{
    private List<Book> _books;

    /// <summary>
    /// Constructor to initialize library
    /// </summary>
    public Library()
    {
        _books = new List<Book>();
    }

    /// <summary>
    /// Adds a book to the library
    /// </summary>
    public void AddBook(Book book)
    {
        // add the given book to the list of books in the library
    }

    /// <summary>
    /// Serches for books by title
    /// </summary>
    public List<Book> SearchBooks(string title)
    {
        //create a list to store matching books 
        // Go through each book in the library 
            // If the book title matches the given title 
            //add the book to the result list
        //return the list of matching books 
        return null;
    }

    /// <summary>
    /// Gets all book in the library 
    /// </summary>
    public List<Book> GetBooks()
    {
        //return the list of all books in the library 
        return null;
    }
}