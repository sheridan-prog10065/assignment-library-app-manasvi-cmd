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
    private List<Author> authors;

    /// <summary>
    /// Stores the Library Assets of the book
    /// </summary>
    private List<LibraryAsset> assets;
}
