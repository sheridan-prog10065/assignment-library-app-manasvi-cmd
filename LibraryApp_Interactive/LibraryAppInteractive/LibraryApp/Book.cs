using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

/// <summary>
/// Represents a book in the library
/// </summary>
public class Book
{
    /// <summary>
    /// Stores the Title of the book
    /// </summary>
    private string _title;

    /// <summary>
    /// Stores the ISBN number of the book 
    /// </summary>
    private string _isbn;

    /// <summary>
    /// Stores the Genre of the book
    /// </summary>
    private Genre _genre;

    /// <summary>
    /// Stores the Authors of the book
    /// </summary>
    private List<Author> _authors;

    /// <summary>
    /// Stores the Library Assets of the book
    /// </summary>
    private List<LibraryAsset> _assets;

    /// <summary>
    /// Constructor to initialize book
    /// </summary>
    public Book(string title, string isbn, Genre genre)
    {
        _title = title;
        _isbn = isbn;
        _genre = genre;

        _authors = new List<Author>();
        _assets = new List<LibraryAsset>();
    }

    /// <summary>
    /// Adds an author to the boook
    /// </summary>
    public void AddAuthor(Author author)
    {
        // Add the given author to the list of authors 
    }

    /// <summary>
    /// Adds a library asset to the book 
    /// </summary>
    public void AddAsset(LibraryAsset asset)
    {
        // Add the given asset to the list of assets 
    }

    /// <summary>
    /// Gets all assets of the book
    /// </summary>
    /// <returns></returns>
    public List<LibraryAsset> GetAssets()
    {
        // Return the list of assets for this book 
        return _assets;

    }
}
